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
    public partial class A_BooksAdd : Form
    {
        public A_BooksAdd()
        {
            InitializeComponent();
        }

        //确认图书入库
        private void button1_Click(object sender, EventArgs e)
        {
            //
            string id, name, author, publisher, type;
            id = textBox1.Text.ToString();
            name = textBox2.Text.ToString();
            author = textBox3.Text.ToString();
            publisher = textBox4.Text.ToString();
            type = textBox5.Text.ToString();
            
            //确认必填项
            if(string.IsNullOrEmpty(id)||string.IsNullOrEmpty(name))
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
                    string insertStr = "insert into Books values('" + id
                        + "','" + name + "','" + author + "','" + publisher
                        + "','" + type + "',1)";
                    SqlCommand insertCmd = new SqlCommand(insertStr, conn);
                    //对于Update、Insert和Delete语句，返回值为该命令所影响的行数。
                    //对于所有其他类型的语句，返回值为 - 1。

                    int RecordsAffected = insertCmd.ExecuteNonQuery();
                    if (RecordsAffected == 1)
                    {
                        MessageBox.Show("入库成功！重新查询即可查看");
                    }
                    else
                    {
                        MessageBox.Show("入库失败！");
                    }
                    SQLbase.close(insertCmd);
                }
                catch (SqlException)
                {
                    MessageBox.Show("  入库失败！\n 请重新填写信息！");
                }
                SQLbase.close(conn);
                this.Close();
            }
        
        }

        private void A_BooksAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
