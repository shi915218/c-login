using GovDocSearch.cc.topware.form.comp;
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
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static GovDocSearch.cc.topware.util.UploadHelper;

namespace GovDocSearch.cc.topware.form
{
    public partial class UploadDetail : Form
    {
        private FloatWin floatWin;
        private UploadHelper uploadHelper;
        private Dictionary<string, UploadItem> itemDic;
        private List<UploadItemVO> successList;

        public UploadDetail(FloatWin floatWin)
        {
            InitializeComponent();
            this.floatWin = floatWin;
            this.uploadHelper = floatWin.uploadHelper;
            itemDic = new Dictionary<string, UploadItem>();

            ResetTitlePanel();
            this.titlelabel.Left = (this.titlepanel.Width - this.titlelabel.Width) / 2;
            this.titlelabel.Top = 10;

            this.Load += new System.EventHandler(this.LoadHandler);

            successList = new List<UploadItemVO>();
        }

        #region 窗口设置及辅助方法

        private void LoadHandler(object sender, EventArgs e)
        {
            displayUploadingInfo();
            this.uploadHelper.UploadBeginEvent += new UploadBeginEventHander(this.UploadBeginEventHander);
            this.uploadHelper.UploadEvent += new UploadEventHander(this.UploadEventHander);
            this.uploadHelper.UploadEndEvent += new UploadEndEventHander(this.UploadEndEventHandler);
           //this.uploadHelper.GifChangeEvent += new GifChangEventHander(this.GifChangEventHander);
        }
        /// <summary>
        /// 用隐藏替代窗口关闭事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            //base.OnClosing(e);
        }
        public FlowLayoutPanel getUploadingItemContainer()
        {
            return this.uploadingItemContainer;
        }
        public FlowLayoutPanel getUploadedItemContainer()
        {
            return this.uploadedItemContainer;
        }

        public void showView()
        {
            this.Show();
            this.Activate();
            this.uploadList.SelectedTab = this.uploading;
        }

        #endregion

        #region 多线程上传文件2

        private delegate void DisplayUploadingList();
        public void displayUploadingList()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DisplayUploadingList(displayUploadingList));
            }
            else
            {
                displayUploadingInfo();
            }
        }
        private void displayUploadingInfo()
        {
            List<UploadItemVO> voList = uploadHelper.voList;            
            foreach (UploadItemVO vo in voList)
            {
                UploadInfoComps comps = new UploadInfoComps();
                comps.vo = vo;               
                if (comps.vo.status == "success")
                {
                    addSuccessItem(comps.vo);                                      
                }
                else
                {                    
                    UploadItem item = new UploadItem(this, comps, uploadHelper,floatWin);
                    itemDic[vo.name] = item;
                }
            }
        }

        /// <summary>
        /// 重新上传单个文档
        /// </summary>
        public void reUploadFile(UploadInfoComps comps)
        {
            comps.vo.status = "resume";
            UploadHelper.uploadingFileCount++;
            uploadHelper.UploadFile(comps.vo);         
            //uploading_FileCountLabel.Text = "正在上传" + uploadHelper.voList.Count + "个文档";
        }

        private void UploadBeginEventHander(UploadItemVO vo)
        {
            UploadInfoComps comps = new UploadInfoComps();
            comps.vo = vo;
            UploadItem item = new UploadItem(this, comps, uploadHelper,floatWin);
            itemDic[vo.name] = item;
        }

        private void UploadEventHander(UploadItemVO vo)
        {
            itemDic[vo.name].updateProgressBar(vo.value);
        }
        //private void GifChangEventHander(int uploadingFileCount)
        //{
        //    if (uploadingFileCount != 0)
        //    {

        //        //lock (floatWin.pictureBox1.Image) ;
        //        if (floatWin.pictureBox1.Image.Size.Width == 240)  //宽度为240说明当前图像就是小蜜蜜（蜜蜂0002的宽度！=240）
        //        {
        //            return;
        //        }

        //        else
        //        {
        //            floatWin.pictureBox1.Image = GovDocSearch.Properties.Resources.小蜜蜜;
        //        }

        //    }
        //}
        private void UploadEndEventHandler(UploadItemVO vo)
        {
            itemDic[vo.name].updateStatus(vo.status);
            addSuccessItem(vo);
        }

        public void start(UploadInfoComps comps)
        {          
            comps.start.Visible = false;
            comps.pause.Visible = true;
            comps.btnPanel.Left = 715;
            comps.fileStatus.Text = "上传中...";
            comps.vo.status = "uploading";
            //重新上传         
            reUploadFile(comps);
        }
        public void pause(UploadInfoComps comps)
        {
            if (null != comps.thread)
            {
                comps.thread.Abort();
            }
            comps.pause.Visible = false;
            comps.start.Visible = true;
            comps.btnPanel.Left = 715;
            comps.fileStatus.Text = "暂停中...";
            comps.vo.status = "pause";
            //取消上传
            try
            {
                comps.vo.request.Abort();
            }
            catch (Exception e)
            {
            }
        }
        private void allPauseBtn_Click(object sender, EventArgs e)
        {
            pauseAll();
           // floatWin.pictureBox1.Image = GovDocSearch.Properties.Resources.蜜蜂0002;          
        }
        public void pauseAll()
        {         
            UploadItem[] items = uploadingItemContainer.Controls.OfType<UploadItem>().ToArray();
            foreach (UploadItem item in items)
            {
                if (item.comps.vo.status.Equals("uploading"))
                    pause(item.comps);              
            }        
        }
        public void del(UploadInfoComps comps)
        {
            if (null != comps.thread && (comps.thread.ThreadState != ThreadState.Stopped ||
                comps.thread.ThreadState != ThreadState.Aborted))
            {
                comps.thread.Abort();
            }
            List<UploadItemVO> voList = uploadHelper.voList;
            uploading_FileCountLabel.Text = "正在上传" + (uploadHelper.voList.Count - 1) + "个文档";
            voList.Remove(comps.vo);
            try
            {
                comps.vo.request.Abort();
            }
            catch (Exception e)
            {

            }
         
        }
        private void allDeleteBtn_Click(object sender, EventArgs e)
        {
            List<UploadItemVO> voList = uploadHelper.voList;
            if (uploadHelper.voList.Count > 0)
            {
                DialogResult dr = MessageBox.Show("有文件正在上传，是否只删除上传结束项？", "提示", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    for (int i = this.uploadingItemContainer.Controls.Count - 1; i >= 0; i--)
                    {
                        Control c = this.uploadingItemContainer.Controls[i];
                        if (c is UploadItem)
                        {
                            UploadItem item = (UploadItem)c;
                            if (item.comps.vo.status == "success" || item.comps.vo.status == "fail")
                            {
                                voList.Remove(item.comps.vo);
                                this.uploadingItemContainer.Controls.Remove(c);
                                uploading_FileCountLabel.Text = "正在上传" + uploadHelper.voList.Count + "个文档";
                            }
                        }
                    }
                }
                else if (dr == DialogResult.No)
                {
                    this.uploadingItemContainer.Controls.Clear();
                    voList.Clear();
                    //uploadHelper.uploadingFileCount = 0;
                    uploading_FileCountLabel.Text = "正在上传0个文档";
                }
            }
            else
            {
                this.uploadingItemContainer.Controls.Clear();
                voList.Clear();
                //uploadHelper.uploadingFileCount = 0;
                //uploading_FileCountLabel.Text = "正在上传" + uploadHelper.voList.Count + "个文档";
            }           
        }

        #endregion

        #region 上传成功列表

        private delegate void AddSuccessItem(UploadItemVO vo);
        private void addSuccessItem(UploadItemVO vo)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AddSuccessItem(addSuccessItem), vo);
            }
            else
            {
                if (vo.status == "success")
                {
                    successList.Add(vo);
                    UploadedItem ui = new UploadedItem(this, vo);                   
                }
                //uploading_FileCountLabel.Text = "正在上传" + uploadHelper.uploadingFileCount + "个文档";
                uploaded_FileCountLabel.Text = "上传成功" + successList.Count() + "个文档";
            }
        }

        public void delSuccessItem(UploadInfoComps comps)
        {
            if (null != comps.thread && (comps.thread.ThreadState != ThreadState.Stopped ||
                comps.thread.ThreadState != ThreadState.Aborted))
            {
                comps.thread.Abort();
            }
            successList.Remove(comps.vo);
            uploaded_FileCountLabel.Text = "上传成功" + successList.Count() + "个文档";
        }

        private void allClearBtn_Click(object sender, EventArgs e)
        {
            successList.Clear();
            this.uploadedItemContainer.Controls.Clear();
            uploaded_FileCountLabel.Text = "上传成功" + successList.Count() + "个文档";
        }

        #endregion

        #region 重写窗口最小化、关闭图标
        private bool moving = false;
        private Point oldMousePosition;

        public new FormBorderStyle FormBorderStyle
        {
            get
            {
                return base.FormBorderStyle;
            }
            set
            {
                if (value != FormBorderStyle.Sizable && value != FormBorderStyle.SizableToolWindow)
                {
                    titlepanel.Controls.Remove(button2);
                }
                base.FormBorderStyle = value;
            }
        }

        #region 隐藏父类的属性，使其不可见

        [Browsable(false)]
        public new string Text
        {
            get
            {
                return titlelabel.Text;
            }
            set
            { }
        }

        [Browsable(false)]
        public new bool ControlBox
        {
            get
            {
                return false;
            }
            set
            {
                base.ControlBox = false;
            }
        }

        #endregion

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题")]
        public string Title
        {
            get { return titlelabel.Text; }
            set { titlelabel.Text = value; }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题字体样式")]
        public Font TitleFont
        {
            get
            {
                return titlelabel.Font;
            }
            set
            {
                titlelabel.Font = value;
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题字体颜色")]
        public Color TitleColor
        {
            get
            {
                return titlelabel.ForeColor;
            }
            set
            {
                titlelabel.ForeColor = value;
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("窗体标题栏背景色")]
        public Color TitleBarBackColor
        {
            get
            {
                return titlepanel.BackColor;
            }
            set
            {
                titlepanel.BackColor = value;
            }
        }

        public new bool MaximizeBox
        {
            get
            {
                return titlepanel.Contains(button2);
            }
            set
            {
                if (!value)
                {
                    titlepanel.Controls.Remove(button2);
                }
                else if (!titlepanel.Contains(button2))
                {
                    titlepanel.Controls.Add(button2);
                }
            }
        }

        public new bool MinimizeBox
        {
            get
            {
                return titlepanel.Contains(button3);
            }
            set
            {
                if (!value)
                {
                    titlepanel.Controls.Remove(button3);
                }
                else if (!titlepanel.Contains(button3))
                {
                    titlepanel.Controls.Add(button3);
                }
            }
        }

        private void ResetTitlePanel()
        {
            base.ControlBox = false;
            base.Text = null;
            SetToolTip(button1, "关闭");
            button2.Size = button1.Size;
            SetToolTip(button2, "最大化或还原");
            button3.Size = button1.Size;
            SetToolTip(button3, "最小化");
        }

        private void SetToolTip(Control ctrl, string tip)
        {
            new ToolTip().SetToolTip(ctrl, tip);
        }

        private void Titlebutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag.ToString())
            {
                case "close":
                    {
                        this.Close();
                        //Top = -900;
                        //ShowInTaskbar = false;
                        break;
                    }
                case "max":
                    {
                        if (this.WindowState == FormWindowState.Maximized)
                        {
                            this.WindowState = FormWindowState.Normal;
                        }
                        else
                        {
                            this.WindowState = FormWindowState.Maximized;
                        }
                        break;
                    }
                case "min":
                    {
                        if (this.WindowState != FormWindowState.Minimized)
                        {
                            this.WindowState = FormWindowState.Minimized;
                        }
                        break;
                    }
            }
        }

        private void Titlepanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                return;
            }
            //Titlepanel.Cursor = Cursors.NoMove2D;
            oldMousePosition = e.Location;
            moving = true;
        }

        private void Titlepanel_MouseUp(object sender, MouseEventArgs e)
        {
            //Titlepanel.Cursor = Cursors.Default;
             moving = false;
        }

        private void Titlepanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && moving)
            {
                Point newPosition = new Point(e.Location.X - oldMousePosition.X, e.Location.Y - oldMousePosition.Y);
                this.Location += new Size(newPosition);
            }
        }

        private void Titlepanel_DoubleClick(object sender, EventArgs e)
        {
            if (titlepanel.Contains(button2))
            {
                button2.PerformClick();
            }
        }

        private void titlepanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            switch (e.Control.Name)
            {
                case "button2":
                    {
                        if (titlepanel.Contains(button3))
                        {
                            button3.Left = button1.Left - button1.Width;
                        }
                        break;
                    }
            }
        }

        private void titlepanel_ControlAdded(object sender, ControlEventArgs e)
        {
            switch (e.Control.Name)
            {
                case "button2":
                    {
                        if (titlepanel.Contains(button3))
                        {
                            button3.Left = button2.Left - button2.Width;
                        }
                        break;
                    }
                case "button3":
                    {
                        if (titlepanel.Contains(button2))
                        {
                            button3.Left = button2.Left - button2.Width;
                        }
                        break;
                    }
            }
        }
        #endregion

        #region 重绘Tab Header

        string[] Colors = new string[] { "red", "blue", "white", "none", "orange" };
        private void uploadList_DrawItem(object sender, DrawItemEventArgs e)
        {
            //获取TabControl主控件的工作区域
            Rectangle rec = uploadList.ClientRectangle;
            //获取背景图片，我的背景图片在项目资源文件中。
            //新建一个StringFormat对象，用于对标签文字的布局设置
            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;// 设置文字垂直方向居中
            StrFormat.Alignment = StringAlignment.Center;// 设置文字水平方向居中          
                                                         // 标签背景填充颜色，也可以是图片
            SolidBrush bru = new SolidBrush(Color.White);
            SolidBrush bruFont = new SolidBrush(Color.FromArgb(51, 51, 51));// 标签字体颜色
            Font font = new System.Drawing.Font("微软雅黑", 14F);//设置标签字体样式
                                                             //绘制主控件的背景
                                                             //e.Graphics.DrawImage(null, 0, 0, uploadList.Width, uploadList.Height);
                                                             //绘制标签样式
            for (int i = 0; i < uploadList.TabPages.Count; i++)
            {
                //获取标签头的工作区域
                Rectangle recChild = uploadList.GetTabRect(i);
                recChild.Height += 3;
                //绘制标签头背景颜色
                e.Graphics.FillRectangle(bru, recChild);
                //绘制标签头的文字
                e.Graphics.DrawString(uploadList.TabPages[i].Text, font, bruFont, recChild, StrFormat);
            }

            int si = uploadList.SelectedIndex == 0 ? 1 : 0;
            Rectangle activeTabHeader = uploadList.GetTabRect(si);
            Pen p = new Pen(Color.FromArgb(225, 225, 225));
            Graphics g = uploadList.CreateGraphics();
            g.DrawLine(p, activeTabHeader.Left, activeTabHeader.Height + 3,
            activeTabHeader.Left + activeTabHeader.Width - 1, activeTabHeader.Height + 3);
        }

        #endregion


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
    }
}
