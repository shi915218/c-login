using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovDocSearch.cc.topware.form.comp
{
    public partial class TipFrm : Form
    {
        public TipFrm(string content)
        {
            InitializeComponent();
            this.label_content.Text = content;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        /// <summary>
        /// 移动窗体
        /// </summary>
        /// <returns></returns>             
        private void panel__MouseDown(object sender, MouseEventArgs e)
        {
            new FormMove().FormMove_MouseDown(this, e);
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
