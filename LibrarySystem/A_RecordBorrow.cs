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
    public partial class A_RecordBorrow : Form
    {
        public A_RecordBorrow()
        {
            InitializeComponent();
        }

        //根据书号查询书名
        public string selectBook(SqlConnection con, string Bid)
        {
            //查询书名
            string Bname = " ";
            string selectStr = "select Bname from Books where BID='" + Bid + "'";
            SqlCommand selectCmd = con.CreateCommand();
            selectCmd.CommandText = selectStr;
            SqlDataReader data = selectCmd.ExecuteReader();
            if (data.Read())
            {
                Bname = data["Bname"].ToString();
            }

            data.Close();
            SQLbase.close(selectCmd);
            return Bname;
        }

        //根据读者号查询读者名
        public string selectReader(SqlConnection con, string Rid)
        {
            //查询读者名
            string Rname = " ";
            string selectStr = "select Rname from Readers where RID='" + Rid + "'";
            SqlCommand selectCmd = con.CreateCommand();
            selectCmd.CommandText = selectStr;
            SqlDataReader data = selectCmd.ExecuteReader();
            if (data.Read())
            {
                Rname = data["Rname"].ToString();
            }

            data.Close();
            SQLbase.close(selectCmd);
            return Rname;
        }

        //查询按钮
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLbase.getConn();
            try
            {
                this.datagridview.Rows.Clear();   //清空表格
                //打开连接
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string selectStr = "select * from Borrow";
                //按读者号查询
                if (comboBox_QueryStyle.SelectedIndex == 0)
                {
                    string rid = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from Borrow where RID=" + rid;
                }
                //按书号查询
                else if (comboBox_QueryStyle.SelectedIndex == 1)
                {
                    string bid = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from Borrow where BID=" + bid;
                }
                //没有选择下拉框，则查询全部
                SqlCommand selectCmd = new SqlCommand(selectStr,conn);
                SqlDataReader datareader = selectCmd.ExecuteReader();
                string BID, Bname,RID,Rname, BorrowDate, RealDate, Note;
                int rowindex = 0;
                this.datagridview.Rows.Clear();

                while (datareader.Read())
                {
                    RID = datareader["RID"].ToString();
                    BID = datareader["BID"].ToString();
                    BorrowDate = datareader["BorrowDate"].ToString();
                    RealDate = datareader["RealDate"].ToString();
                    Note = datareader["Note"].ToString();
                    
                    rowindex = this.datagridview.Rows.Add();
                    //trim函数同于去除字符串两头的空格
                    this.datagridview.Rows[rowindex].Cells[0].Value = BID.Trim();
                    this.datagridview.Rows[rowindex].Cells[2].Value = RID.Trim();
                    this.datagridview.Rows[rowindex].Cells[4].Value = BorrowDate.Trim();
                    this.datagridview.Rows[rowindex].Cells[5].Value = RealDate.Trim();
                    this.datagridview.Rows[rowindex].Cells[6].Value = Note.Trim();
                }
                datareader.Close();
                SQLbase.close(selectCmd);
                int n = this.datagridview.RowCount;
                for (int i = 0; i < n; i++)
                {
                    //填充书名
                    BID = this.datagridview.Rows[i].Cells[0].Value.ToString();
                    Bname = selectBook(conn, BID);
                    this.datagridview.Rows[i].Cells[1].Value = Bname.Trim();
                    //填充作者名
                    RID = this.datagridview.Rows[i].Cells[2].Value.ToString();
                    Rname = selectReader(conn, RID);
                    this.datagridview.Rows[i].Cells[3].Value = Rname.Trim();
                }
            }
            catch
            {
                MessageBox.Show("查无此记录！");
            }
            SQLbase.close(conn);
        }

        //加载窗口
        private void A_RecordBorrow_Load(object sender, EventArgs e)
        {
            comboBox_QueryStyle.Items.Add("按读者号查询");
            comboBox_QueryStyle.Items.Add("按图书号查询");
        }
    }
}
