using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem
{
    public partial class R_BooksReturn : Form
    {
        public R_BooksReturn()
        {
            InitializeComponent();
        }


        //窗口加载函数
        private void R_BooksReturn_Load(object sender, EventArgs e)
        {
            SqlConnection conn = SQLbase.getConn();
            try
            {
                if(conn.State==ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                String RID = LogWindow.logname;

                //查询书籍信息
                string selectStr = "select BID,Bname,Bauthor,Bpublisher,Btype from Books where BID IN(select BID from Borrow where RID='" + RID + "'and Note in('借阅中','已续借','待审核')) ORDER BY BID ASC";
                SqlCommand selectCmd1 = conn.CreateCommand();
                selectCmd1.CommandText = selectStr;
                SqlDataReader datareader1 = selectCmd1.ExecuteReader();

                string Bid, Bname, Bauthor, Bpublisher, Btype;
                int rowindex = 0;
                this.datagridview.Rows.Clear();
                while (datareader1.Read())
                {
                    Bid = datareader1["BID"].ToString();
                    Bname = datareader1["Bname"].ToString();
                    Bauthor = datareader1["Bauthor"].ToString();
                    Bpublisher = datareader1["Bpublisher"].ToString();
                    Btype = datareader1["Btype"].ToString();
                   

                    rowindex = this.datagridview.Rows.Add();
                    //trim函数同于去除字符串两头的空格
                    this.datagridview.Rows[rowindex].Cells[0].Value = Bid.Trim();
                    this.datagridview.Rows[rowindex].Cells[1].Value = Bname.Trim();
                    this.datagridview.Rows[rowindex].Cells[2].Value = Bauthor.Trim();
                    this.datagridview.Rows[rowindex].Cells[3].Value = Bpublisher.Trim();
                    this.datagridview.Rows[rowindex].Cells[4].Value = Btype.Trim();
                  
                }
                SQLbase.close(selectCmd1);
                //必须关闭当前的dataReader才能继续
                datareader1.Close();
                //查询应还日期和借阅状态
                string selectStr2 = "select BID,ReturnDate,Note from Borrow where RID='"+RID+"'order by BID ASC";
                SqlCommand selectCmd2 = conn.CreateCommand();
                selectCmd2.CommandText = selectStr2;
                SqlDataReader datareader2 = selectCmd2.ExecuteReader();
                string return_date;
                string note;
                int index = 0;
                while(datareader2.Read())
                {
                    if (index < this.datagridview.RowCount)
                    {
                        return_date = datareader2["ReturnDate"].ToString();
                        note = datareader2["Note"].ToString();
                        this.datagridview.Rows[index].Cells[5].Value = return_date.Trim();
                        this.datagridview.Rows[index].Cells[6].Value = note.Trim();
                        index++;
                    }
                }
                datareader2.Close();
                SQLbase.close(selectCmd2);
            }
            catch
            {
                MessageBox.Show("操作异常", "错误提示");
            }
            SQLbase.close(conn);
        }


        //归还图书响应事件
        private void btn_return_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLbase.getConn();
            try
            { 
                conn.Open();
                //判断是否超期
                int result,result1;
                string datestr=this.datagridview.SelectedCells[5].Value.ToString().Trim();
                DateTime shoulddate = Convert.ToDateTime(datestr);
                DateTime realdate = DateTime.Now;
                if(shoulddate.CompareTo(realdate)>=0)
                {
                    MessageBox.Show("图书未超期，请放心归还！");
                }
                else
                {
                    MessageBox.Show("图书已超期，请自觉缴纳罚款!");
                    //跳转至罚款页面？？？？？？？？？？？？
                    string updateStr = "update Readers set Rstate=1";
                    SqlCommand updateCmd = new SqlCommand(updateStr, conn);
                    result = updateCmd.ExecuteNonQuery();
                    if(result==1)
                    {
                        MessageBox.Show("欠款状态修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("欠款状态修改失败！");
                    }
                    SQLbase.close(updateCmd);
                }

                //往图书归还表中添加记录
                string Bid,Bname="";
                Bid = this.datagridview.SelectedCells[0].Value.ToString();
                SqlCommand selectCmd1 = new SqlCommand("select Bname from books where BID='" + Bid + "'",conn);
                SqlDataReader datareader = selectCmd1.ExecuteReader();
                if (datareader.Read())
                {
                    Bname = datareader["Bname"].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("查询出错");
                }
                datareader.Close();
                SQLbase.close(selectCmd1);
                string RID = LogWindow.logname;
                string insertstr = "insert into Returntable values('"+RID+"','"+Bid+"','"+Bname+"')";
                SqlCommand insertCmd = new SqlCommand(insertstr, conn);
                result = insertCmd.ExecuteNonQuery();
                if (result == 1)
                {
                    //如果归还成功，直接在借阅表中把备注改为“待审核”即可。不用从表中删除
                    string updateStr = "update Borrow set Note= '待审核' where BID='" + Bid + "'and RID='" + RID + "'";
                    SqlCommand deleteCmd = new SqlCommand(updateStr, conn);
                    result1=deleteCmd.ExecuteNonQuery();
                    if (result1 == 1)
                    { MessageBox.Show("图书归还成功！请耐心等待审核", "消息"); }
                    else { MessageBox.Show("图书归还失败！", "消息"); }
                }
                else
                {
                    MessageBox.Show("图书归还失败！", "消息");
                }
            }
            catch
            {
                MessageBox.Show("操作有误！", "错误提示");
            }
            SQLbase.close(conn);
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLbase.getConn();
            try
            {
                conn.Open();

                string RID = LogWindow.logname;
                string Bid = this.datagridview.SelectedCells[0].Value.ToString();

                //判断是否超期和是否续借
                int result;
                string datestr = this.datagridview.SelectedCells[5].Value.ToString().Trim();
                string notice = this.datagridview.SelectedCells[6].Value.ToString().Trim();
                DateTime shoulddate = Convert.ToDateTime(datestr);
                DateTime realdate = DateTime.Now;
                if (shoulddate.CompareTo(realdate) >= 0&&notice.Equals("借阅中"))//图书未超期且未续借
                {
                    //应还日期后推一个月
                    string finaldate = shoulddate.AddMonths(1).ToShortDateString().ToString();
                    string updateStr = "update Borrow set ReturnDate='" + finaldate + "',Note='已续借' where RID='" + RID + "'and BID='" + Bid + "'";
                    SqlCommand updateCmd = new SqlCommand(updateStr, conn);
                    result = updateCmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("图书续借成功！");
                        this.datagridview.SelectedCells[5].Value = finaldate;
                    }
                    else { MessageBox.Show("图书续借失败！"); }
                }
                else if (notice.Equals("已续借"))
                {
                    MessageBox.Show("图书只能续借一次！");
                }
                else
                {
                    MessageBox.Show("图书已超期，不能续借!");
                }
            }
            catch
            {
                MessageBox.Show("操作有误！", "错误提示");
            }
            SQLbase.close(conn);
        }
    }
}
