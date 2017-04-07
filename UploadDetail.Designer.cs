using GovDocSearch.cc.topware.baseLib.comp.PaneExs;

namespace GovDocSearch.cc.topware.form
{
    partial class UploadDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadDetail));
            this.uploadList = new System.Windows.Forms.TabControl();
            this.uploading = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uploadingItemContainer = new GovDocSearch.cc.topware.baseLib.comp.PaneExs.FlowLayoutPanelEx();
            this.allPauseBtn = new System.Windows.Forms.Button();
            this.allDeleteBtn = new System.Windows.Forms.Button();
            this.uploading_FileCountLabel = new System.Windows.Forms.Label();
            this.uploaded = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.allClearBtn = new System.Windows.Forms.Button();
            this.uploaded_FileCountLabel = new System.Windows.Forms.Label();
            this.uploadedItemContainer = new GovDocSearch.cc.topware.baseLib.comp.PaneExs.FlowLayoutPanelEx();
            this.titlepanel = new System.Windows.Forms.Panel();
            this.titlelabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uploadList.SuspendLayout();
            this.uploading.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.uploaded.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadList
            // 
            this.uploadList.Controls.Add(this.uploading);
            this.uploadList.Controls.Add(this.uploaded);
            this.uploadList.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uploadList.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uploadList.ItemSize = new System.Drawing.Size(414, 60);
            this.uploadList.Location = new System.Drawing.Point(-6, 62);
            this.uploadList.Name = "uploadList";
            this.uploadList.SelectedIndex = 0;
            this.uploadList.Size = new System.Drawing.Size(831, 508);
            this.uploadList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uploadList.TabIndex = 0;
            this.uploadList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.uploadList_DrawItem);
            // 
            // uploading
            // 
            this.uploading.Controls.Add(this.flowLayoutPanel1);
            this.uploading.Controls.Add(this.uploadingItemContainer);
            this.uploading.Controls.Add(this.allPauseBtn);
            this.uploading.Controls.Add(this.allDeleteBtn);
            this.uploading.Controls.Add(this.uploading_FileCountLabel);
            this.uploading.Location = new System.Drawing.Point(4, 64);
            this.uploading.Name = "uploading";
            this.uploading.Padding = new System.Windows.Forms.Padding(3);
            this.uploading.Size = new System.Drawing.Size(823, 440);
            this.uploading.TabIndex = 0;
            this.uploading.Text = "正在上传";
            this.uploading.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(817, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.MinimumSize = new System.Drawing.Size(290, 37);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(290, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "文档";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(299, 0);
            this.label2.MinimumSize = new System.Drawing.Size(240, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "进度";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(545, 0);
            this.label3.MinimumSize = new System.Drawing.Size(140, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "状态";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(691, 0);
            this.label4.MinimumSize = new System.Drawing.Size(100, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "操作";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uploadingItemContainer
            // 
            this.uploadingItemContainer.AutoScroll = true;
            this.uploadingItemContainer.BackColor = System.Drawing.Color.White;
            this.uploadingItemContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uploadingItemContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uploadingItemContainer.Location = new System.Drawing.Point(3, 85);
            this.uploadingItemContainer.Name = "uploadingItemContainer";
            this.uploadingItemContainer.Size = new System.Drawing.Size(817, 352);
            this.uploadingItemContainer.TabIndex = 11;
            this.uploadingItemContainer.TabStop = true;
            this.uploadingItemContainer.WrapContents = false;
            // 
            // allPauseBtn
            // 
            this.allPauseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.allPauseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allPauseBtn.FlatAppearance.BorderSize = 0;
            this.allPauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allPauseBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allPauseBtn.ForeColor = System.Drawing.Color.White;
            this.allPauseBtn.Location = new System.Drawing.Point(547, 6);
            this.allPauseBtn.MaximumSize = new System.Drawing.Size(98, 33);
            this.allPauseBtn.MinimumSize = new System.Drawing.Size(98, 33);
            this.allPauseBtn.Name = "allPauseBtn";
            this.allPauseBtn.Size = new System.Drawing.Size(98, 33);
            this.allPauseBtn.TabIndex = 3;
            this.allPauseBtn.Text = "全部暂停";
            this.allPauseBtn.UseVisualStyleBackColor = false;
            this.allPauseBtn.Click += new System.EventHandler(this.allPauseBtn_Click);
            // 
            // allDeleteBtn
            // 
            this.allDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.allDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allDeleteBtn.FlatAppearance.BorderSize = 0;
            this.allDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allDeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.allDeleteBtn.Location = new System.Drawing.Point(658, 6);
            this.allDeleteBtn.MaximumSize = new System.Drawing.Size(123, 33);
            this.allDeleteBtn.MinimumSize = new System.Drawing.Size(123, 33);
            this.allDeleteBtn.Name = "allDeleteBtn";
            this.allDeleteBtn.Size = new System.Drawing.Size(123, 33);
            this.allDeleteBtn.TabIndex = 2;
            this.allDeleteBtn.Text = "删除所有任务";
            this.allDeleteBtn.UseVisualStyleBackColor = false;
            this.allDeleteBtn.Click += new System.EventHandler(this.allDeleteBtn_Click);
            // 
            // uploading_FileCountLabel
            // 
            this.uploading_FileCountLabel.AutoSize = true;
            this.uploading_FileCountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uploading_FileCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.uploading_FileCountLabel.Location = new System.Drawing.Point(39, 12);
            this.uploading_FileCountLabel.Name = "uploading_FileCountLabel";
            this.uploading_FileCountLabel.Size = new System.Drawing.Size(123, 20);
            this.uploading_FileCountLabel.TabIndex = 1;
            this.uploading_FileCountLabel.Text = "正在上传0个文件";
            // 
            // uploaded
            // 
            this.uploaded.Controls.Add(this.flowLayoutPanel2);
            this.uploaded.Controls.Add(this.allClearBtn);
            this.uploaded.Controls.Add(this.uploaded_FileCountLabel);
            this.uploaded.Controls.Add(this.uploadedItemContainer);
            this.uploaded.Location = new System.Drawing.Point(4, 64);
            this.uploaded.Name = "uploaded";
            this.uploaded.Padding = new System.Windows.Forms.Padding(3);
            this.uploaded.Size = new System.Drawing.Size(823, 440);
            this.uploaded.TabIndex = 0;
            this.uploaded.Text = "上传成功";
            this.uploaded.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(817, 40);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.MinimumSize = new System.Drawing.Size(290, 37);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(290, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "文档";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(299, 0);
            this.label7.MinimumSize = new System.Drawing.Size(240, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "完成时间";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(545, 0);
            this.label8.MinimumSize = new System.Drawing.Size(140, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "上传路径";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(691, 0);
            this.label9.MinimumSize = new System.Drawing.Size(100, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 37);
            this.label9.TabIndex = 3;
            this.label9.Text = "操作";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allClearBtn
            // 
            this.allClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.allClearBtn.FlatAppearance.BorderSize = 0;
            this.allClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allClearBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.allClearBtn.ForeColor = System.Drawing.Color.White;
            this.allClearBtn.Location = new System.Drawing.Point(658, 6);
            this.allClearBtn.MaximumSize = new System.Drawing.Size(123, 33);
            this.allClearBtn.MinimumSize = new System.Drawing.Size(123, 33);
            this.allClearBtn.Name = "allClearBtn";
            this.allClearBtn.Size = new System.Drawing.Size(123, 33);
            this.allClearBtn.TabIndex = 5;
            this.allClearBtn.Text = "清除所有记录";
            this.allClearBtn.UseVisualStyleBackColor = false;
            this.allClearBtn.Click += new System.EventHandler(this.allClearBtn_Click);
            // 
            // uploaded_FileCountLabel
            // 
            this.uploaded_FileCountLabel.AutoSize = true;
            this.uploaded_FileCountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uploaded_FileCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.uploaded_FileCountLabel.Location = new System.Drawing.Point(39, 12);
            this.uploaded_FileCountLabel.Name = "uploaded_FileCountLabel";
            this.uploaded_FileCountLabel.Size = new System.Drawing.Size(123, 20);
            this.uploaded_FileCountLabel.TabIndex = 4;
            this.uploaded_FileCountLabel.Text = "上传成功0个文件";
            // 
            // uploadedItemContainer
            // 
            this.uploadedItemContainer.AutoScroll = true;
            this.uploadedItemContainer.BackColor = System.Drawing.Color.White;
            this.uploadedItemContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uploadedItemContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uploadedItemContainer.Location = new System.Drawing.Point(3, 85);
            this.uploadedItemContainer.Name = "uploadedItemContainer";
            this.uploadedItemContainer.Size = new System.Drawing.Size(817, 352);
            this.uploadedItemContainer.TabIndex = 13;
            this.uploadedItemContainer.TabStop = true;
            this.uploadedItemContainer.WrapContents = false;
            // 
            // titlepanel
            // 
            this.titlepanel.BackgroundImage = global::GovDocSearch.Properties.Resources.顶层蓝;
            this.titlepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titlepanel.Controls.Add(this.titlelabel);
            this.titlepanel.Controls.Add(this.button3);
            this.titlepanel.Controls.Add(this.button2);
            this.titlepanel.Controls.Add(this.button1);
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlepanel.Location = new System.Drawing.Point(0, 0);
            this.titlepanel.Name = "titlepanel";
            this.titlepanel.Size = new System.Drawing.Size(817, 62);
            this.titlepanel.TabIndex = 1;
            this.titlepanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.titlepanel_ControlAdded);
            this.titlepanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.titlepanel_ControlRemoved);
            this.titlepanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlepanel_MouseDown);
            this.titlepanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titlepanel_MouseMove);
            this.titlepanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titlepanel_MouseUp);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.BackColor = System.Drawing.Color.Transparent;
            this.titlelabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titlelabel.Location = new System.Drawing.Point(0, 0);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(180, 28);
            this.titlelabel.TabIndex = 3;
            this.titlelabel.Text = "电子政务搜索引擎";
            this.titlelabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlepanel_MouseDown);
            this.titlelabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Titlepanel_MouseMove);
            this.titlelabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Titlepanel_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::GovDocSearch.Properties.Resources.缩小图标;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(739, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 21);
            this.button3.TabIndex = 2;
            this.button3.Tag = "min";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Titlebutton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::GovDocSearch.Properties.Resources.放大图标;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(766, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 21);
            this.button2.TabIndex = 1;
            this.button2.Tag = "max";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Titlebutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GovDocSearch.Properties.Resources.关闭按钮;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(793, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 0;
            this.button1.Tag = "close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Titlebutton_Click);
            // 
            // UploadDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 561);
            this.ControlBox = false;
            this.Controls.Add(this.titlepanel);
            this.Controls.Add(this.uploadList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.uploadList.ResumeLayout(false);
            this.uploading.ResumeLayout(false);
            this.uploading.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.uploaded.ResumeLayout(false);
            this.uploaded.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl uploadList;
        private System.Windows.Forms.TabPage uploading;
        private System.Windows.Forms.Button allPauseBtn;
        private System.Windows.Forms.Button allDeleteBtn;
        private FlowLayoutPanelEx uploadingItemContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel titlepanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label titlelabel;
        public System.Windows.Forms.Label uploading_FileCountLabel;
        private System.Windows.Forms.TabPage uploaded;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button allClearBtn;
        private System.Windows.Forms.Label uploaded_FileCountLabel;
        private FlowLayoutPanelEx uploadedItemContainer;
    }
}