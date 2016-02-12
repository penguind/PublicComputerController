namespace IfMyComputer
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.promptlabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.passwdTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.promptpanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.windowsNnotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.loglistpanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.loglistpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.promptpanel);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 64);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.promptlabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(734, 19);
            this.panel5.TabIndex = 5;
            // 
            // promptlabel
            // 
            this.promptlabel.AutoSize = true;
            this.promptlabel.ForeColor = System.Drawing.Color.White;
            this.promptlabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.promptlabel.Location = new System.Drawing.Point(366, 0);
            this.promptlabel.Name = "promptlabel";
            this.promptlabel.Size = new System.Drawing.Size(233, 12);
            this.promptlabel.TabIndex = 3;
            this.promptlabel.Text = "2015.11.12 12:23 我想回家 从控制台登录";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.passwdTextbox);
            this.panel4.Controls.Add(this.usernameTextbox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(734, 34);
            this.panel4.TabIndex = 4;
            // 
            // passwdTextbox
            // 
            this.passwdTextbox.Location = new System.Drawing.Point(584, 3);
            this.passwdTextbox.Name = "passwdTextbox";
            this.passwdTextbox.PasswordChar = '*';
            this.passwdTextbox.Size = new System.Drawing.Size(144, 21);
            this.passwdTextbox.TabIndex = 1;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(368, 3);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(144, 21);
            this.usernameTextbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(534, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密  码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(318, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // promptpanel
            // 
            this.promptpanel.Location = new System.Drawing.Point(376, 2);
            this.promptpanel.Name = "promptpanel";
            this.promptpanel.Size = new System.Drawing.Size(354, 22);
            this.promptpanel.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginButton.Location = new System.Drawing.Point(734, 0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(66, 64);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "登 录";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // windowsNnotifyIcon
            // 
            this.windowsNnotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("windowsNnotifyIcon.Icon")));
            this.windowsNnotifyIcon.Text = "用户使用中,单击锁定";
            this.windowsNnotifyIcon.Visible = true;
            this.windowsNnotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.windowsNnotifyIcon_MouseClick);
            // 
            // loglistpanel
            // 
            this.loglistpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loglistpanel.BackColor = System.Drawing.Color.Transparent;
            this.loglistpanel.Controls.Add(this.textBox1);
            this.loglistpanel.Location = new System.Drawing.Point(12, 412);
            this.loglistpanel.Name = "loglistpanel";
            this.loglistpanel.Size = new System.Drawing.Size(363, 118);
            this.loglistpanel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 115);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.loglistpanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.loglistpanel.ResumeLayout(false);
            this.loglistpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.NotifyIcon windowsNnotifyIcon;
        private System.Windows.Forms.Panel loglistpanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox passwdTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label promptlabel;
        private System.Windows.Forms.Panel promptpanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}

