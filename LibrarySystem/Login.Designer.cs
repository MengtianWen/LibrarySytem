namespace LibrarySystem
{
    partial class LogWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogWindow));
            this.lognamelabel = new System.Windows.Forms.Label();
            this.logwordlabel = new System.Windows.Forms.Label();
            this.txt_logname = new System.Windows.Forms.TextBox();
            this.txt_logword = new System.Windows.Forms.TextBox();
            this.Btn_register = new System.Windows.Forms.Button();
            this.Btn_log = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.rBtn_reader = new System.Windows.Forms.RadioButton();
            this.rBtn_admin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lognamelabel
            // 
            this.lognamelabel.AutoSize = true;
            this.lognamelabel.BackColor = System.Drawing.Color.Transparent;
            this.lognamelabel.ForeColor = System.Drawing.Color.White;
            this.lognamelabel.Location = new System.Drawing.Point(34, 48);
            this.lognamelabel.Name = "lognamelabel";
            this.lognamelabel.Size = new System.Drawing.Size(53, 12);
            this.lognamelabel.TabIndex = 0;
            this.lognamelabel.Text = "用户名：";
            // 
            // logwordlabel
            // 
            this.logwordlabel.AutoSize = true;
            this.logwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.logwordlabel.ForeColor = System.Drawing.Color.White;
            this.logwordlabel.Location = new System.Drawing.Point(34, 80);
            this.logwordlabel.Name = "logwordlabel";
            this.logwordlabel.Size = new System.Drawing.Size(53, 12);
            this.logwordlabel.TabIndex = 1;
            this.logwordlabel.Text = "密  码：";
            // 
            // txt_logname
            // 
            this.txt_logname.Location = new System.Drawing.Point(117, 45);
            this.txt_logname.Name = "txt_logname";
            this.txt_logname.Size = new System.Drawing.Size(100, 21);
            this.txt_logname.TabIndex = 2;
            // 
            // txt_logword
            // 
            this.txt_logword.Location = new System.Drawing.Point(117, 75);
            this.txt_logword.Name = "txt_logword";
            this.txt_logword.PasswordChar = '*';
            this.txt_logword.Size = new System.Drawing.Size(100, 21);
            this.txt_logword.TabIndex = 3;
            // 
            // Btn_register
            // 
            this.Btn_register.Location = new System.Drawing.Point(36, 242);
            this.Btn_register.Name = "Btn_register";
            this.Btn_register.Size = new System.Drawing.Size(75, 23);
            this.Btn_register.TabIndex = 4;
            this.Btn_register.Text = "注册";
            this.Btn_register.UseVisualStyleBackColor = true;
            this.Btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // Btn_log
            // 
            this.Btn_log.Location = new System.Drawing.Point(36, 173);
            this.Btn_log.Name = "Btn_log";
            this.Btn_log.Size = new System.Drawing.Size(181, 43);
            this.Btn_log.TabIndex = 5;
            this.Btn_log.Text = "登陆";
            this.Btn_log.UseVisualStyleBackColor = true;
            this.Btn_log.Click += new System.EventHandler(this.Btn_log_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Location = new System.Drawing.Point(142, 242);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_exit.TabIndex = 6;
            this.Btn_exit.Text = "退出";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // rBtn_reader
            // 
            this.rBtn_reader.AutoSize = true;
            this.rBtn_reader.BackColor = System.Drawing.Color.Transparent;
            this.rBtn_reader.ForeColor = System.Drawing.Color.White;
            this.rBtn_reader.Location = new System.Drawing.Point(54, 129);
            this.rBtn_reader.Name = "rBtn_reader";
            this.rBtn_reader.Size = new System.Drawing.Size(47, 16);
            this.rBtn_reader.TabIndex = 7;
            this.rBtn_reader.TabStop = true;
            this.rBtn_reader.Text = "读者";
            this.rBtn_reader.UseVisualStyleBackColor = false;
            // 
            // rBtn_admin
            // 
            this.rBtn_admin.AutoSize = true;
            this.rBtn_admin.BackColor = System.Drawing.Color.Transparent;
            this.rBtn_admin.ForeColor = System.Drawing.Color.White;
            this.rBtn_admin.Location = new System.Drawing.Point(142, 129);
            this.rBtn_admin.Name = "rBtn_admin";
            this.rBtn_admin.Size = new System.Drawing.Size(59, 16);
            this.rBtn_admin.TabIndex = 8;
            this.rBtn_admin.TabStop = true;
            this.rBtn_admin.Text = "管理员";
            this.rBtn_admin.UseVisualStyleBackColor = false;
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 326);
            this.Controls.Add(this.rBtn_admin);
            this.Controls.Add(this.rBtn_reader);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_log);
            this.Controls.Add(this.Btn_register);
            this.Controls.Add(this.txt_logword);
            this.Controls.Add(this.txt_logname);
            this.Controls.Add(this.logwordlabel);
            this.Controls.Add(this.lognamelabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogWindow";
            this.Text = "图书管理系统-登陆";
            this.Load += new System.EventHandler(this.LogWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lognamelabel;
        private System.Windows.Forms.Label logwordlabel;
        private System.Windows.Forms.TextBox txt_logname;
        private System.Windows.Forms.TextBox txt_logword;
        private System.Windows.Forms.Button Btn_register;
        private System.Windows.Forms.Button Btn_log;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.RadioButton rBtn_reader;
        private System.Windows.Forms.RadioButton rBtn_admin;

    }
}

