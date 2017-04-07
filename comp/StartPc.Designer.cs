namespace GovDocSearch.cc.topware.form.comp
{
    partial class StartPc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPc));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.run_lab = new System.Windows.Forms.Label();
            this.checkBox_selfRun = new System.Windows.Forms.CheckBox();
            this.panel_set = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(121, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "传输提示：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(206, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "传输完成时提示";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // run_lab
            // 
            this.run_lab.AutoSize = true;
            this.run_lab.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.run_lab.Location = new System.Drawing.Point(121, 72);
            this.run_lab.Name = "run_lab";
            this.run_lab.Size = new System.Drawing.Size(84, 20);
            this.run_lab.TabIndex = 5;
            this.run_lab.Text = "开机启动：";
            // 
            // checkBox_selfRun
            // 
            this.checkBox_selfRun.AutoSize = true;
            this.checkBox_selfRun.Checked = true;
            this.checkBox_selfRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_selfRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_selfRun.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.checkBox_selfRun.Location = new System.Drawing.Point(207, 71);
            this.checkBox_selfRun.Name = "checkBox_selfRun";
            this.checkBox_selfRun.Size = new System.Drawing.Size(163, 24);
            this.checkBox_selfRun.TabIndex = 4;
            this.checkBox_selfRun.Text = "开机时启动政务搜索";
            this.checkBox_selfRun.UseVisualStyleBackColor = true;
            this.checkBox_selfRun.CheckedChanged += new System.EventHandler(this.checkBox_selfRun_CheckedChanged);
            // 
            // panel_set
            // 
            this.panel_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(215)))), ((int)(((byte)(237)))));
            this.panel_set.Controls.Add(this.btn_close);
            this.panel_set.Controls.Add(this.label2);
            this.panel_set.Location = new System.Drawing.Point(0, -1);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(487, 48);
            this.panel_set.TabIndex = 8;
            this.panel_set.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartPc_MouseDown);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_close.Location = new System.Drawing.Point(456, 17);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(16, 16);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "设置";
            // 
            // StartPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(487, 209);
            this.Controls.Add(this.panel_set);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.run_lab);
            this.Controls.Add(this.checkBox_selfRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartPc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartPc";
            this.Shown += new System.EventHandler(this.StartPc_Shown);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label run_lab;
        private System.Windows.Forms.CheckBox checkBox_selfRun;
        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
    }
}