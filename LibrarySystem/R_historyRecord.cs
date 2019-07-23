using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class R_historyRecord : Form
    {
        public R_historyRecord()
        {
            InitializeComponent();
        }

        public string  select(SqlConnection con, string Bid)
        {
            //查询书名
            string Bname=" ";
            string selectStr = "select Bname from Books where BID='" + Bid + "'";
            SqlCommand selectCmd = con.CreateCommand();
            selectCmd.CommandText = selectStr;
            SqlDataReader data = selectCmd.ExecuteReader();
            if(data.Read())
            {
                Bname = data["Bname"].ToString();
            }

            data.Close();
            SQLbase.close(selectCmd);
            return Bname; 
        }

        //加载窗口函数
        private void R_historyRecord_Load(object sender, EventArgs e)
        {
            SqlConnection conn=SQLbase.getConn();
            try
            {
                if (conn.State==ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string RID = LogWindow.logname;
                SqlCommand selectCmd = new SqlCommand("select BID,BorrowDate,ReturnDate,RealDate,Note from Borrow where RID='" + RID + "'", conn);
                SqlDataReader datareader = selectCmd.ExecuteReader();
                string Bid,Bname, BorrowDate, ReturnDate, RealDate, Note;
                int rowindex = 0;
                this.dataGridView1.Rows.Clear();

                while (datareader.Read())
                {
                    Bid = datareader["BID"].ToString();
                    BorrowDate = datareader["BorrowDate"].ToString();
                    ReturnDate = datareader["ReturnDate"].ToString();
                    RealDate = datareader["RealDate"].ToString();
                    Note = datareader["Note"].ToString();
                    

                    rowindex = this.dataGridView1.Rows.Add();
                    //trim函数同于去除字符串两头的空格
                    this.dataGridView1.Rows[rowindex].Cells[0].Value = Bid.Trim();
                    this.dataGridView1.Rows[rowindex].Cells[2].Value = BorrowDate.Trim();
                    this.dataGridView1.Rows[rowindex].Cells[3].Value = ReturnDate.Trim();
                    this.dataGridView1.Rows[rowindex].Cells[4].Value = RealDate.Trim();
                    this.dataGridView1.Rows[rowindex].Cells[5].Value = Note.Trim();
                }
                datareader.Close();
                SQLbase.close(selectCmd);
                int n = this.dataGridView1.RowCount;
                for(int i=0;i<n;i++)
                {
                    Bid = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Bname = select(conn, Bid);
                    this.dataGridView1.Rows[i].Cells[1].Value = Bname.Trim();
                }

            }
            catch
            {
                MessageBox.Show("操作错误！");
            }

            SQLbase.close(conn);
        }
    }
}
