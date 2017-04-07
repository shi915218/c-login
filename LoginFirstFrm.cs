using GovDocSearch.cc.topware.form.comp;
using GovDocSearch.cc.topware.serialize;
using GovDocSearch.cc.topware.service;
using GovDocSearch.cc.topware.util;
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

namespace GovDocSearch.cc.topware.form
{
    public partial class LoginFirstFrm : Form
    {
        public LoginFirstFrm()
        {
            InitializeComponent();                     
        }
        LoginMainFrm lMF = new LoginMainFrm();
        #region 首次登录事件
        /// <summary>
        /// 首次登录方法
        /// </summary>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            User user = new User();
            btn_AcquireValiCode.Text = "获取验证码";
            btn_AcquireValiCode.BackColor = Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(122)))), ((int)(((byte)(195)))));
            string tel = txt_Phone.Text.ToString().Trim();
            string checkCode = txt_ValiCode.Text.ToString().Trim();
            string password = txt_SetPwd.Text.ToString().Trim();
            string confirmPassword = txt_SurePwd.Text.ToString().Trim();
            //MessageBox.Show(tel+ checkCode+password + confirmPassword);
            string par = "mobile=" + tel + "&checkCode=" + checkCode + "&password=" + password + "&confirmPassword=" + confirmPassword;
            String data = CommonService.remote("web/login/first.do", par);
            Result objs = JsonHelper.Json2Object<Result>(data);
            // MessageBox.Show(objs.isSuccess);
            user.Tel = tel;
            user.Password = password;
            if (objs.isSuccess == "True")
            {
                new FloatWin(this, user).Show();
                this.Hide();
            }
            else
            {
                TipFrm tipFrm = new TipFrm(objs.description);
                DialogResult result = tipFrm.ShowDialog();
                //Messagebox.Show(objs.description, "提示", Messagebox.MyButtons.OK, Messagebox.MyIcon.Information);
            }
        }
        #endregion

        #region 获取验证码相关事件及方法
        /// <summary>
        /// 获取验证码事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AcquireValiCode_Click(object sender, EventArgs e)
        {
            string tel = txt_Phone.Text.ToString().Trim();
            Button btn = (Button)sender;
            if (tel == "" || tel == "请输入手机号码" || tel.Length != 11)
            {
                new TipFrm("请输入正确的手机号码").ShowDialog();
            }
            else if (btn.Text == "获取验证码")             
            {               
                string par = "mobile=" + tel;
                String data = CommonService.remote("web/login/sendcheckcode.do", par, "login");
                Result objs = JsonHelper.Json2Object<Result>(data);
                if (objs.isSuccess == "False")
                {
                    TipFrm tipFrm = new TipFrm("短信发送失败！");
                    DialogResult result = tipFrm.ShowDialog();
                }
                else if (objs.isSuccess == "True")
                {
                    btn_AcquireValiCode.BackColor = Color.DarkGray;
                    btn_AcquireValiCode.Text = "60S";
                    timer_ValiCode.Enabled = true;
                    TipFrm tipFrm = new TipFrm("短信已发送！");
                    DialogResult result = tipFrm.ShowDialog();

                }

                //Messagebox.Show(objs.description, "提示", Messagebox.MyButtons.OK, Messagebox.MyIcon.Information);
            }          
        }
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_ValiCode_Tick(object sender, EventArgs e)
        {
            try
            {
                if (btn_AcquireValiCode.Text == "0S")
                {
                    btn_AcquireValiCode.Text = "获取验证码";
                    btn_AcquireValiCode.BackColor = Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(122)))), ((int)(((byte)(195)))));
                }
                else
                {
                    string str = btn_AcquireValiCode.Text.ToString().Trim();
                    str = str.Substring(0, str.Length - 1);
                    int i = Convert.ToInt32(str);
                    btn_AcquireValiCode.Text = (i - 1) + "S";
                }
            }
            catch
            {

            }
        }
        #endregion

        #region 鼠标点击和离开的相关事件

        //  鼠标点击textbox,text清空值       
        private void TextBox_Click(object sender, EventArgs e)
        {
            lMF.TextBox_Click(sender, e);
        }

        /// <summary>
        ///  鼠标离开textbox,text恢复默认值
        /// </summary>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txt_Phone.Text == "")
            {
                txtBox.Text = "请输入手机号码";
                txtBox.ForeColor = Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            }
            if (txt_SurePwd.Text == "")
            {
                txtBox.Text = "确认密码";
                txtBox.ForeColor = Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            }
            if (txt_ValiCode.Text == "")
            {
                txtBox.Text = "验证码";
                txtBox.ForeColor = Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            }
            if (txt_SetPwd.Text == "")
            {
                txtBox.Text = "设置密码为6-20个字符";
                txtBox.ForeColor = Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            }

        }

        /// <summary>
        ///  将输入的密码转换成* 显示 
        /// </summary>
        private void txt_Pwd_TextChanged(object sender, EventArgs e)
        {
            lMF.txt_Pwd_TextChanged(sender, e);
        }
        #endregion



        /// <summary>
        ///   首次登录关闭按钮事件
        /// </summary>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

      
        ///// <summary>
        ///// 移动窗体
        ///// </summary>
        ///// <returns></returns>
      
        private void panel_FirstLogin_MouseMove(object sender, MouseEventArgs e)
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            lMF.Show();
            this.Close();
        }
    }
}
