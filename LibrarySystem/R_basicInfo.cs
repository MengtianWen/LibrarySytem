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
    public partial class R_basicInfo : Form
    {
        public R_basicInfo()
        {
            InitializeComponent();
        }

        //加载基础信息窗口
        private void R_basicInfo_Load(object sender, EventArgs e)
        {
            SqlConnection conn= SQLbase.getConn();
            try
            {
                if(conn.State==ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string RID = LogWindow.logname;
                SqlCommand selectCmd = new SqlCommand("select * from readers where RID='" + RID + "'", conn);
                SqlDataReader datareader = selectCmd.ExecuteReader();
                if (datareader.Read())
                {
                    label_ID.Text = RID;
                    label_name.Text = datareader["Rname"].ToString();
                    label_gender.Text = datareader["Rgender"].ToString();
                    label_address.Text = datareader["Raddress"].ToString();
                    label_age.Text = datareader["Rage"].ToString();
                    label_unit.Text = datareader["Runit"].ToString();
                    label_type.Text = datareader["Rtype"].ToString();
                    label_state.Text = datareader["Rstate"].ToString();
                }
                else
                {
                    MessageBox.Show("查询出错");
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
