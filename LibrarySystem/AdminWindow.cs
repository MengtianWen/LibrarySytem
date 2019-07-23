using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        //加载窗口！
        private void AdminWindow_Load(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            toollabel.Text = LogWindow.logname;
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }


        //用于查询图书和图书入库，图书删除
        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //读者管理
        private void 读者管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 图书服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_booksQuery bookQuery = new A_booksQuery();
            bookQuery.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(bookQuery);//把form里的内容添到panel中
            bookQuery.Show();//显示内容
        }

        //归还图书

        private void 归还图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_returnBook bookreturn = new A_returnBook();
            bookreturn.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(bookreturn);//把form里的内容添到panel中
            bookreturn.Show();//显示内容

        }

        private void 读者服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_readermanage readermanage = new A_readermanage();
            readermanage.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(readermanage);//把form里的内容添到panel中
            readermanage.Show();//显示内容
        }

        private void 罚款ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_FineReader finereader = new A_FineReader();
            finereader.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(finereader);//把form里的内容添到panel中
            finereader.Show();//显示内容
        }

        //查询借阅记录
        private void 借阅记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_RecordBorrow recordWin = new A_RecordBorrow();
            recordWin.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(recordWin);//把form里的内容添到panel中
            recordWin.Show();//显示内容
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_helpInfo helpInfoWin = new A_helpInfo();
            helpInfoWin.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(helpInfoWin);//把form里的内容添到panel中
            helpInfoWin.Show();//显示内容
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_updateInfo updateInfoWin = new A_updateInfo();
            updateInfoWin.TopLevel = false; //重要的一个步骤
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(updateInfoWin);//把form里的内容添到panel中
            updateInfoWin.Show();//显示内容
        }
    }
}
