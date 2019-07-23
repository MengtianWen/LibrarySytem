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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            comboBox_gender.Items.Add("男");
            comboBox_gender.Items.Add("女");
            comboBox_type.Items.Add("学生");
            comboBox_type.Items.Add("教职工");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string uid = txt_ID.Text.ToString();
            string uname = txt_name.Text.ToString();
            string pwd = txt_pwd.Text.ToString();
            string age = txt_age.Text.ToString();
            string address = txt_address.Text.ToString();
            string unit = txt_unit.Text.ToString();

            string gender = comboBox_gender.SelectedItem.ToString();
            string type = comboBox_type.SelectedItem.ToString();

            if(string.IsNullOrEmpty(uid)||string.IsNullOrEmpty(uname)||string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("请将必填项填写完整！");
            }
            else
            {
                SqlConnection conn = SQLbase.getConn();
                if(conn.State==ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                string insertStr = "insert into Readers values('" + uid + "','" + uname + "','" + gender + "','" + address + "'," + age + ",'" + unit + "','" + type + "','" + pwd + "'," + 0+")";
                SqlCommand insertCmd = new SqlCommand(insertStr,conn);
                //对于Update、Insert和Delete语句，返回值为该命令所影响的行数。
                //对于所有其他类型的语句，返回值为 - 1。
                try
                {
                    int RecordsAffected = insertCmd.ExecuteNonQuery();
                    if(RecordsAffected==1)
                    {
                        MessageBox.Show("注册成功！");
                    }
                    else
                    {
                        MessageBox.Show("注册失败！");
                    }
                }
                catch(SqlException)
                {
                    MessageBox.Show("  注册失败！\n 请重新注册！");
                }
                
                SQLbase.close(insertCmd);
                SQLbase.close(conn);
                this.Close();
            }

        }
    }
}
