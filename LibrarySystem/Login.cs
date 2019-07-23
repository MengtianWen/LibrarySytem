using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //与数据库有关

namespace LibrarySystem
{
    public partial class LogWindow : Form
    {
        public static string logname;
        //为SQL的连接添加一个成员变量
        public static SqlConnection conn = SQLbase.getConn();
        public SqlConnection conn1
        {
            get
            {
                return conn;
            }
            set
            {
                conn = SQLbase.getConn();
            }
        }
        public LogWindow()
        {
            InitializeComponent();
        }

        private void Btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                if(conn.State== ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
            }
            catch
            {
                MessageBox.Show("连接异常！");
            }
            //获取登陆界面的用户名和密码
            logname = txt_logname.Text.ToString();
            string logpassword = txt_logword.Text.ToString();
            //如果输入信息不全，则给予提示
            if(string.IsNullOrEmpty(logname)||string.IsNullOrEmpty(logpassword))
            {
                MessageBox.Show("请输入用户名和密码！");
            }
            else
            {
                //判断登陆类型
                //如果是读者登陆
                if (rBtn_reader.Checked == true)
                {
                    string selectStr = "select Rpassword from readers where RID=" + logname;
                    SqlCommand SelectCmd = new SqlCommand(selectStr, conn);
                    SqlDataReader datareader = SelectCmd.ExecuteReader();
                    if(datareader.Read())
                    {
                        string password = datareader["Rpassword"].ToString();
                        if(password ==logpassword )
                        {
                            MessageBox.Show("登陆成功！");
                            ReadersWindow readersWin = new ReadersWindow();
                            readersWin.Show(this);
                        }
                        else
                        {
                            MessageBox.Show("密码错误！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该用户不存在！请重新输入");
                    }
                }
                //如果是管理员登陆
                else if (rBtn_admin.Checked == true)
                {
                    string selectStr = "select Apassword from administrators where AID=" + logname;
                    SqlCommand SelectCmd = new SqlCommand(selectStr, conn);
                    SqlDataReader datareader = SelectCmd.ExecuteReader();
                    if (datareader.Read())
                    {
                        string password = datareader["Apassword"].ToString();
                        if (password == logpassword)
                        {
                            MessageBox.Show("登陆成功！");
                            AdminWindow adminWin = new AdminWindow();
                            adminWin.Show(this);
                        }
                        else
                        {
                            MessageBox.Show("密码错误！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该用户不存在！请重新输入");
                    }
                }
                else
                {
                    MessageBox.Show("请选择用户类型！");
                }
            }            

        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            SQLbase.close(conn);
            Application.Exit();
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show(this);
        }

        private void LogWindow_Load(object sender, EventArgs e)
        {
            txt_logname.Clear();
            txt_logword.Clear();
        }
    }
}
