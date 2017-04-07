using GovDocSearch.cc.topware.form.comp;
using GovDocSearch.cc.topware.serialize;
using GovDocSearch.cc.topware.service;
using GovDocSearch.cc.topware.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovDocSearch.cc.topware.form
{
    public partial class HouseList : FlowLayoutPanel
    {
        private FloatWin owner = null;
        //public Dictionary<string, object>[] categoryList;
        public object[] categoryList;
        public HouseList()
        {
            InitializeComponent();
        }

        public HouseList(IContainer container)
        {            
            container.Add(this);          
            InitializeComponent();
        }

        public HouseList(FloatWin owner)
        {
            this.owner = owner;           
            InitializeComponent();           
            init();
        }

        /// <summary>
        /// 获取用户有上传权限的库列表
        /// </summary>
        private void init()
        {
            String data = CommonService.remote("web/dw/dir/moveable.do", "");
            Result rst = JsonHelper.Json2Object<Result>(data);
            if (CommonService.isSuccess(rst.isSuccess))
            {
                categoryList = (object[])rst.data;
                //foreach (object obj in categoryList)
                //{
                //    Console.WriteLine();
                //}
            }
            initView();

        }

        /// <summary>
        /// 生成库列表界面
        /// </summary>
        private void initView()
        {
            //houseList.Dock = DockStyle.Bottom;
            //Height = categoryList.Count() * 32;  
            // AutoScroll = true;
            //AutoSize = true;
          
            Width = 112;
            Top = 112;
            FlowDirection = FlowDirection.TopDown;
            if (categoryList.Count() * 32 >= 420)
            {
                Height = 420;             
                //FlowDirection = FlowDirection.TopDown;
                WrapContents = false;
                HorizontalScroll.Maximum = 0; // 把水平滚动范围设成0就看不到水平滚动条了             
                AutoScroll = true; // 注意启用滚动的顺序，应是完成设置的最后一条语句      
                AllowDrop = true;              
                Left = 70;
            }
            else
            {
                Left = 64;
                //FlowDirection = FlowDirection.TopDown;              
                AutoSize = true;
            }          
            BackColor = System.Drawing.Color.Transparent;                      
            MouseLeave += new EventHandler(houseList_mouseLeave);
            MouseWheel += new MouseEventHandler(houseList_MouseWheel);
            //MouseMove += new MouseEventHandler(houseList_Click);

            if (null == categoryList)
                return;          
            foreach (object obj in categoryList)
            {              
                addItem(obj);                
            }
            // 添加取消按钮
        }

        private void addItem(object obj)
        {
            Panel pParent = new Panel();
            Panel p = new Panel();          
            p.AutoScroll = true;     
            //p.BackgroundImage = Image.FromFile(@"../../Resources/images/houseBg.png");
            p.BackgroundImage = global::GovDocSearch.Properties.Resources.houseBg;
            p.Width =107;
            p.Height = 32;
            p.Margin = new Padding(0, 0, 0, 0);
            DataLabel label = new DataLabel();          
            Dictionary<string, object> cg = (Dictionary<string, object>)obj;
            label.data = cg;
            //int type = Convert.ToInt32(label.getAttrType("type"));
            //   if (type == 1)
            //   {
            //       label.Text = "公共库-" + label.getAttr("name");
            //   }        
            label.Text = label.getAttr("name");
            label.Text = label.Text;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(label, label.Text); // 鼠标经过浮窗显示账户信息
            label.Dock = DockStyle.Fill;
            label.Width = 107;
            label.Height = 32;
            label.AutoSize = false;
            label.Font = new Font("微软雅黑", 8, label.Font.Style);
            label.ForeColor = Color.White;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label.Padding = new Padding(5, 0, 5, 0);
            label.BackColor = Color.Transparent;
            label.AllowDrop = true;
            label.DragEnter += new DragEventHandler(houseLabel_dragEnter);
            label.DragDrop += new DragEventHandler(houseLabel_DragDrop);
            label.DragLeave += new EventHandler(houseLabel_dragLeave);
            //label.BorderStyle = BorderStyle.FixedSingle;
            p.Controls.Add(label);
            Controls.Add(p);                 
        }

        private void houseList_mouseLeave(object sender, EventArgs e)
        {
            owner.resetHeight();
        }
        private void houseList_MouseWheel(object sender, MouseEventArgs e)
        {
           // this.Focus();
           // VerticalScroll.Value -= e.Delta;
            Refresh();
            Invalidate();
            Update();       
        }

        //private void houseList_Click(object sender, MouseEventArgs e)
        //{
        //    Point mousePoint = new Point(e.X, e.Y);
        //    mousePoint.Offset(this.Location.X, this.Location.Y);
        //    if (this.RectangleToScreen(this.DisplayRectangle).Contains(mousePoint))
        //    {
        //        this.AutoScrollPosition = new Point(0, this.VerticalScroll.Value - e.Delta);//滚动
        //    }
        //}
        private void houseLabel_dragEnter(object sender, DragEventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = ColorTranslator.FromHtml("#4c85ad");

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void houseLabel_DragDrop(object sender, DragEventArgs e)
        {
            DataLabel label = (DataLabel)sender;
            label.BackColor = Color.Transparent;
            owner.resetHeight();
            //this.Hide();

            try
            {
                String[] files = e.Data.GetData(DataFormats.FileDrop, false) as String[];
                // 判断文件类型
                //uploadDetail.uploadFiles(files, category);
                owner.showUploadDetailWin();            
                owner.uploadFiles(files, label.data);
                //if (UploadHelper.uploadingFileCount != 0)
                //{
                //    owner.pictureBox1.Image = GovDocSearch.Properties.Resources.小蜜蜜0005;
                //}
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }      
        private void houseLabel_dragLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.Transparent;
        }

        public int getHeight()
        {
            return categoryList.Count() * 32;
        }
    }
}
