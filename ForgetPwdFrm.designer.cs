namespace GovDocSearch.cc.topware.form
{
    partial class ForgetPwdFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPwdFrm));
            this.panel_FirstLogin = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel_SetPwd = new GovDocSearch.cc.topware.form.comp.MyPanel();
            this.txt_ReSetPwd = new System.Windows.Forms.TextBox();
            this.panel_SurePwd = new GovDocSearch.cc.topware.form.comp.MyPanel();
            this.txt_SurePwd = new System.Windows.Forms.TextBox();
            this.panel_Phone = new GovDocSearch.cc.topware.form.comp.MyPanel();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.panel_Protocol = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ForgetPwd = new System.Windows.Forms.Button();
            this.btn_GoLogin = new System.Windows.Forms.Button();
            this.panel_ValiCode = new System.Windows.Forms.Panel();
            this.panel_CheckCode = new GovDocSearch.cc.topware.form.comp.MyPanel();
            this.txt_ValiCode = new System.Windows.Forms.TextBox();
            this.btn_AcquireValiCode = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.timer_ValiCode = new System.Windows.Forms.Timer(this.components);
            this.panel_FirstLogin.SuspendLayout();
            this.panel_SetPwd.SuspendLayout();
            this.panel_SurePwd.SuspendLayout();
            this.panel_Phone.SuspendLayout();
            this.panel_Protocol.SuspendLayout();
            this.panel_ValiCode.SuspendLayout();
            this.panel_CheckCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_FirstLogin
            // 
            this.panel_FirstLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.panel_FirstLogin.Controls.Add(this.btn_Back);
            this.panel_FirstLogin.Controls.Add(this.panel_SetPwd);
            this.panel_FirstLogin.Controls.Add(this.panel_SurePwd);
            this.panel_FirstLogin.Controls.Add(this.panel_Phone);
            this.panel_FirstLogin.Controls.Add(this.panel_Protocol);
            this.panel_FirstLogin.Controls.Add(this.btn_ForgetPwd);
            this.panel_FirstLogin.Controls.Add(this.btn_GoLogin);
            this.panel_FirstLogin.Controls.Add(this.panel_ValiCode);
            this.panel_FirstLogin.Controls.Add(this.btn_Close);
            this.panel_FirstLogin.Location = new System.Drawing.Point(0, 0);
            this.panel_FirstLogin.Name = "panel_FirstLogin";
            this.panel_FirstLogin.Size = new System.Drawing.Size(500, 400);
            this.panel_FirstLogin.TabIndex = 1;
            this.panel_FirstLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_ForgetPwdFrm_MouseMove);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btn_Back.Location = new System.Drawing.Point(384, 54);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 36);
            this.btn_Back.TabIndex = 32;
            this.btn_Back.Text = "返回";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel_SetPwd
            // 
            this.panel_SetPwd.BackColor = System.Drawing.Color.White;
            this.panel_SetPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel_SetPwd.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.panel_SetPwd.Controls.Add(this.txt_ReSetPwd);
            this.panel_SetPwd.Location = new System.Drawing.Point(50, 202);
            this.panel_SetPwd.Name = "panel_SetPwd";
            this.panel_SetPwd.Size = new System.Drawing.Size(400, 40);
            this.panel_SetPwd.TabIndex = 31;
            // 
            // txt_ReSetPwd
            // 
            this.txt_ReSetPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ReSetPwd.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.txt_ReSetPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txt_ReSetPwd.Location = new System.Drawing.Point(9, 10);
            this.txt_ReSetPwd.Multiline = true;
            this.txt_ReSetPwd.Name = "txt_ReSetPwd";
            this.txt_ReSetPwd.Size = new System.Drawing.Size(382, 27);
            this.txt_ReSetPwd.TabIndex = 4;
            this.txt_ReSetPwd.Text = "重置密码";
            this.txt_ReSetPwd.Click += new System.EventHandler(this.TextBox_Click);
            this.txt_ReSetPwd.TextChanged += new System.EventHandler(this.txt_Pwd_TextChanged);
            this.txt_ReSetPwd.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panel_SurePwd
            // 
            this.panel_SurePwd.BackColor = System.Drawing.Color.White;
            this.panel_SurePwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel_SurePwd.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.panel_SurePwd.Controls.Add(this.txt_SurePwd);
            this.panel_SurePwd.Location = new System.Drawing.Point(50, 255);
            this.panel_SurePwd.Name = "panel_SurePwd";
            this.panel_SurePwd.Size = new System.Drawing.Size(400, 40);
            this.panel_SurePwd.TabIndex = 30;
            // 
            // txt_SurePwd
            // 
            this.txt_SurePwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SurePwd.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.txt_SurePwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txt_SurePwd.Location = new System.Drawing.Point(8, 9);
            this.txt_SurePwd.Multiline = true;
            this.txt_SurePwd.Name = "txt_SurePwd";
            this.txt_SurePwd.Size = new System.Drawing.Size(382, 28);
            this.txt_SurePwd.TabIndex = 5;
            this.txt_SurePwd.Text = "确认密码";
            this.txt_SurePwd.Click += new System.EventHandler(this.TextBox_Click);
            this.txt_SurePwd.TextChanged += new System.EventHandler(this.txt_Pwd_TextChanged);
            this.txt_SurePwd.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panel_Phone
            // 
            this.panel_Phone.BackColor = System.Drawing.Color.White;
            this.panel_Phone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel_Phone.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.panel_Phone.Controls.Add(this.txt_Phone);
            this.panel_Phone.Location = new System.Drawing.Point(50, 96);
            this.panel_Phone.Name = "panel_Phone";
            this.panel_Phone.Size = new System.Drawing.Size(400, 40);
            this.panel_Phone.TabIndex = 29;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txt_Phone.Location = new System.Drawing.Point(8, 9);
            this.txt_Phone.Multiline = true;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(382, 27);
            this.txt_Phone.TabIndex = 7;
            this.txt_Phone.Text = "请输入手机号码";
            this.txt_Phone.Click += new System.EventHandler(this.TextBox_Click);
            this.txt_Phone.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panel_Protocol
            // 
            this.panel_Protocol.Controls.Add(this.linkLabel1);
            this.panel_Protocol.Controls.Add(this.label1);
            this.panel_Protocol.Location = new System.Drawing.Point(34, 359);
            this.panel_Protocol.Name = "panel_Protocol";
            this.panel_Protocol.Size = new System.Drawing.Size(0, 0);
            this.panel_Protocol.TabIndex = 25;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(97, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 15);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "《用户协议》";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "阅读并接受";
            // 
            // btn_ForgetPwd
            // 
            this.btn_ForgetPwd.FlatAppearance.BorderSize = 0;
            this.btn_ForgetPwd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ForgetPwd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ForgetPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ForgetPwd.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btn_ForgetPwd.ForeColor = System.Drawing.Color.Black;
            this.btn_ForgetPwd.Location = new System.Drawing.Point(35, 50);
            this.btn_ForgetPwd.Name = "btn_ForgetPwd";
            this.btn_ForgetPwd.Size = new System.Drawing.Size(110, 33);
            this.btn_ForgetPwd.TabIndex = 22;
            this.btn_ForgetPwd.Text = "忘记密码";
            this.btn_ForgetPwd.UseVisualStyleBackColor = true;
            // 
            // btn_GoLogin
            // 
            this.btn_GoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(195)))));
            this.btn_GoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_GoLogin.FlatAppearance.BorderSize = 0;
            this.btn_GoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoLogin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btn_GoLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GoLogin.Location = new System.Drawing.Point(50, 314);
            this.btn_GoLogin.Name = "btn_GoLogin";
            this.btn_GoLogin.Size = new System.Drawing.Size(400, 40);
            this.btn_GoLogin.TabIndex = 19;
            this.btn_GoLogin.Text = "登录";
            this.btn_GoLogin.UseVisualStyleBackColor = false;
            this.btn_GoLogin.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // panel_ValiCode
            // 
            this.panel_ValiCode.BackColor = System.Drawing.Color.Transparent;
            this.panel_ValiCode.Controls.Add(this.panel_CheckCode);
            this.panel_ValiCode.Controls.Add(this.btn_AcquireValiCode);
            this.panel_ValiCode.Location = new System.Drawing.Point(50, 149);
            this.panel_ValiCode.Name = "panel_ValiCode";
            this.panel_ValiCode.Size = new System.Drawing.Size(401, 40);
            this.panel_ValiCode.TabIndex = 18;
            // 
            // panel_CheckCode
            // 
            this.panel_CheckCode.BackColor = System.Drawing.Color.White;
            this.panel_CheckCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel_CheckCode.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.panel_CheckCode.Controls.Add(this.txt_ValiCode);
            this.panel_CheckCode.Location = new System.Drawing.Point(0, 0);
            this.panel_CheckCode.Name = "panel_CheckCode";
            this.panel_CheckCode.Size = new System.Drawing.Size(190, 40);
            this.panel_CheckCode.TabIndex = 32;
            // 
            // txt_ValiCode
            // 
            this.txt_ValiCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ValiCode.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.txt_ValiCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txt_ValiCode.Location = new System.Drawing.Point(8, 9);
            this.txt_ValiCode.Multiline = true;
            this.txt_ValiCode.Name = "txt_ValiCode";
            this.txt_ValiCode.Size = new System.Drawing.Size(176, 28);
            this.txt_ValiCode.TabIndex = 4;
            this.txt_ValiCode.Text = "验证码";
            this.txt_ValiCode.Click += new System.EventHandler(this.TextBox_Click);
            this.txt_ValiCode.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // btn_AcquireValiCode
            // 
            this.btn_AcquireValiCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(122)))), ((int)(((byte)(195)))));
            this.btn_AcquireValiCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AcquireValiCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AcquireValiCode.FlatAppearance.BorderSize = 0;
            this.btn_AcquireValiCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AcquireValiCode.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btn_AcquireValiCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AcquireValiCode.Location = new System.Drawing.Point(210, 1);
            this.btn_AcquireValiCode.Name = "btn_AcquireValiCode";
            this.btn_AcquireValiCode.Size = new System.Drawing.Size(190, 40);
            this.btn_AcquireValiCode.TabIndex = 17;
            this.btn_AcquireValiCode.Text = "获取验证码";
            this.btn_AcquireValiCode.UseVisualStyleBackColor = false;
            this.btn_AcquireValiCode.Click += new System.EventHandler(this.btn_AcquireValiCode_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::GovDocSearch.Properties.Resources.关闭;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(466, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // timer_ValiCode
            // 
            this.timer_ValiCode.Interval = 1000;
            this.timer_ValiCode.Tick += new System.EventHandler(this.timer_ValiCode_Tick);
            // 
            // ForgetPwdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panel_FirstLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgetPwdFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPwdFrm";
            this.panel_FirstLogin.ResumeLayout(false);
            this.panel_SetPwd.ResumeLayout(false);
            this.panel_SetPwd.PerformLayout();
            this.panel_SurePwd.ResumeLayout(false);
            this.panel_SurePwd.PerformLayout();
            this.panel_Phone.ResumeLayout(false);
            this.panel_Phone.PerformLayout();
            this.panel_Protocol.ResumeLayout(false);
            this.panel_Protocol.PerformLayout();
            this.panel_ValiCode.ResumeLayout(false);
            this.panel_CheckCode.ResumeLayout(false);
            this.panel_CheckCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Protocol;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ForgetPwd;
        private System.Windows.Forms.Button btn_GoLogin;
        private System.Windows.Forms.Panel panel_ValiCode;
        private System.Windows.Forms.Button btn_AcquireValiCode;
        private System.Windows.Forms.Button btn_Close;
        public System.Windows.Forms.Panel panel_FirstLogin;
        private comp.MyPanel panel_Phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private comp.MyPanel panel_CheckCode;
        private System.Windows.Forms.TextBox txt_ValiCode;
        private comp.MyPanel panel_SetPwd;
        public System.Windows.Forms.TextBox txt_ReSetPwd;
        private comp.MyPanel panel_SurePwd;
        public System.Windows.Forms.TextBox txt_SurePwd;
        private System.Windows.Forms.Timer timer_ValiCode;
        private System.Windows.Forms.Button btn_Back;
    }
}