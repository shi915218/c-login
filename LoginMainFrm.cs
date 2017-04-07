using GovDocSearch.cc.topware.serialize;
using GovDocSearch.cc.topware.service;
using GovDocSearch.cc.topware.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using GovDocSearch.cc.topware.form.comp;
using System.Threading;

namespace GovDocSearch.cc.topware.form
{
    public partial class LoginMainFrm : Form
    {
        private User currentUser = null;
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private FloatWin fw = null;
        private int type = 0;// 0：默认用户启动；1：切换帐户；
        public LoginMainFrm(int type = 0)
        {         
            InitializeComponent();
            //TransparencyKey = BackColor; // 隐藏背景颜色        
            this.type = type;
        }

        #region 登录按钮事件
        private void btn_Login_Click(object sender, EventArgs e)
        {            
            string tel = this.txt_Phone.Text.Trim();
            string password = this.txt_Pwd.Text.Trim();
            //password = getMd5Hash(password);            
            currentUser = new User();
            currentUser.Tel = tel;
            currentUser.Password = password;          
            Login(currentUser);
        }

        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="user">User的一个实例化对象</param>
        private void Login(User user, int isAutoLogin = 0)
        {         
            Boolean isRemember = false;
            string para = "mobile=" + user.Tel + "&password=" + user.Password + "&isRemember=" + isRemember;
            string data = CommonService.remote("web/login/normal.do", para, "login");           
            Result objs = JsonHelper.Json2Object<Result>(data);
            //MessageBox.Show(data);               
            if (objs.isSuccess == "True")
            {               
                try
                {  //登录成功记住账号 appPath + "\\data.bin"   
                    //string appPath = System.Windows.Forms.Application.StartupPath;
                    FileStream fs = new FileStream(@"D:\data.bin", FileMode.OpenOrCreate);                
                    BinaryFormatter bf = new BinaryFormatter();
                    if (this.AutoLogin.Checked) //如果单击自动登录
                    {
                        user.IsAutoLogin = 1;
                    }
                    else
                    {
                        user.IsAutoLogin = 0;
                    }
                    if (this.RememberPassword.Checked)     //如果单击了记住密码的功能
                    {   //  在文件中保存密码
                        user.Password = user.Password;
                    }
                    else
                    {   //  不在文件中保存密码
                        user.Password = "";
                    }
                    //判断用户是否存在,不存在则把用户保存在集合users中
                    //if (!users.ContainsKey(user.Tel))
                    //{                    
                    //    users[user.Tel] = user;
                    //}
                    if (users.ContainsKey(user.Tel))
                    {
                        users.Remove(user.Tel);
                    }
                    //user.IsExist = 1;   //用户已经登录为1，未登录为0 
                    users.Add(user.Tel, user);
                    storeLastLoginInfo(user.Tel);
                    //要先将User类先设为可以序列化(即在类的前面加[Serializable])
                    bf.Serialize(fs, users);
                    fs.Close();                  
                    createFloatWin(isAutoLogin);
                }
                catch
                {

                }
            }
                  
            else
            {
                TipFrm tipFrm = new TipFrm(objs.description);
                DialogResult result = tipFrm.ShowDialog();
               //Messagebox.Show(objs.description, "提示", Messagebox.MyButtons.OK, Messagebox.MyIcon.Information);
            }                  
        }


        private void createFloatWin(int isAutoLogin = 0)
        {           
            if (fw == null || fw.IsDisposed || type == 1)
            {
                fw = null;
                fw = new FloatWin(this, currentUser, isAutoLogin);
            }
            this.Hide();
            fw.Show();
            fw.Activate();
        }

        /// <summary>
        /// 普通登录切换按钮
        /// </summary>
        private void btn_OrdinaryLogin_Click(object sender, EventArgs e)
        {
            btn_PhoneValiLogin.Show();
            btn_OrdinaryLogin.Hide();
            panel_Pwd.Show();
            panel_ValiCode.Hide();
            btn_DyLogin.Hide();
            btn_Login.Show();
            AutoLogin.Show();
            RememberPassword.Show();
        }
        #endregion

        #region 获取验证码相关事件及方法
        /// <summary>
        /// 获取验证码按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_AcquireValiCode_Click(object sender, EventArgs e)
        {
            string tel = txt_Phone.Text.ToString().Trim();
            if (tel == "" || tel == "请输入手机号码" || tel.Length != 11)
            {
                new TipFrm("请输入正确的手机号码").ShowDialog();
            }
            else if (btn_AcquireValiCode.Text == "获取验证码")
            {                        
                string par = "mobile=" + tel;
                String data = CommonService.remote("web/login/senddynamicpassword.do", par);
                Result objs = JsonHelper.Json2Object<Result>(data);
                
                if (objs.isSuccess == "False")
                {
                    TipFrm tipFrm = new TipFrm("短信发送失败！");
                    DialogResult result = tipFrm.ShowDialog();
                }
                else if(objs.isSuccess == "True")
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
        /// 获取验证码的时间戳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timer_ValiCode_Tick(object sender, EventArgs e)
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

        #region 手机动态密码登录
        /// <summary>
        /// 手机动态码登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_DyLogin_Click(object sender, EventArgs e)
        {
            btn_AcquireValiCode.Text = "获取验证码";
            btn_AcquireValiCode.BackColor = Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(122)))), ((int)(((byte)(195)))));
            string tel = txt_Phone.Text.ToString().Trim();
            Boolean isRemember = false;
            // MessageBox.Show(tel);
            string password = txt_ValiCode.Text.ToString().Trim();
            string para = "mobile=" + tel + "&dynamicPassword=" + password + "&isRemember=" + isRemember;
            string data = CommonService.remote("web/login/dynamic.do", para,"login");
            Result objs = JsonHelper.Json2Object<Result>(data);
            currentUser = new User();
            currentUser.Tel = tel;
            currentUser.Password = password;
            //MessageBox.Show(data);
            if (objs.isSuccess == "True")
            {
                FloatWin fw = new FloatWin(this, currentUser);
                fw.Show();
                this.Hide();
            }

            else
            {
                TipFrm tipFrm = new TipFrm(objs.description);
                DialogResult result = tipFrm.ShowDialog();
                //Messagebox.Show(objs.description, "提示", Messagebox.MyButtons.OK, Messagebox.MyIcon.Information);
            }
        }

        /// <summary>
        /// 手机验证登录切换按钮
        /// </summary>
        private void btn_PhoneValiLogin_Click(object sender, EventArgs e)
        {
            btn_OrdinaryLogin.Show();
            btn_PhoneValiLogin.Hide();
            panel_Pwd.Hide();
            panel_ValiCode.Location = new Point(50, 150);
            panel_ValiCode.Show();
            btn_DyLogin.Show();
            btn_Login.Hide();
            AutoLogin.Hide();
            RememberPassword.Hide();
        }
        #endregion

        /// <summary>
        /// 首次登录事件
        /// </summary>
        private void btn_FirstLogin_Click(object sender, EventArgs e)
        {
            new LoginFirstFrm().Show();
            this.Hide();
        }

        #region 忘记密码事件
        private void btn_ForgrtPwd_Click(object sender, EventArgs e)
        {
            new ForgetPwdFrm().Show();
            this.Hide();
            // this.Controls.Remove(panel_Login);
        }
        #endregion

        #region 鼠标点击和离开的相关事件
        //鼠标点击textbox,textbox清空值的事件
        public void TextBox_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text.Trim() == "密码" || txtBox.Text.Trim() == "验证码" || txtBox.Text.Trim() == "重置密码"
                || txtBox.Text.Trim() == "请输入手机号码" || txtBox.Text.Trim() == "确认密码"
                || txtBox.Text.Trim() == "设置密码为6-20个字符")
            {
                txtBox.Text = "";
                txtBox.ForeColor = Color.Black;
            }

        }

        /// <summary>
        ///   鼠标点击MyCombobox,MyCombobox清空值的方法
        /// </summary>
        private void txt_Phone_Click(object sender, EventArgs e)
        {
            MyComboBox MyBox = (MyComboBox)sender;
            if (MyBox.Text.Trim() == "请输入手机号码")
            {
                MyBox.Text = "";
            }
            else
            {
                MyBox.ForeColor = Color.Black;
            }
        }

        /// <summary>
        ///   鼠标离开textbox,text恢复默认值  
        /// </summary>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (txt_Phone.Text == "")
            {
                txt_Phone.Text = "请输入手机号码";
                txt_Phone.ForeColor = Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            }
            else if (txt_Pwd.Text == "")
            {
                txt_Pwd.Text = "密码";
                txt_Pwd.ForeColor = Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            }

            else if (txt_ValiCode.Text == "")
            {
                txt_ValiCode.Text = "验证码";
                txt_ValiCode.ForeColor = Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            }
        }
        /// <summary>
        /// MyComboBox中的手机号码改变，密码框的密码变为空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            //清空PasswordChar的设置
            txt_Pwd.PasswordChar = Convert.ToChar(0);
            txt_Pwd.Text = "密码";
            txt_Pwd.ForeColor = Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            txt_Phone.ForeColor = Color.Black;
            // txt_Pwd.ForeColor = Color.;
            if (this.txt_Phone.Text.Trim() != "")
            {
                if (users.ContainsKey(this.txt_Phone.Text.Trim()))
                {
                    this.txt_Pwd.Text = users[this.txt_Phone.Text.Trim()].Password;
                }
            }
        }
        #endregion

        #region 将输入的密码转换成 *显示
        public void txt_Pwd_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text != "" && txt.Text != "密码" && txt.Text != "重置密码"
                && txt.Text != "确认密码" && txt.Text != "设置密码为6-20个字符")
            {
                txt.PasswordChar = '*';
                txt.ForeColor = Color.Black;
            }
            if (txt.Text == "")
            {
                //清空PasswordChar的设置
                txt.PasswordChar = Convert.ToChar(0);
            }


        }
        #endregion

        #region 窗体加载的时候读取本地用户的账户信息 

        private void LoginMainFrm_Load(object sender, EventArgs e)
        {
            try
            {// 读取配置文件寻找记住的用户名和密码
                //FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate);
                //string ecd = System.Environment.CurrentDirectory;
                //string iocd = System.IO.Directory.GetCurrentDirectory();
                //string appPath = System.Windows.Forms.Application.StartupPath;
                //MessageBox.Show(ecd + "-------" + iocd + "-------" + appsp);
                FileStream fs = new FileStream(@"D:\data.bin", FileMode.OpenOrCreate);
                if (fs.Length > 0)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Dictionary<string, User> temp = bf.Deserialize(fs) as Dictionary<string, User>;
                    foreach (User user in temp.Values)
                    {
                        User tempu = user.clone();
                        this.txt_Phone.Items.Add(tempu.Tel);
                        users[tempu.Tel] = tempu;
                    }
                }
                fs.Close();
            }
            catch (Exception exception)
            {
            }
        }


        private void LoginMainFrm_Shown(object sender, EventArgs e)
        {
            // 用户名选中最后一次登陆
            foreach (string key in users.Keys)
            {
                User u = (User)users[key];
                if (u.IsLastLogin == 1)
                {
                    this.txt_Phone.Text = u.Tel;
                    currentUser = u;
                    if (type == 0 && u.IsAutoLogin == 1)// 切换帐户不自动登陆
                    {
                        btn_Login.Text = "登录中";
                        Delay(2000);
                        Login(u, 1);
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// 非独占延时
        /// </summary>
        /// <param name="milliSecond"></param>
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }

        #endregion

        #region 记录最后一次登陆的用户
        /// <summary>
        /// /最后一次登陆的用户一个标记为 1
        /// </summary>
        /// <param name="tel">用户手机号码</param>
        private void storeLastLoginInfo(string tel)
        {
            foreach (string key in users.Keys)
            {
                User user = (User)users[key];
                if (user.Tel == tel)
                {
                    user.IsLastLogin = 1;
                }
                else
                {
                    user.IsLastLogin = 0;
                }
            }
        }
        #endregion

        #region 通过账号获取记住的密码
        private void txt_Phone_SelectedValueChanged(object sender, EventArgs e)
        {

            if (users.ContainsKey(txt_Phone.Text.Trim()) && users[txt_Phone.Text.Trim()].Password != "")
            {
                this.txt_Pwd.Text = users[txt_Phone.Text.Trim()].Password;
                this.RememberPassword.Checked = true;
                if (users[txt_Phone.Text.Trim()].IsAutoLogin == 0)
                {
                    this.AutoLogin.Checked = false;
                }
            }
            else
            {
                this.txt_Pwd.Text = "密码";
                this.RememberPassword.Checked = false;
                this.AutoLogin.Checked = false;
            }
        }
        #endregion

        /// <summary>
        ///  窗口关闭 程序退出
        /// </summary>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        /// <summary>
        /// MD5加密方法
        /// </summary>
        /// <param name="str">密码字符串</param>
        /// <returns></returns>
        public static string getMd5Hash(string str)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.   
            MD5 md5Hasher = MD5.Create();

            byte[] data = md5Hasher.ComputeHash(Encoding.GetEncoding("UTF-8").GetBytes(str));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.   
            return sBuilder.ToString();
        }

       
        /// <summary>
        /// 移动窗体
        /// </summary>
        /// <returns></returns>      
       
        private void panel_Login_MouseDown(object sender, MouseEventArgs e)
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

        private void LoginMainFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btn_OrdinaryLogin.Visible == true)
                {
                    btn_DyLogin_Click(sender, e);
                }
                else
                {
                    btn_Login_Click(sender, e);
                }

            }
        }

    }
}
