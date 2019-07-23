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
    public partial class A_ReadersAdd : Form
    {
        public A_ReadersAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, name, gender, address, age, unit, pwd,type;
            id = textBox1.Text.ToString();
            name = textBox2.Text.ToString();
            gender = textBox3.Text.ToString();
            address = textBox4.Text.ToString();
            age = textBox5.Text.ToString();
            unit = textBox6.Text.ToString();
            pwd = textBox7.Text.ToString();
            type = textBox8.Text.ToString();
            //确认必填项
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("请把必填项填写完整！");
            }
            else
            {
                SqlConnection conn = SQLbase.getConn();

                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    conn.Open();
                    string insertStr = "insert into Readers values('" + id
                        + "','" + name + "','" + gender + "','" + address
                        + "','" + age + "','" + unit +"','"+type+"','"+pwd+"',0)";
                    SqlCommand insertCmd = new SqlCommand(insertStr, conn);
                    //对于Update、Insert和Delete语句，返回值为该命令所影响的行数。
                    //对于所有其他类型的语句，返回值为 - 1。

                    int RecordsAffected = insertCmd.ExecuteNonQuery();
                    if (RecordsAffected == 1)
                    {
                        MessageBox.Show("添加成功！重新查询即可查看记录");
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                    SQLbase.close(insertCmd);
                }
                catch (SqlException)
                {
                    MessageBox.Show("  添加失败！\n 请重新填写信息！");
                }
                SQLbase.close(conn);
                this.Close();
            }
        }
    }
}
