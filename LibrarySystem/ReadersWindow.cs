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
    public partial class ReadersWindow : Form
    {
        public ReadersWindow()
        {
            InitializeComponent();
        }
        //图书续借和归还响应事件
        private void 归还图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R_BooksReturn booksReturnWin = new R_BooksReturn();
            booksReturnWin.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(booksReturnWin);//把form里的内容添到panel中
            booksReturnWin.Show();//显示内容

        }

        //图书查询菜单的响应事件
        private void menu_query_Click(object sender, EventArgs e)
        {
            //新建一个不显示边框的窗体
            R_BooksQuery booksQueryWin = new R_BooksQuery();
            booksQueryWin.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(booksQueryWin);//把form里的内容添到panel中
            booksQueryWin.Show();//显示内容

        }
        //图书续借响应事件
        private void menu_borrow_Click(object sender, EventArgs e)
        {

        }

        //加载该窗口的响应事件
        private void ReadersWindow_Load(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            toolStripStatusLabel4.Text = LogWindow.logname;
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }


        //基础信息查询   查询读者表
        private void menu_basicInfo_Click(object sender, EventArgs e)
        {
            R_basicInfo InfoWin = new R_basicInfo();
            InfoWin.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(InfoWin);//把form里的内容添到panel中
            InfoWin.Show();//显示内容
        }


        //借阅记录查询！
        private void menu_brRecords_Click(object sender, EventArgs e)
        {
            R_historyRecord historyWin = new R_historyRecord();
            historyWin.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(historyWin);//把form里的内容添到panel中
            historyWin.Show();//显示内容
        }


        //修改信息窗口
        private void menu_updateInfo_Click(object sender, EventArgs e)
        {
            R_updateInfo updateInfoWin = new R_updateInfo();
            updateInfoWin.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(updateInfoWin);//把form里的内容添到panel中
            updateInfoWin.Show();//显示内容
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            this.Close();
        }

        private void 退出登录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R_HelpInfo helpInfoWin = new R_HelpInfo();
            helpInfoWin.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(helpInfoWin);//把form里的内容添到panel中
            helpInfoWin.Show();//显示内容
        }

        private void 注销身份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要注销读者身份吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //确认注销就删除掉读者表中的信息。
                string Rid = LogWindow.logname;
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
                        MessageBox.Show("注销成功！");
                        this.Close();
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
        }
    }
}
