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
    public partial class A_booksQuery : Form
    {
        public A_booksQuery()
        {
            InitializeComponent();
        }

        //加载窗口
        private void A_booksQuery_Load(object sender, EventArgs e)
        {
            comboBox_QueryStyle.Items.Add("按书号查询");
            comboBox_QueryStyle.Items.Add("按书名查询");
            comboBox_QueryStyle.Items.Add("按作者查询");
            comboBox_QueryStyle.Items.Add("按出版社查询");
        }

        //图书查询
        private void button1_Click(object sender, EventArgs e)

        {
            SqlConnection conn = SQLbase.getConn();
            try
            {
                this.datagridview.Rows.Clear();
                if(conn.State==ConnectionState.Open)
                {
                    conn.Close();
                }
                //打开连接
                conn.Open();
                string selectStr = "select * from books";
                //按书号查询
                if (comboBox_QueryStyle.SelectedIndex == 0)
                {
                    string bid = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from books where BID=" + bid;
                }
                //按书名查询
                else if (comboBox_QueryStyle.SelectedIndex == 1)
                {
                    string bname = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from books where Bname= '" + bname + "'";
                }
                //按作者查询
                else if (comboBox_QueryStyle.SelectedIndex == 2)
                {
                    string bauthor = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from books where Bauthor= '" + bauthor + "'";
                }
                //按出版社查询
                else if (comboBox_QueryStyle.SelectedIndex == 3)
                {
                    string bpublisher = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from books where Bpublisher= '" + bpublisher + "'";
                }
                //没有选择下拉框，则查询全部
                SqlCommand SelectCmd = new SqlCommand(selectStr, conn);
                SqlDataReader datareader = SelectCmd.ExecuteReader();
                string Bid, Bname, Bauthor, Bpublisher, Btype, Bstate;
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

        //图书入库
        private void btn_add_Click(object sender, EventArgs e)
        {
            A_BooksAdd add = new A_BooksAdd();
            add.Show(this);
          
        }


        //图书删除
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(this.datagridview.SelectedCells!=null)
            { 
            string Bid = this.datagridview.SelectedCells[0].Value.ToString();
            SqlConnection conn = SQLbase.getConn();
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string deletestr = "delete from Books where BID='" + Bid + "'";
                SqlCommand deletecmd = new SqlCommand(deletestr,conn);
                int result = deletecmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("删除成功！重新查询即可查看");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                    
                }
                SQLbase.close(deletecmd);
            }
            catch
            {
                MessageBox.Show("操作有误！");
            }
            SQLbase.close(conn);
            }
            else
            {
                MessageBox.Show("未选中任何记录！");
            }
        }

    }
}
