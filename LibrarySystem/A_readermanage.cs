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
    public partial class A_readermanage : Form
    {
        public A_readermanage()
        {
            InitializeComponent();
        }


        //读者查询
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SQLbase.getConn();
            try
            {
                this.datagridview.Rows.Clear();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string selectStr = "select * from readers";
                //按读者号查询
                if (comboBox_QueryStyle.SelectedIndex == 0)
                {
                    string id = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from readers where RID=" + id;
                }
                //按读者名查询
                else if (comboBox_QueryStyle.SelectedIndex == 1)
                {
                    string name = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from readers where Rname= '" +name + "'";
                }
                //按单位查询
                else if (comboBox_QueryStyle.SelectedIndex == 2)
                {
                    string unit = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from readers where Runit= '" + unit + "'";
                }
                //按类型查询
                else if (comboBox_QueryStyle.SelectedIndex == 3)
                {
                    string type = txt_query.Text.ToString();
                    //建立查询命令
                    selectStr = "select * from readers where Rtype= '" + type + "'";
                }
                //没有选择下拉框，则查询全部
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
                MessageBox.Show("查无此人！");
            }
            SQLbase.close(conn);
        }

        //加载窗口
        private void A_readermanage_Load(object sender, EventArgs e)
        {
            comboBox_QueryStyle.Items.Add("按读者号查询");
            comboBox_QueryStyle.Items.Add("按读者名查询");
            comboBox_QueryStyle.Items.Add("按单位查询");
            comboBox_QueryStyle.Items.Add("按类型查询");
        }

        //添加读者
        private void btn_add_Click(object sender, EventArgs e)
        {
            A_ReadersAdd add = new A_ReadersAdd();
            add.Show(this);
        }


        //删除读者
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.datagridview.SelectedCells[0] != null)
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
                    string deletestr = "delete from Readers where RID='" + Rid + "'";
                    SqlCommand deletecmd = new SqlCommand(deletestr, conn);
                    int result = deletecmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("删除成功！重新查询即可查看记录");
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
