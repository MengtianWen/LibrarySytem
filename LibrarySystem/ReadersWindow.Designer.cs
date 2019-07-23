namespace LibrarySystem
{
    partial class ReadersWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadersWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_query = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_return = new System.Windows.Forms.ToolStripMenuItem();
            this.信息服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_basicInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_brRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_updateInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.注销身份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书服务ToolStripMenuItem,
            this.信息服务ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出登录ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书服务ToolStripMenuItem
            // 
            this.图书服务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_query,
            this.menu_return});
            this.图书服务ToolStripMenuItem.Name = "图书服务ToolStripMenuItem";
            this.图书服务ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图书服务ToolStripMenuItem.Text = "图书服务";
            // 
            // menu_query
            // 
            this.menu_query.Name = "menu_query";
            this.menu_query.Size = new System.Drawing.Size(152, 22);
            this.menu_query.Text = "查询/借阅";
            this.menu_query.Click += new System.EventHandler(this.menu_query_Click);
            // 
            // menu_return
            // 
            this.menu_return.Name = "menu_return";
            this.menu_return.Size = new System.Drawing.Size(152, 22);
            this.menu_return.Text = "归还/续借";
            this.menu_return.Click += new System.EventHandler(this.归还图书ToolStripMenuItem_Click);
            // 
            // 信息服务ToolStripMenuItem
            // 
            this.信息服务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_basicInfo,
            this.menu_brRecords,
            this.menu_updateInfo,
            this.注销身份ToolStripMenuItem});
            this.信息服务ToolStripMenuItem.Name = "信息服务ToolStripMenuItem";
            this.信息服务ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.信息服务ToolStripMenuItem.Text = "信息服务";
            // 
            // menu_basicInfo
            // 
            this.menu_basicInfo.Name = "menu_basicInfo";
            this.menu_basicInfo.Size = new System.Drawing.Size(152, 22);
            this.menu_basicInfo.Text = "基础信息";
            this.menu_basicInfo.Click += new System.EventHandler(this.menu_basicInfo_Click);
            // 
            // menu_brRecords
            // 
            this.menu_brRecords.Name = "menu_brRecords";
            this.menu_brRecords.Size = new System.Drawing.Size(152, 22);
            this.menu_brRecords.Text = "借阅记录";
            this.menu_brRecords.Click += new System.EventHandler(this.menu_brRecords_Click);
            // 
            // menu_updateInfo
            // 
            this.menu_updateInfo.Name = "menu_updateInfo";
            this.menu_updateInfo.Size = new System.Drawing.Size(152, 22);
            this.menu_updateInfo.Text = "修改信息";
            this.menu_updateInfo.Click += new System.EventHandler(this.menu_updateInfo_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem1
            // 
            this.退出登录ToolStripMenuItem1.Name = "退出登录ToolStripMenuItem1";
            this.退出登录ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.退出登录ToolStripMenuItem1.Text = "退出登录";
            this.退出登录ToolStripMenuItem1.Click += new System.EventHandler(this.退出登录ToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "当前登录身份";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel2.Text = "读者";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 334);
            this.panel1.TabIndex = 2;
            // 
            // 注销身份ToolStripMenuItem
            // 
            this.注销身份ToolStripMenuItem.Name = "注销身份ToolStripMenuItem";
            this.注销身份ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.注销身份ToolStripMenuItem.Text = "注销身份";
            this.注销身份ToolStripMenuItem.Click += new System.EventHandler(this.注销身份ToolStripMenuItem_Click);
            // 
            // ReadersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadersWindow";
            this.Text = "图书管理系统-读者主界面";
            this.Load += new System.EventHandler(this.ReadersWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_query;
        private System.Windows.Forms.ToolStripMenuItem menu_return;
        private System.Windows.Forms.ToolStripMenuItem 信息服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_basicInfo;
        private System.Windows.Forms.ToolStripMenuItem menu_brRecords;
        private System.Windows.Forms.ToolStripMenuItem menu_updateInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 注销身份ToolStripMenuItem;
    }
}