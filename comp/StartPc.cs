using GovDocSearch.cc.topware.serialize;
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GovDocSearch.cc.topware.form.comp
{
    public partial class StartPc : Form
    {
        private string FileName = "GovDocSearch";
        private string UrlName = Application.ExecutablePath;
        public StartPc()
        {            
            InitializeComponent();         
        }
        /// <summary>
        /// 是否设置开机启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_selfRun_CheckedChanged(object sender, EventArgs e)
        {

            //string FileName = Application.ProductName;          
            RegistryKey rk = Registry.CurrentUser;
            RegistryKey rgkRun = rk.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (checkBox_selfRun.Checked) //设置开机自启动  
            {
                if (rgkRun == null)
                {
                    rgkRun = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                }
                rgkRun.SetValue(FileName, UrlName);
                rk.Close();
            }
            else //取消开机自启动  
            {
                if (rgkRun == null)
                {
                    rgkRun = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                }
                rgkRun.DeleteValue(FileName, false);
                rk.Close();
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            this.Close();
        }

      /// <summary>
      /// 窗体移动
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void StartPc_MouseDown(object sender, MouseEventArgs e)
        {
            new FormMove().FormMove_MouseDown(this, e);
        }
        #region 任务栏窗口来回切换
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                cp.ExStyle |= 0x02000000;  //自定义控件闪烁问题
                return cp;
            }
        }
        #endregion

        private void StartPc_Shown(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser;
            RegistryKey rgkRun = rk.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (rgkRun != null)
            {
                try
                {
                    string name = rgkRun.GetValue(FileName).ToString();
                     checkBox_selfRun.Checked = true;
                }
                catch (Exception ex)
                {
                    checkBox_selfRun.Checked = false;
                }

            }
            rk.Close();
        }
    }
}
