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
    public partial class A_updateInfo : Form
    {
        public A_updateInfo()
        {
            InitializeComponent();
        }

        //加载初始信息
        private void A_updateInfo_Load(object sender, EventArgs e)
        {
            SqlConnection conn = SQLbase.getConn();
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string AID = LogWindow.logname;
                SqlCommand selectCmd = new SqlCommand("select * from Administrators where AID='" + AID + "'", conn);
                SqlDataReader datareader = selectCmd.ExecuteReader();
                if (datareader.Read())
                {
                    label_ID.Text = AID;
                    txt_name.Text = datareader["Aname"].ToString().Trim();
                    txt_gender.Text = datareader["Agender"].ToString().Trim();
                    txt_address.Text = datareader["Aaddress"].ToString().Trim();
                    txt_number.Text = datareader["Anumber"].ToString().Trim();
                    txt_phone.Text = datareader["Atel"].ToString().Trim();
                    txt_pwd.Text = datareader["Apassword"].ToString().Trim();
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

        //确认更改信息
        private void button1_Click(object sender, EventArgs e)
        {
            string AID = LogWindow.logname;
            string name, gender, number, address, phone, pwd;
            name = txt_name.Text.ToString();
            gender = txt_gender.Text.ToString();
            address = txt_address.Text.ToString();
            phone = txt_phone.Text.ToString();
            number = txt_number.Text.ToString();
            pwd = txt_pwd.Text.ToString();
            
            SqlConnection conn = SQLbase.getConn();
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                SqlCommand upCmd = conn.CreateCommand();
                string updatestr = "update Administrators set Anumber='"+number+"',Aname='" + name
                + "',Agender='" + gender + "',Aaddress='" + address + "',Atel='" +
                phone + "',Apassword='" + pwd
                + "' where AID='" + AID + "'";
                upCmd.CommandText = updatestr;
                int result = upCmd.ExecuteNonQuery();
                if (result == 1)
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
