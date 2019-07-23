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
    public partial class A_FineReader : Form
    {
        public A_FineReader()
        {
            InitializeComponent();
        }


        //确认罚款
        //如果读者状态为0，弹出提示，不需罚款。否则把状态改为0 
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.datagridview.SelectedCells != null||Convert.ToInt32(  this.datagridview.SelectedCells[5].Value)==0)
            {
                string Rid = this.datagridview.SelectedCells[0].Value.ToString();
                SqlConnection conn = SQLbase.getConn();
                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();
                    string updatestr = "update Readers set Rstate = 0  where RID='" + Rid + "'";
                    SqlCommand updatecmd = new SqlCommand(updatestr, conn);
                    int result = updatecmd.ExecuteNonQuery();
                    SQLbase.close(updatecmd);
                    if (result == 1)
                    {
                        MessageBox.Show("操作成功！");
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

        //对读者罚款
        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void A_FineReader_Load(object sender, EventArgs e)
        {
            SqlConnection conn = SQLbase.getConn();
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string selectStr="select * from readers where Rstate > 0";
                SqlCommand SelectCmd = new SqlCommand(selectStr, conn);
                SqlDataReader datareader = SelectCmd.ExecuteReader();
                string Rid, Rname, Rgender, Runit, Rtype, Rstate;
                int rowindex = 0;
                this.datagridview.Rows.Clear();
                while (datareader.Read())
                {
                    Rid = datareader["RID"].ToString();
                    Rname = datareader["Rname"].ToString();
                    Rgender = datareader["Rgender"].ToString();
                    Runit = datareader["Runit"].ToString();
                    Rtype = datareader["Rtype"].ToString();
                    Rstate = datareader["Rstate"].ToString();

                    rowindex = this.datagridview.Rows.Add();
                    //trim函数同于去除字符串两头的空格
                    this.datagridview.Rows[rowindex].Cells[0].Value = Rid.Trim();
                    this.datagridview.Rows[rowindex].Cells[1].Value = Rname.Trim();
                    this.datagridview.Rows[rowindex].Cells[2].Value = Rgender.Trim();
                    this.datagridview.Rows[rowindex].Cells[3].Value = Runit.Trim();
                    this.datagridview.Rows[rowindex].Cells[4].Value = Rtype.Trim();
                    this.datagridview.Rows[rowindex].Cells[5].Value = Rstate.Trim();

                }
            }
            catch
            {
                MessageBox.Show("操作错误！");
            }
        }
    }
}
