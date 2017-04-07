namespace GovDocSearch.cc.topware.form
{
    partial class FloatWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloatWin));
            this.floatWin_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fwcms_myPage = new System.Windows.Forms.ToolStripMenuItem();
            this.fwcms_openUploadList = new System.Windows.Forms.ToolStripMenuItem();
            this.fwcms_pauseAllTask = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fwcms_hide = new System.Windows.Forms.ToolStripMenuItem();
            this.fwcms_set = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fwcms_changeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.fwcms_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.floatWin_ni = new System.Windows.Forms.NotifyIcon(this.components);
            this.floatWin_ni_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fw_ni_myPage = new System.Windows.Forms.ToolStripMenuItem();
            this.fw_ni_openUploadList = new System.Windows.Forms.ToolStripMenuItem();
            this.fw_ni_pauseAllTask = new System.Windows.Forms.ToolStripMenuItem();
            this.fw_ni_ShowFloatWin = new System.Windows.Forms.ToolStripMenuItem();
            this.fw_ni_set = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fw_ni_changeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.fw_ni_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.floatWin_cms.SuspendLayout();
            this.floatWin_ni_cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // floatWin_cms
            // 
            this.floatWin_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fwcms_myPage,
            this.fwcms_openUploadList,
            this.fwcms_pauseAllTask,
            this.toolStripSeparator1,
            this.fwcms_hide,
            this.fwcms_set,
            this.toolStripSeparator3,
            this.fwcms_changeUser,
            this.fwcms_exit});
            this.floatWin_cms.Name = "floatWin_cms";
            this.floatWin_cms.Size = new System.Drawing.Size(149, 170);
            // 
            // fwcms_myPage
            // 
            this.fwcms_myPage.Image = ((System.Drawing.Image)(resources.GetObject("fwcms_myPage.Image")));
            this.fwcms_myPage.Name = "fwcms_myPage";
            this.fwcms_myPage.Size = new System.Drawing.Size(148, 22);
            this.fwcms_myPage.Text = "我的主页";
            this.fwcms_myPage.Click += new System.EventHandler(this.fwcms_myPage_Click);
            // 
            // fwcms_openUploadList
            // 
            this.fwcms_openUploadList.Name = "fwcms_openUploadList";
            this.fwcms_openUploadList.Size = new System.Drawing.Size(148, 22);
            this.fwcms_openUploadList.Text = "查看上传列表";
            this.fwcms_openUploadList.Click += new System.EventHandler(this.fwcms_openUploadList_Click);
            // 
            // fwcms_pauseAllTask
            // 
            this.fwcms_pauseAllTask.Image = global::GovDocSearch.Properties.Resources.暂停;
            this.fwcms_pauseAllTask.Name = "fwcms_pauseAllTask";
            this.fwcms_pauseAllTask.Size = new System.Drawing.Size(148, 22);
            this.fwcms_pauseAllTask.Text = "暂停所有任务";
            this.fwcms_pauseAllTask.Click += new System.EventHandler(this.fwcms_pauseAllTask_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // fwcms_hide
            // 
            this.fwcms_hide.Name = "fwcms_hide";
            this.fwcms_hide.Size = new System.Drawing.Size(148, 22);
            this.fwcms_hide.Text = "隐藏悬浮窗";
            this.fwcms_hide.Click += new System.EventHandler(this.fwcms_hide_Click);
            // 
            // fwcms_set
            // 
            this.fwcms_set.Image = ((System.Drawing.Image)(resources.GetObject("fwcms_set.Image")));
            this.fwcms_set.Name = "fwcms_set";
            this.fwcms_set.Size = new System.Drawing.Size(148, 22);
            this.fwcms_set.Text = "设置";
            this.fwcms_set.Click += new System.EventHandler(this.fwcms_set_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // fwcms_changeUser
            // 
            this.fwcms_changeUser.Image = global::GovDocSearch.Properties.Resources.切换;
            this.fwcms_changeUser.Name = "fwcms_changeUser";
            this.fwcms_changeUser.Size = new System.Drawing.Size(148, 22);
            this.fwcms_changeUser.Text = "切换帐户";
            this.fwcms_changeUser.Click += new System.EventHandler(this.fwcms_changeUser_Click);
            // 
            // fwcms_exit
            // 
            this.fwcms_exit.Image = global::GovDocSearch.Properties.Resources.退出;
            this.fwcms_exit.Name = "fwcms_exit";
            this.fwcms_exit.Size = new System.Drawing.Size(148, 22);
            this.fwcms_exit.Text = "退出";
            this.fwcms_exit.Click += new System.EventHandler(this.fwcms_exit_Click);
            // 
            // floatWin_ni
            // 
            this.floatWin_ni.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.floatWin_ni.BalloonTipText = "名称：测试";
            this.floatWin_ni.ContextMenuStrip = this.floatWin_ni_cms;
            this.floatWin_ni.Icon = ((System.Drawing.Icon)(resources.GetObject("floatWin_ni.Icon")));
            this.floatWin_ni.Text = "电子政务搜索引擎";
            this.floatWin_ni.Visible = true;
            this.floatWin_ni.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.floatWin_ni_MouseDoubleClick);
            // 
            // floatWin_ni_cms
            // 
            this.floatWin_ni_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fw_ni_myPage,
            this.fw_ni_openUploadList,
            this.fw_ni_pauseAllTask,
            this.fw_ni_ShowFloatWin,
            this.fw_ni_set,
            this.toolStripSeparator2,
            this.fw_ni_changeUser,
            this.fw_ni_exit});
            this.floatWin_ni_cms.Name = "floatWin_ni_cms";
            this.floatWin_ni_cms.Size = new System.Drawing.Size(149, 164);
            // 
            // fw_ni_myPage
            // 
            this.fw_ni_myPage.Image = global::GovDocSearch.Properties.Resources.我的首页;
            this.fw_ni_myPage.Name = "fw_ni_myPage";
            this.fw_ni_myPage.Size = new System.Drawing.Size(152, 22);
            this.fw_ni_myPage.Text = "我的主页";
            this.fw_ni_myPage.Click += new System.EventHandler(this.fwcms_myPage_Click);
            // 
            // fw_ni_openUploadList
            // 
            this.fw_ni_openUploadList.Name = "fw_ni_openUploadList";
            this.fw_ni_openUploadList.Size = new System.Drawing.Size(152, 22);
            this.fw_ni_openUploadList.Text = "查看上传列表";
            this.fw_ni_openUploadList.Click += new System.EventHandler(this.fwcms_openUploadList_Click);
            // 
            // fw_ni_pauseAllTask
            // 
            this.fw_ni_pauseAllTask.Image = global::GovDocSearch.Properties.Resources.暂停;
            this.fw_ni_pauseAllTask.Name = "fw_ni_pauseAllTask";
            this.fw_ni_pauseAllTask.Size = new System.Drawing.Size(152, 22);
            this.fw_ni_pauseAllTask.Text = "暂停所有任务";
            this.fw_ni_pauseAllTask.Click += new System.EventHandler(this.fwcms_pauseAllTask_Click);
            // 
            // fw_ni_ShowFloatWin
            // 
            this.fw_ni_ShowFloatWin.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fw_ni_ShowFloatWin.Name = "fw_ni_ShowFloatWin";
            this.fw_ni_ShowFloatWin.Size = new System.Drawing.Size(152, 22);
            this.fw_ni_ShowFloatWin.Text = "显示悬浮窗";
            this.fw_ni_ShowFloatWin.Click += new System.EventHandler(this.fw_ni_ShowFloatWin_Click);
            // 
            // fw_ni_set
            // 
            this.fw_ni_set.Image = global::GovDocSearch.Properties.Resources.设置;
            this.fw_ni_set.Name = "fw_ni_set";
            this.fw_ni_set.Size = new System.Drawing.Size(152, 22);
            this.fw_ni_set.Text = "设置";
            this.fw_ni_set.Click += new System.EventHandler(this.fwcms_set_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // fw_ni_changeUser
            // 
            this.fw_ni_changeUser.Image = global::GovDocSearch.Properties.Resources.切换;
            this.fw_ni_changeUser.Name = "fw_ni_changeUser";
            this.fw_ni_changeUser.Size = new System.Drawing.Size(152, 22);
            this.fw_ni_changeUser.Text = "切换账户";
            this.fw_ni_changeUser.Click += new System.EventHandler(this.fwcms_changeUser_Click);
            // 
            // fw_ni_exit
            // 
            this.fw_ni_exit.Image = global::GovDocSearch.Properties.Resources.退出;
            this.fw_ni_exit.Name = "fw_ni_exit";
            this.fw_ni_exit.Size = new System.Drawing.Size(152, 22);
            this.fw_ni_exit.Text = "退出";
            this.fw_ni_exit.Click += new System.EventHandler(this.fwcms_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GovDocSearch.Properties.Resources.蜜蜂0002;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.FloatWin_DragEnter);
            this.pictureBox1.DragLeave += new System.EventHandler(this.FloatWin_DragLeave);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.floatWin_doubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FloatWin_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.FloatWin_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.FloatWin_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FloatWin_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FloatWin_MouseUp);
            // 
            // FloatWin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GovDocSearch.Properties.Resources.右下角悬浮窗口logo21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(240, 112);
            this.ContextMenuStrip = this.floatWin_cms;
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(160, 112);
            this.Name = "FloatWin";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FloatWin_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FloatWin_DragEnter);
            this.DragLeave += new System.EventHandler(this.FloatWin_DragLeave);
            this.DoubleClick += new System.EventHandler(this.floatWin_doubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FloatWin_MouseDown);
            this.MouseEnter += new System.EventHandler(this.FloatWin_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FloatWin_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FloatWin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FloatWin_MouseUp);
            this.floatWin_cms.ResumeLayout(false);
            this.floatWin_ni_cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip floatWin_cms;
        private System.Windows.Forms.ToolStripMenuItem fwcms_hide;
        private System.Windows.Forms.ToolStripMenuItem fwcms_exit;
        private System.Windows.Forms.ToolStripMenuItem fwcms_myPage;
        private System.Windows.Forms.ToolStripMenuItem fwcms_openUploadList;
        private System.Windows.Forms.ToolStripMenuItem fwcms_pauseAllTask;
        private System.Windows.Forms.ToolStripMenuItem fwcms_changeUser;
        private System.Windows.Forms.NotifyIcon floatWin_ni;
        private System.Windows.Forms.ContextMenuStrip floatWin_ni_cms;
        private System.Windows.Forms.ToolStripMenuItem fw_ni_myPage;
        private System.Windows.Forms.ToolStripMenuItem fw_ni_openUploadList;
        private System.Windows.Forms.ToolStripMenuItem fw_ni_pauseAllTask;
        private System.Windows.Forms.ToolStripMenuItem fw_ni_exit;
        private System.Windows.Forms.ToolStripMenuItem fwcms_set;
        private System.Windows.Forms.ToolStripMenuItem fw_ni_set;
        private System.Windows.Forms.ToolStripMenuItem fw_ni_changeUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fw_ni_ShowFloatWin;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

