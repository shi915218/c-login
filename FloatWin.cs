using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using GovDocSearch.cc.topware.util;
using GovDocSearch.cc.topware.serialize;
using GovDocSearch.cc.topware.form.comp;
using System.IO;
using System.Net;
using GovDocSearch.cc.topware.serialize;
using GovDocSearch.cc.topware.service;

namespace GovDocSearch.cc.topware.form
{
    public partial class FloatWin : Form
    {
       
        private Form creatorForm;
        private int isAutoLogin;
        private ToolTip toolTip;
        private String tipInfo = "账号名称：";
        private User user;

        UploadDetail uploadDetail;

        public UploadHelper uploadHelper;

        public FloatWin(Form creatorForm, object obj, int isAutoLogin = 0)
        {
            InitializeComponent();        
            TransparencyKey = BackColor; // 隐藏背景颜色        
            this.creatorForm = creatorForm;
            user = (User)obj;
            this.isAutoLogin = isAutoLogin;         
        } 
     
        public void FloatWin_Load(object sender, EventArgs e)
        {
            TopMost = true;//保证浮窗置顶

            // 浮窗位置，屏幕右上角
            Left = Screen.PrimaryScreen.Bounds.Width - 200;
            Top = 130;

            if (isAutoLogin == 1 && creatorForm.Visible == true)
            {
                creatorForm.Hide();
            }
             //this.pictureBox1.Image = GovDocSearch.Properties.Resources.蜜蜂;
            //初始化浮窗属性
            //user = new User();
            //user.name =tel;          
            toolTip = new ToolTip();
            toolTip.SetToolTip(this.pictureBox1, tipInfo + user.Tel); // 鼠标经过浮窗显示账户信息
            //toolTip.SetToolTip(this.label1, tipInfo + user.Tel);
            floatWin_ni.Text = tipInfo + user.Tel;// 鼠标经过托盘图标显示账户信息

            uploadHelper = new UploadHelper();

            initHouseList();//初始化库选择列表
            //pictureBox1.Image = imageList1.Images[0];
            //Win32API.UpdateLayeredWindow(this.Handle, screenDc, ref topPos, ref size, memDc, ref pointSource, 0, ref blend, API.ULW_ALPHA);
        }

        public void SetBitmap(Bitmap bitmap, byte opacity)
        {
            //if (bitmap.PixelFormat != PixelFormat.Format32bppArgb)
            //    throw new ApplicationException("位图必须是32位包含alpha 通道");

            //IntPtr screenDc = Win32API.GetDC(IntPtr.Zero);
            //IntPtr memDc = Win32API.CreateCompatibleDC(screenDc);
            //IntPtr hBitmap = IntPtr.Zero;
            //IntPtr oldBitmap = IntPtr.Zero;

            //try
            //{
            //    hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));   // 创建GDI位图句柄，效率较低
            //    oldBitmap = Win32API.SelectObject(memDc, hBitmap);

            //    Win32API.Size size = new Win32API.Size(bitmap.Width, bitmap.Height);
            //    Win32API.Point pointSource = new Win32API.Point(0, 0);
            //    Win32API.Point topPos = new Win32API.Point(Left, Top);
            //    Win32API.BLENDFUNCTION blend = new Win32API.BLENDFUNCTION();
            //    blend.BlendOp = Win32API.AC_SRC_OVER;
            //    blend.BlendFlags = 0;
            //    blend.SourceConstantAlpha = opacity;
            //    blend.AlphaFormat = Win32API.AC_SRC_ALPHA;

            //    Win32API.UpdateLayeredWindow(Handle, screenDc, ref topPos, ref size, memDc, ref pointSource, 0, ref blend, Win32.ULW_ALPHA);
            //}
            //finally
            //{
            //    Win32API.ReleaseDC(IntPtr.Zero, screenDc);
            //    if (hBitmap != IntPtr.Zero)
            //    {
            //        Win32API.SelectObject(memDc, oldBitmap);

            //        Win32API.DeleteObject(hBitmap);
            //    }
            //    Win32API.DeleteDC(memDc);
            //}
        }

        #region 添加系统右键菜单

        private void AddFileContextMenuItem(string itemName, string associatedProgramFullPath)
        {
            //创建项：shell 
            RegistryKey shellKey = Registry.ClassesRoot.OpenSubKey(@"*\shell", true);
            if (shellKey == null)
            {
                shellKey = Registry.ClassesRoot.CreateSubKey(@"*\shell");
            }

            //创建项：右键显示的菜单名称
            RegistryKey rightCommondKey = shellKey.CreateSubKey(itemName);
            RegistryKey associatedProgramKey = rightCommondKey.CreateSubKey("command");

            //创建默认值：关联的程序
            associatedProgramKey.SetValue(string.Empty, associatedProgramFullPath);

            //刷新到磁盘并释放资源
            associatedProgramKey.Close();
            rightCommondKey.Close();
            shellKey.Close();
        }

        private void AddDirectoryContextMenuItem(string itemName, string associatedProgramFullPath)
        {
            //创建项：shell 
            RegistryKey shellKey = Registry.ClassesRoot.OpenSubKey(@"directory\shell", true);
            if (shellKey == null)
            {
                shellKey = Registry.ClassesRoot.CreateSubKey(@"*\shell");
            }

            //创建项：右键显示的菜单名称
            RegistryKey rightCommondKey = shellKey.CreateSubKey(itemName);
            RegistryKey associatedProgramKey = rightCommondKey.CreateSubKey("command");

            //创建默认值：关联的程序
            associatedProgramKey.SetValue("", associatedProgramFullPath);

            //刷新到磁盘并释放资源
            associatedProgramKey.Close();
            rightCommondKey.Close();
            shellKey.Close();
        }

        #endregion

        public void showUploadDetailWin()
        {
            //Create uploadDetail window;
            if (uploadDetail == null || uploadDetail.IsDisposed)
            {
                uploadDetail = new UploadDetail(this);
               
            } else if (uploadDetail.WindowState == FormWindowState.Minimized)
            {
                uploadDetail.WindowState = FormWindowState.Normal;
            }
              uploadDetail.showView();                          
        }

        private void pauseAllTask()
        {
            if (uploadDetail == null || uploadDetail.IsDisposed)
            {
                uploadDetail = new UploadDetail(this);
            }
            uploadDetail.pauseAll();
        }

        #region 浮窗点击移动
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        //private void Form1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        mouseOff = new Point(-e.X, -e.Y); //得到变量的值
        //        leftFlag = true;                  //点击左键按下时标注为true;
        //    }
        //}

        //private void Form1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (leftFlag)
        //    {
        //        Point mouseSet = Control.MousePosition;
        //        mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
        //        Location = mouseSet;
        //    }
        //}

        //private void Form1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (leftFlag)
        //    {
        //        leftFlag = false;//释放鼠标后标注为false;
        //    }
        //}

        private void FloatWin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void FloatWin_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
            houseList.Focus();
        }

        private void FloatWin_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }
        #endregion

        #region 浮窗、托盘鼠标事件

        /**
         * 浮窗双击
         */
        private void floatWin_doubleClick(object sender, EventArgs e)
        {
            showUploadDetailWin();
        }

        /**
         * 浮窗右键点击【我的主页】
         */       
        private void fwcms_myPage_Click(object sender, EventArgs e)
        {
             string mainPageAddress = ConfigInfo.loadConfig("mainPage");
        //string mainPageAddress = loadXml.Read("mainPage");
        //string mainPageAddress = System.Configuration.ConfigurationManager.AppSettings["mainPage"];
            string jsession = CommonService.jsession;
            if (jsession != null && jsession!="")
            {
                string[] setCookieArray = jsession.Split(';');
                string jsessionId = setCookieArray[0];
                string[] jsessionIdArr = jsessionId.Split('=');
                jsessionId = jsessionIdArr[1];               
                string s = mainPageAddress + ";jsessionid=" + jsessionId;
                //   // string s = "http://192.168.15.224:8080/topware-govdocsearch/";
                System.Diagnostics.Process.Start(s);
            }
            else {
                System.Diagnostics.Process.Start(mainPageAddress);
            }
        }

        /**
         * 浮窗右键点击【查看上传列表】
         */
        private void fwcms_openUploadList_Click(object sender, EventArgs e)
        {
            showUploadDetailWin();           
        }

        /**
         * 浮窗右键点击【暂停所有任务】
         */
        private void fwcms_pauseAllTask_Click(object sender, EventArgs e)
        {
            pauseAllTask();
        }

        /**
         * 浮窗右键点击【设置】
         */
        private void fwcms_set_Click(object sender, EventArgs e)
        {
          
                StartPc startPc=new StartPc();         
                startPc.Show();                           
        }

        /**
         * 浮窗右键点击【隐藏】
         */
        private void fwcms_hide_Click(object sender, EventArgs e)
        {
            Hide();
        }
        /**
         * 浮窗右键点击【切换用户】
         */
        private void fwcms_changeUser_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginMainFrm(1).Show();
        }
        /**
         * 浮窗右键点击【退出】
         */
        private void fwcms_exit_Click(object sender, EventArgs e)
        {
            user.IsExist = 0;
            Application.Exit();
        }

        /**
         * 托盘双击
         */
        private void floatWin_ni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;           
        }

        #endregion      

        #region 库列表模块

        /// <summary>
        /// 初始化库选择列表
        /// </summary>
        private HouseList houseList;
        private void initHouseList()
        {
            //string tel = "18267933555";
            //string password = "1";
            //Boolean isRemember = false;
            //string par = "mobile=" + tel + "&password=" + password + "&isRemember=" + isRemember;
            //String data = CommonService.remote("web//*login*//normal.do", par);
            //if (!string.IsNullOrEmpty(data))
            //{
            //    Result objs = JsonHelper.Json2Object<Result>(data);
            //}
            if (null != user)
            {
                houseList = new HouseList(this);
                Controls.Add(houseList);
            }
        }

        public void uploadFiles(String[] files, Dictionary<string, object> category)
        {
            uploadHelper.UploadFiles(files, category,this);
            //if (null != uploadDetail && !uploadDetail.IsDisposed)
            //{
            //    uploadDetail.displayUploadingList();
            //}
        }

        private void FloatWin_DragEnter(object sender, DragEventArgs e)
        {
            Height = 112+ houseList.getHeight();
            Invalidate();
            houseList.Show();
            houseList.Focus();           
        }
        private void FloatWin_DragLeave(object sender, EventArgs e)
        {         
            // resetHeight();
            //houseList.Hide();
        }
        public void resetHeight()
        {
            Height = 112;
        }

        #endregion        

        private void fw_ni_ShowFloatWin_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }
      
        private void FloatWin_MouseLeave(object sender, EventArgs e)
        {
            if (houseList.Visible == true)
            {
              houseList.Hide();
            }
        }

        private void FloatWin_MouseEnter(object sender, EventArgs e)
        {
            if (houseList.Visible == true)
            {
                houseList.Hide();
            }
        }
        /// <summary>
        /// 窗体移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //private void label1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    new FormMove().FormMove_MouseDown(this, e);
        //}

    }
}
