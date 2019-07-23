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
    public partial class R_BooksQuery : Form
    {
        public R_BooksQuery()
        {
            InitializeComponent();
            comboBox_QueryStyle.Items.Add("按书号查询");
            comboBox_QueryStyle.Items.Add("按书名查询");
            comboBox_QueryStyle.Items.Add("按作者查询");
            comboBox_QueryStyle.Items.Add("按出版社查询");
        }

        //点错了，没用
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //查询按钮的响应事件
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLbase.getConn();
            try
            {
                
                conn.Open();
                string selectStr="select * from books";
                //按书号查询
                if (comboBox_QueryStyle.SelectedIndex == 0)
                {
                    string bid = txt_query.Text.ToString();
                    //建立查询命令
                     selectStr = "select * from books where BID=" + bid;
                }
                //按书名查询
                else if(comboBox_QueryStyle.SelectedIndex==1)
                {
                    string bname = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from books where Bname= '" + bname+"'";
                }
                //按作者查询
                else if(comboBox_QueryStyle.SelectedIndex==2)
                {
                    string bauthor = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from books where Bauthor= '" + bauthor+"'";
                }
                //按出版社查询
                else if(comboBox_QueryStyle.SelectedIndex==3)
                {
                    string bpublisher = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from books where Bpublisher= '" + bpublisher+"'";
                }
                //没有选择下拉框，则查询全部
                SqlCommand SelectCmd = new SqlCommand(selectStr, conn);
                SqlDataReader datareader = SelectCmd.ExecuteReader();
                string Bid, Bname, Bauthor, Bpublisher, Btype,Bstate;
                int rowindex = 0;
                this.datagridview.Rows.Clear();
                while (datareader.Read())
                {
                    Bid = datareader["BID"].ToString();
                    Bname = datareader["Bname"].ToString();
                    Bauthor = datareader["Bauthor"].ToString();
                    Bpublisher = datareader["Bpublisher"].ToString();
                    Btype = datareader["Btype"].ToString();
                    Bstate = datareader["Bstate"].ToString();
                    
                    rowindex = this.datagridview.Rows.Add();
                    //trim函数同于去除字符串两头的空格
                    this.datagridview.Rows[rowindex].Cells[0].Value = Bid.Trim();
                    this.datagridview.Rows[rowindex].Cells[1].Value = Bname.Trim();
                    this.datagridview.Rows[rowindex].Cells[2].Value = Bauthor.Trim();
                    this.datagridview.Rows[rowindex].Cells[3].Value = Bpublisher.Trim();
                    this.datagridview.Rows[rowindex].Cells[4].Value = Btype.Trim();
                    this.datagridview.Rows[rowindex].Cells[5].Value = Bstate.Trim();

                }
            }
            catch
            {
                MessageBox.Show("查无此书！");
            }
            SQLbase.close(conn);
        }


        //借阅按钮的响应事件
        private void button2_Click(object sender, EventArgs e)
        {
            if(this.datagridview.SelectedCells[0]!=null)
            {
                string Bid,Bstate;
                Bid=this.datagridview.SelectedCells[0].Value.ToString();
                Bstate = this.datagridview.SelectedCells[5].Value.ToString();
                if (Bstate == "0")
                {
                    MessageBox.Show("该书本已借出，此时不可借阅！");
                }
                else
                {
                    try
                    {
                        SqlConnection conn = SQLbase.getConn();
                        conn.Open();
                        //借阅图书之后，该图书数量减一，在借阅表格中添加一条记录
                        //图书数量-1
                        int amount = Convert.ToInt32(Bstate) - 1;
                        string updateStr = "update Books set Bstate=" + amount + " where BID ='" + Bid + "'";
                        SqlCommand updateCmd = new SqlCommand(updateStr, conn);
                        int result_update = updateCmd.ExecuteNonQuery();

                        string RID = LogWindow.logname;

                        string date1 = DateTime.Now.ToShortDateString().ToString();
                        string date2 = DateTime.Now.AddMonths(1).ToShortDateString().ToString();
                        //借阅表中添加一条记录
                        string insertStr = "insert into Borrow values('" + Bid + "','" + RID + "','" + date1 + "','" + date2 + "',null," + "'借阅中')";
                        SqlCommand insertCmd = new SqlCommand(insertStr, conn);
                        int result_insert = insertCmd.ExecuteNonQuery();
                        if (result_insert == 1 && result_update == 1)
                        {
                            MessageBox.Show("借阅成功！");
                        }
                        else
                        {
                            MessageBox.Show("借阅失败！");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("操作异常", "错误提示");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("未选中任何记录！");
            }
        }
        
        private void R_BooksQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
