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
    public partial class FormMove : Form
    {
        public FormMove()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 移动窗体
        /// </summary>
        /// <returns></returns>      
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public void FormMove_MouseDown(object sender, MouseEventArgs e)
        {
            Form f = (Form)sender;
            ReleaseCapture();
            SendMessage(f.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
