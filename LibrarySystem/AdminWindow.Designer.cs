namespace LibrarySystem
{
    partial class AdminWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.归还图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.罚款ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toollabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.修改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理ToolStripMenuItem,
            this.读者管理ToolStripMenuItem,
            this.查询服务ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书服务ToolStripMenuItem,
            this.归还图书ToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            this.图书管理ToolStripMenuItem.Click += new System.EventHandler(this.图书管理ToolStripMenuItem_Click);
            // 
            // 图书服务ToolStripMenuItem
            // 
            this.图书服务ToolStripMenuItem.Name = "图书服务ToolStripMenuItem";
            this.图书服务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图书服务ToolStripMenuItem.Text = "图书服务";
            this.图书服务ToolStripMenuItem.Click += new System.EventHandler(this.图书服务ToolStripMenuItem_Click);
            // 
            // 归还图书ToolStripMenuItem
            // 
            this.归还图书ToolStripMenuItem.Name = "归还图书ToolStripMenuItem";
            this.归还图书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.归还图书ToolStripMenuItem.Text = "归还图书";
            this.归还图书ToolStripMenuItem.Click += new System.EventHandler(this.归还图书ToolStripMenuItem_Click);
            // 
            // 读者管理ToolStripMenuItem
            // 
            this.读者管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者服务ToolStripMenuItem,
            this.罚款ToolStripMenuItem});
            this.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            this.读者管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.读者管理ToolStripMenuItem.Text = "读者管理";
            this.读者管理ToolStripMenuItem.Click += new System.EventHandler(this.读者管理ToolStripMenuItem_Click);
            // 
            // 读者服务ToolStripMenuItem
            // 
            this.读者服务ToolStripMenuItem.Name = "读者服务ToolStripMenuItem";
            this.读者服务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.读者服务ToolStripMenuItem.Text = "读者服务";
            this.读者服务ToolStripMenuItem.Click += new System.EventHandler(this.读者服务ToolStripMenuItem_Click);
            // 
            // 罚款ToolStripMenuItem
            // 
            this.罚款ToolStripMenuItem.Name = "罚款ToolStripMenuItem";
            this.罚款ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.罚款ToolStripMenuItem.Text = "罚     款";
            this.罚款ToolStripMenuItem.Click += new System.EventHandler(this.罚款ToolStripMenuItem_Click);
            // 
            // 查询服务ToolStripMenuItem
            // 
            this.查询服务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借阅记录ToolStripMenuItem,
            this.修改信息ToolStripMenuItem});
            this.查询服务ToolStripMenuItem.Name = "查询服务ToolStripMenuItem";
            this.查询服务ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查询服务ToolStripMenuItem.Text = "查询服务";
            // 
            // 借阅记录ToolStripMenuItem
            // 
            this.借阅记录ToolStripMenuItem.Name = "借阅记录ToolStripMenuItem";
            this.借阅记录ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.借阅记录ToolStripMenuItem.Text = "借阅记录";
            this.借阅记录ToolStripMenuItem.Click += new System.EventHandler(this.借阅记录ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toollabel,
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
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel2.Text = "管理员";
            // 
            // toollabel
            // 
            this.toollabel.Name = "toollabel";
            this.toollabel.Size = new System.Drawing.Size(69, 17);
            this.toollabel.Text = "toolLabel3";
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
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 334);
            this.panel1.TabIndex = 2;
            // 
            // 修改信息ToolStripMenuItem
            // 
            this.修改信息ToolStripMenuItem.Name = "修改信息ToolStripMenuItem";
            this.修改信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改信息ToolStripMenuItem.Text = "修改信息";
            this.修改信息ToolStripMenuItem.Click += new System.EventHandler(this.修改信息ToolStripMenuItem_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminWindow";
            this.Text = "图书管理系统-管理员主界面";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询服务ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toollabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 图书服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 归还图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 罚款ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
    }
}