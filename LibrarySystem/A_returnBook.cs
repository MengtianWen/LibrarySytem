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
    public partial class A_returnBook : Form
    {
        public A_returnBook()
        {
            InitializeComponent();
        }

        //加载窗口
        private void A_returnBook_Load(object sender, EventArgs e)
        {
            SqlConnection conn = SQLbase.getConn();
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                SqlCommand selectCmd = new SqlCommand("select * from returntable", conn);
                SqlDataReader datareader = selectCmd.ExecuteReader();
                string RID, BID, Bname;
                int rowindex = 0;
                this.datagridview.Rows.Clear();
                while (datareader.Read())
                {
                    RID = datareader["RID"].ToString();
                    Bname = datareader["Bname"].ToString();
                    BID = datareader["BID"].ToString();
                    
                    rowindex = this.datagridview.Rows.Add();
                    //trim函数同于去除字符串两头的空格
                    this.datagridview.Rows[rowindex].Cells[0].Value = RID.Trim();
                    this.datagridview.Rows[rowindex].Cells[1].Value = BID.Trim();
                    this.datagridview.Rows[rowindex].Cells[2].Value = Bname.Trim();
                    
                }
            }
            catch
            {
                MessageBox.Show("操作错误！");
            }
        }

        //同意归还，将这条记录从这个表删除，并且将该图书数量+1.
        private void button1_Click(object sender, EventArgs e)
        {
            if(this.datagridview.SelectedCells!=null)
            {
                string Bid = this.datagridview.SelectedCells[1].Value.ToString();
                string Rid = this.datagridview.SelectedCells[0].Value.ToString();
                SqlConnection conn= SQLbase.getConn();
                try
                {
                    if (conn.State==ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();
                    string deletestr = "delete from returntable where BID='" + Bid + "'";
                    SqlCommand deletecmd = new SqlCommand(deletestr, conn);
                    int result = deletecmd.ExecuteNonQuery();
                    SQLbase.close(deletecmd);
                    if(result==1)//删除成功了
                    {
                        //更新图书表的数量信息
                        SqlCommand upcmd = new SqlCommand("update Books set Bstate=Bstate+1 where BID='" + Bid + "'", conn);
                        int result1 = upcmd.ExecuteNonQuery();
                        if(result1==1)
                        {
                            MessageBox.Show("操作成功！");
                        }
                        else
                        {
                            MessageBox.Show("操作失败！");
                        }

                        //更新借阅表的信息
                        string date = DateTime.Now.ToShortDateString().ToString();
                        string updateStr = "update Borrow set Note= '已归还',realDate='" + date + "' where BID='" + Bid + "'and RID='" + Rid + "'";
                        SqlCommand updateCmd = new SqlCommand(updateStr, conn);
                        result1 = updateCmd.ExecuteNonQuery();
                        if (result1 == 1)
                        { MessageBox.Show("图书归还成功！", "消息"); }
                        else { MessageBox.Show("图书归还失败！", "消息"); }
                    }
                    else
                    {
                        MessageBox.Show("操作失败！");
                    }
                }
                catch
                {
                    MessageBox.Show("操作有误！");
                }


            }
            else
            {
                MessageBox.Show("未选中任何记录！");
            }
        }

        //拒绝归还图书
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("图书信息有误！请前往服务台办理！");
        }
    }
}
