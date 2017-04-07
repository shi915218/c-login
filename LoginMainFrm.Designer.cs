namespace GovDocSearch.cc.topware.form
{
    partial class LoginMainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMainFrm));
            this.timer_ValiCode = new System.Windows.Forms.Timer(this.components);
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_GererLogin = new System.Windows.Forms.Button();
            this.btn_PhoneValiLogin = new System.Windows.Forms.Button();
            this.btn_FirstLogin = new System.Windows.Forms.Button();
            this.btn_ForgetPwd = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel_ValiCode = new System.Windows.Forms.Panel();
            this.panel_CheckCode = new GovDocSearch.cc.topware.form.comp.MyPanel();
            this.txt_ValiCode = new System.Windows.Forms.TextBox();
            this.btn_AcquireValiCode = new System.Windows.Forms.Button();
            this.btn_DyLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OrdinaryLogin = new System.Windows.Forms.Button();
            this.btn_PhoneIco = new System.Windows.Forms.Button();
            this.AutoLogin = new System.Windows.Forms.CheckBox();
            this.RememberPassword = new System.Windows.Forms.CheckBox();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.panel_Phone = new GovDocSearch.cc.topware.form.comp.MyPanel();
            this.txt_Phone = new GovDocSearch.cc.topware.form.MyComboBox();
            this.panel_Pwd = new GovDocSearch.cc.topware.form.comp.MyPanel();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.panel_ValiCode.SuspendLayout();
            this.panel_CheckCode.SuspendLayout();
            this.panel_Login.SuspendLayout();
            this.panel_Phone.SuspendLayout();
            this.panel_Pwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_ValiCode
            // 
            this.timer_ValiCode.Interval = 1000;
            this.timer_ValiCode.Tick += new System.EventHandler(this.timer_ValiCode_Tick);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(195)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(195)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Login.Location = new System.Drawing.Point(50, 231);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(400, 40);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
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
            this.btn_Close.Location = new System.Drawing.Point(464, 20);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_GererLogin
            // 
            this.btn_GererLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_GererLogin.FlatAppearance.BorderSize = 0;
            this.btn_GererLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_GererLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_GererLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GererLogin.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btn_GererLogin.ForeColor = System.Drawing.Color.Black;
            this.btn_GererLogin.Location = new System.Drawing.Point(40, 50);
            this.btn_GererLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_GererLogin.Name = "btn_GererLogin";
            this.btn_GererLogin.Size = new System.Drawing.Size(62, 34);
            this.btn_GererLogin.TabIndex = 5;
            this.btn_GererLogin.Text = "登录";
            this.btn_GererLogin.UseVisualStyleBackColor = false;
            // 
            // btn_PhoneValiLogin
            // 
            this.btn_PhoneValiLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_PhoneValiLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PhoneValiLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btn_PhoneValiLogin.FlatAppearance.BorderSize = 0;
            this.btn_PhoneValiLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PhoneValiLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PhoneValiLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhoneValiLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_PhoneValiLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_PhoneValiLogin.Location = new System.Drawing.Point(325, 55);
            this.btn_PhoneValiLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PhoneValiLogin.Name = "btn_PhoneValiLogin";
            this.btn_PhoneValiLogin.Size = new System.Drawing.Size(130, 28);
            this.btn_PhoneValiLogin.TabIndex = 6;
            this.btn_PhoneValiLogin.Text = "手机验证登录";
            this.btn_PhoneValiLogin.UseVisualStyleBackColor = true;
            this.btn_PhoneValiLogin.Click += new System.EventHandler(this.btn_PhoneValiLogin_Click);
            // 
            // btn_FirstLogin
            // 
            this.btn_FirstLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FirstLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btn_FirstLogin.FlatAppearance.BorderSize = 0;
            this.btn_FirstLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_FirstLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_FirstLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FirstLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_FirstLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(152)))), ((int)(((byte)(205)))));
            this.btn_FirstLogin.Location = new System.Drawing.Point(302, 197);
            this.btn_FirstLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_FirstLogin.Name = "btn_FirstLogin";
            this.btn_FirstLogin.Size = new System.Drawing.Size(82, 25);
            this.btn_FirstLogin.TabIndex = 11;
            this.btn_FirstLogin.Text = "首次登录";
            this.btn_FirstLogin.UseVisualStyleBackColor = true;
            this.btn_FirstLogin.Click += new System.EventHandler(this.btn_FirstLogin_Click);
            // 
            // btn_ForgetPwd
            // 
            this.btn_ForgetPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ForgetPwd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btn_ForgetPwd.FlatAppearance.BorderSize = 0;
            this.btn_ForgetPwd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ForgetPwd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ForgetPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ForgetPwd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ForgetPwd.ForeColor = System.Drawing.Color.Black;
            this.btn_ForgetPwd.Location = new System.Drawing.Point(385, 197);
            this.btn_ForgetPwd.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ForgetPwd.Name = "btn_ForgetPwd";
            this.btn_ForgetPwd.Size = new System.Drawing.Size(81, 25);
            this.btn_ForgetPwd.TabIndex = 12;
            this.btn_ForgetPwd.Text = "忘记密码";
            this.btn_ForgetPwd.UseVisualStyleBackColor = true;
            this.btn_ForgetPwd.Click += new System.EventHandler(this.btn_ForgrtPwd_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(118, 282);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 19);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "《用户协议》";
            // 
            // panel_ValiCode
            // 
            this.panel_ValiCode.BackColor = System.Drawing.Color.Transparent;
            this.panel_ValiCode.Controls.Add(this.panel_CheckCode);
            this.panel_ValiCode.Controls.Add(this.btn_AcquireValiCode);
            this.panel_ValiCode.Location = new System.Drawing.Point(50, 16);
            this.panel_ValiCode.Name = "panel_ValiCode";
            this.panel_ValiCode.Size = new System.Drawing.Size(400, 40);
            this.panel_ValiCode.TabIndex = 17;
            this.panel_ValiCode.Visible = false;
            // 
            // panel_CheckCode
            // 
            this.panel_CheckCode.BackColor = System.Drawing.Color.White;
            this.panel_CheckCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel_CheckCode.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.panel_CheckCode.Controls.Add(this.txt_ValiCode);
            this.panel_CheckCode.Location = new System.Drawing.Point(0, 0);
            this.panel_CheckCode.Name = "panel_CheckCode";
            this.panel_CheckCode.Size = new System.Drawing.Size(191, 40);
            this.panel_CheckCode.TabIndex = 29;
            // 
            // txt_ValiCode
            // 
            this.txt_ValiCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ValiCode.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.txt_ValiCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txt_ValiCode.Location = new System.Drawing.Point(6, 9);
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
            this.btn_AcquireValiCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(195)))));
            this.btn_AcquireValiCode.FlatAppearance.BorderSize = 0;
            this.btn_AcquireValiCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AcquireValiCode.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btn_AcquireValiCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AcquireValiCode.Location = new System.Drawing.Point(210, 1);
            this.btn_AcquireValiCode.Name = "btn_AcquireValiCode";
            this.btn_AcquireValiCode.Size = new System.Drawing.Size(190, 40);
            this.btn_AcquireValiCode.TabIndex = 17;
            this.btn_AcquireValiCode.Text = "获取验证码";
            this.btn_AcquireValiCode.UseVisualStyleBackColor = true;
            this.btn_AcquireValiCode.Click += new System.EventHandler(this.btn_AcquireValiCode_Click);
            // 
            // btn_DyLogin
            // 
            this.btn_DyLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(195)))));
            this.btn_DyLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DyLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(123)))), ((int)(((byte)(195)))));
            this.btn_DyLogin.FlatAppearance.BorderSize = 0;
            this.btn_DyLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DyLogin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.btn_DyLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DyLogin.Location = new System.Drawing.Point(50, 231);
            this.btn_DyLogin.Name = "btn_DyLogin";
            this.btn_DyLogin.Size = new System.Drawing.Size(400, 40);
            this.btn_DyLogin.TabIndex = 18;
            this.btn_DyLogin.Text = "登录";
            this.btn_DyLogin.UseVisualStyleBackColor = true;
            this.btn_DyLogin.Visible = false;
            this.btn_DyLogin.Click += new System.EventHandler(this.btn_DyLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(384, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 16);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(46, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "阅读并接受";
            // 
            // btn_OrdinaryLogin
            // 
            this.btn_OrdinaryLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_OrdinaryLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OrdinaryLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btn_OrdinaryLogin.FlatAppearance.BorderSize = 0;
            this.btn_OrdinaryLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_OrdinaryLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_OrdinaryLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrdinaryLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OrdinaryLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_OrdinaryLogin.Location = new System.Drawing.Point(366, 55);
            this.btn_OrdinaryLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_OrdinaryLogin.Name = "btn_OrdinaryLogin";
            this.btn_OrdinaryLogin.Size = new System.Drawing.Size(78, 28);
            this.btn_OrdinaryLogin.TabIndex = 20;
            this.btn_OrdinaryLogin.Text = "普通登录";
            this.btn_OrdinaryLogin.UseVisualStyleBackColor = true;
            this.btn_OrdinaryLogin.Visible = false;
            this.btn_OrdinaryLogin.Click += new System.EventHandler(this.btn_OrdinaryLogin_Click);
            // 
            // btn_PhoneIco
            // 
            this.btn_PhoneIco.BackgroundImage = global::GovDocSearch.Properties.Resources.手机;
            this.btn_PhoneIco.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_PhoneIco.FlatAppearance.BorderSize = 0;
            this.btn_PhoneIco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PhoneIco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhoneIco.Location = new System.Drawing.Point(438, 62);
            this.btn_PhoneIco.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PhoneIco.Name = "btn_PhoneIco";
            this.btn_PhoneIco.Size = new System.Drawing.Size(14, 14);
            this.btn_PhoneIco.TabIndex = 21;
            this.btn_PhoneIco.UseVisualStyleBackColor = true;
            // 
            // AutoLogin
            // 
            this.AutoLogin.AutoSize = true;
            this.AutoLogin.Checked = true;
            this.AutoLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoLogin.FlatAppearance.BorderSize = 0;
            this.AutoLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AutoLogin.Location = new System.Drawing.Point(143, 199);
            this.AutoLogin.Margin = new System.Windows.Forms.Padding(0);
            this.AutoLogin.Name = "AutoLogin";
            this.AutoLogin.Size = new System.Drawing.Size(80, 23);
            this.AutoLogin.TabIndex = 22;
            this.AutoLogin.Text = "自动登录";
            this.AutoLogin.UseVisualStyleBackColor = true;
            // 
            // RememberPassword
            // 
            this.RememberPassword.AutoSize = true;
            this.RememberPassword.Checked = true;
            this.RememberPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RememberPassword.FlatAppearance.BorderSize = 0;
            this.RememberPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RememberPassword.Location = new System.Drawing.Point(50, 199);
            this.RememberPassword.Margin = new System.Windows.Forms.Padding(0);
            this.RememberPassword.Name = "RememberPassword";
            this.RememberPassword.Size = new System.Drawing.Size(80, 23);
            this.RememberPassword.TabIndex = 23;
            this.RememberPassword.Text = "记住密码";
            this.RememberPassword.UseVisualStyleBackColor = true;
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.panel_Login.Controls.Add(this.panel_Phone);
            this.panel_Login.Controls.Add(this.panel_Pwd);
            this.panel_Login.Controls.Add(this.RememberPassword);
            this.panel_Login.Controls.Add(this.AutoLogin);
            this.panel_Login.Controls.Add(this.btn_PhoneIco);
            this.panel_Login.Controls.Add(this.btn_OrdinaryLogin);
            this.panel_Login.Controls.Add(this.label2);
            this.panel_Login.Controls.Add(this.button1);
            this.panel_Login.Controls.Add(this.btn_DyLogin);
            this.panel_Login.Controls.Add(this.panel_ValiCode);
            this.panel_Login.Controls.Add(this.linkLabel1);
            this.panel_Login.Controls.Add(this.btn_ForgetPwd);
            this.panel_Login.Controls.Add(this.btn_FirstLogin);
            this.panel_Login.Controls.Add(this.btn_PhoneValiLogin);
            this.panel_Login.Controls.Add(this.btn_GererLogin);
            this.panel_Login.Controls.Add(this.btn_Close);
            this.panel_Login.Controls.Add(this.btn_Login);
            this.panel_Login.Location = new System.Drawing.Point(0, 0);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(500, 349);
            this.panel_Login.TabIndex = 0;
            this.panel_Login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Login_MouseDown);
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
            this.panel_Phone.TabIndex = 27;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BorderColor = System.Drawing.Color.White;
            this.txt_Phone.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.txt_Phone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txt_Phone.FormattingEnabled = true;
            this.txt_Phone.ItemHeight = 20;
            this.txt_Phone.Location = new System.Drawing.Point(5, 6);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(393, 28);
            this.txt_Phone.TabIndex = 23;
            this.txt_Phone.Text = "请输入手机号码";
            this.txt_Phone.SelectedValueChanged += new System.EventHandler(this.txt_Phone_SelectedValueChanged);
            this.txt_Phone.TextChanged += new System.EventHandler(this.txt_Phone_TextChanged);
            this.txt_Phone.Click += new System.EventHandler(this.txt_Phone_Click);
            this.txt_Phone.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // panel_Pwd
            // 
            this.panel_Pwd.BackColor = System.Drawing.Color.White;
            this.panel_Pwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel_Pwd.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.panel_Pwd.Controls.Add(this.txt_Pwd);
            this.panel_Pwd.Location = new System.Drawing.Point(50, 150);
            this.panel_Pwd.Name = "panel_Pwd";
            this.panel_Pwd.Size = new System.Drawing.Size(400, 40);
            this.panel_Pwd.TabIndex = 25;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pwd.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.txt_Pwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txt_Pwd.Location = new System.Drawing.Point(7, 10);
            this.txt_Pwd.Multiline = true;
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(388, 27);
            this.txt_Pwd.TabIndex = 1;
            this.txt_Pwd.Text = "密码";
            this.txt_Pwd.Click += new System.EventHandler(this.TextBox_Click);
            this.txt_Pwd.TextChanged += new System.EventHandler(this.txt_Pwd_TextChanged);
            this.txt_Pwd.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // LoginMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(500, 349);
            this.Controls.Add(this.panel_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginMainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电子政务搜索";
            this.Load += new System.EventHandler(this.LoginMainFrm_Load);
            this.Shown += new System.EventHandler(this.LoginMainFrm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginMainFrm_KeyDown);
            this.panel_ValiCode.ResumeLayout(false);
            this.panel_CheckCode.ResumeLayout(false);
            this.panel_CheckCode.PerformLayout();
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.panel_Phone.ResumeLayout(false);
            this.panel_Pwd.ResumeLayout(false);
            this.panel_Pwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_ValiCode;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_GererLogin;
        private System.Windows.Forms.Button btn_PhoneValiLogin;
        private System.Windows.Forms.Button btn_FirstLogin;
        private System.Windows.Forms.Button btn_ForgetPwd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel_ValiCode;
        private comp.MyPanel panel_CheckCode;
        private System.Windows.Forms.TextBox txt_ValiCode;
        private System.Windows.Forms.Button btn_AcquireValiCode;
        private System.Windows.Forms.Button btn_DyLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OrdinaryLogin;
        private System.Windows.Forms.Button btn_PhoneIco;
        private System.Windows.Forms.CheckBox AutoLogin;
        private System.Windows.Forms.CheckBox RememberPassword;
        private comp.MyPanel panel_Pwd;
        private System.Windows.Forms.TextBox txt_Pwd;
        private comp.MyPanel panel_Phone;
        private MyComboBox txt_Phone;
        private System.Windows.Forms.Panel panel_Login;
    }
}