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
    public partial class R_updateInfo : Form
    {
        public R_updateInfo()
        {
            InitializeComponent();
        }

        //加载窗口
        private void R_updateInfo_Load(object sender, EventArgs e)
        {
            
            SqlConnection conn = SQLbase.getConn();
            try
            {
                if (conn.State == ConnectionState.Open)
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
                    txt_name.Text = datareader["Rname"].ToString().Trim();
                    txt_gender.Text = datareader["Rgender"].ToString().Trim();
                    txt_address.Text = datareader["Raddress"].ToString().Trim();
                    txt_age.Text = datareader["Rage"].ToString().Trim();
                    txt_unit.Text = datareader["Runit"].ToString().Trim();
                    txt_type.Text = datareader["Rtype"].ToString().Trim();
                    txt_pwd.Text = datareader["Rpassword"].ToString().Trim();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string RID = LogWindow.logname;
            string name, gender, age, address, unit, type, pwd;
            name = txt_name.Text.ToString();
            gender = txt_gender.Text.ToString();
            age = txt_age.Text.ToString();
            address = txt_address.Text.ToString();
            unit = txt_unit.Text.ToString();
            type = txt_type.Text.ToString();
            pwd = txt_pwd.Text.ToString();

            
            SqlConnection conn = SQLbase.getConn();
            try
            {
                if(conn.State==ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                SqlCommand upCmd = conn.CreateCommand();
                string updatestr = "update Readers set Rname='" + name
                + "',Rgender='" + gender + "',Raddress='" + address + "',Rage='" +
                age + "',Runit='" + unit + "',Rtype='" + type + "',Rpassword='" + pwd
                + "' where RID='" + RID + "'";
                upCmd.CommandText = updatestr;
                int result = upCmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("信息修改成功！");
                }
                else
                {
                    MessageBox.Show("信息修改失败！");
                }
                SQLbase.close(upCmd);
            }
            catch
            {
                MessageBox.Show("操作有误！");
            }

            SQLbase.close(conn);
            this.Close();
        }
    }
}
