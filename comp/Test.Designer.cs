namespace GovDocSearch.cc.topware.form.comp
{
    partial class Test
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
            this.myProgressBar2 = new GovDocSearch.cc.topware.form.comp.MyProgressBar();
            this.myProgressBar1 = new GovDocSearch.cc.topware.form.comp.MyProgressBar();
            this.SuspendLayout();
            // 
            // myProgressBar2
            // 
            this.myProgressBar2.BackColor = System.Drawing.Color.Red;
            this.myProgressBar2.Location = new System.Drawing.Point(56, 128);
            this.myProgressBar2.Name = "myProgressBar2";
            this.myProgressBar2.Size = new System.Drawing.Size(131, 22);
            this.myProgressBar2.TabIndex = 1;
            // 
            // myProgressBar1
            // 
            this.myProgressBar1.BackColor = System.Drawing.SystemColors.Highlight;
            this.myProgressBar1.Location = new System.Drawing.Point(56, 86);
            this.myProgressBar1.Name = "myProgressBar1";
            this.myProgressBar1.Size = new System.Drawing.Size(139, 23);
            this.myProgressBar1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.myProgressBar2);
            this.Controls.Add(this.myProgressBar1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private MyProgressBar myProgressBar1;
        private MyProgressBar myProgressBar2;
    }
}