namespace GovDocSearch.cc.topware.form.comp
{
    partial class TipFrm
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.label_content = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(168)))), ((int)(((byte)(251)))));
            this.panel_header.Controls.Add(this.btn_Close);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Controls.Add(this.button1);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(360, 40);
            this.panel_header.TabIndex = 0;
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel__MouseDown);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::GovDocSearch.Properties.Resources.错误_拷贝_2;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(330, 11);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "提示";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GovDocSearch.Properties.Resources.提示;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_sure
            // 
            this.btn_sure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(173)))), ((int)(((byte)(242)))));
            this.btn_sure.FlatAppearance.BorderSize = 0;
            this.btn_sure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sure.Location = new System.Drawing.Point(255, 114);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(87, 32);
            this.btn_sure.TabIndex = 1;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = false;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // label_content
            // 
            this.label_content.AutoSize = true;
            this.label_content.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label_content.Location = new System.Drawing.Point(91, 69);
            this.label_content.Name = "label_content";
            this.label_content.Size = new System.Drawing.Size(189, 20);
            this.label_content.TabIndex = 2;
            this.label_content.Text = "密码不正确，请重新输入！";
            // 
            // TipFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(360, 160);
            this.Controls.Add(this.label_content);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipFrm";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Label label_content;
    }
}