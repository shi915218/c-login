using GovDocSearch.cc.topware.serialize;
using GovDocSearch.cc.topware.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovDocSearch.cc.topware.form.comp
{
    public partial class UploadItem : Panel
    {
        private UploadDetail uploadDetail;
        private FlowLayoutPanel uploadingItemContainer;
        public UploadInfoComps comps;
        public UploadHelper uploadHelper;
        public int count;
        public FloatWin floatWin;
        public UploadItem()
        {
            InitializeComponent();
        }
        public UploadItem(UploadDetail uploadDetail, UploadInfoComps comps)
        {
            this.uploadDetail = uploadDetail;
            this.uploadingItemContainer = uploadDetail.getUploadingItemContainer();
            this.comps = comps;          
            InitializeComponent();
            init();
            addItems(comps.vo);
            this.uploadingItemContainer.Controls.Add(this);
        }

        public UploadItem(UploadDetail uploadDetail, UploadInfoComps comps, UploadHelper uploadHelper,FloatWin floatWin)
        {
            this.uploadDetail = uploadDetail;
            this.uploadingItemContainer = uploadDetail.getUploadingItemContainer();
            this.comps = comps;
            this.floatWin = floatWin;
            this.uploadHelper = uploadHelper;
            InitializeComponent();
            init();
            addItems(comps.vo);          
            this.uploadingItemContainer.Controls.Add(this);
        }

        public UploadItem(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void init()
        {
            Font = new Font("微软雅黑", 12, Font.Style);
            this.Width = this.uploadingItemContainer.Bounds.Width - 30;
            this.Height = 40;
            this.Margin = new Padding(0, 20, 0, 0);
        }

        public void addItems(UploadItemVO obj)
        {
            uploadDetail.uploading_FileCountLabel.Text = "正在上传" + uploadHelper.voList.Count+ "个文档";
            Panel gb1 = new Panel();
            gb1.Width = 260;
            gb1.Height = 40;
            gb1.Left = 38;
            PictureBox filePic = new PictureBox();
            //filePic.Image = Image.FromFile(@"../../Resources/images/word.png");
            //filePic.Image = global::GovDocSearch.Properties.Resources.word_24;
            filePic.Image = UploadHelper.getImage(obj.fileExtension);
            filePic.Width = 40;
            filePic.Height = 40;
            Label fileName = new Label();
            fileName.Text = obj.fileName;
            fileName.Width = 200;
            fileName.Left = 50;
            Label fileSize = new Label();
            fileSize.Font = new Font("微软雅黑", 9, fileName.Font.Style);
            fileSize.Text = Helper.ByteConvertGBMBKB(obj.fileSize);
            fileSize.Top = 25;
            fileSize.Left = 51;
            gb1.Controls.Add(filePic);
            gb1.Controls.Add(fileName);
            gb1.Controls.Add(fileSize);
            Controls.Add(gb1);

           
            //Controls.Add(timeLabel);

            ProgressBar pbar = new ProgressBar();                     
            pbar.Top = 6;
            //pbar.BackColor = Color.Gray;
            pbar.ForeColor = Color.Blue;
            pbar.Width = 150;
            pbar.Left = 300;
            pbar.Maximum =comps.vo.maximum;
            pbar.Minimum = comps.vo.minimum;           
            Controls.Add(pbar);

            Label labelProgressBar = new Label();
            labelProgressBar.Top = 6;
            labelProgressBar.Width = 65;
            //labelProgressBar.BackColor = Color.Transparent;
            labelProgressBar.ForeColor = Color.Red;
            labelProgressBar.Left = 470;
            //labelProgressBar.Visible = false;              
            //labelProgressBar.Text = comps.vo.minimum.ToString() + "%";
            Controls.Add(labelProgressBar);

            Label fileStatus = new Label();
            Label fileStatusTip = new Label();
            //fileStatus.Font = new Font("微软雅黑",9);
            fileStatus.Text = "上传中";
            fileStatus.Width = 150;
            fileStatus.Top = 6;
            fileStatus.Left = 547;
            fileStatusTip.Font = new Font("微软雅黑",9);
            fileStatusTip.Visible = false;
            fileStatusTip.Text = "";
            fileStatusTip.Width = 170;
            fileStatusTip.Top = 20;
            fileStatusTip.Left = 542;
            Controls.Add(fileStatus);
            Controls.Add(fileStatusTip);
            FlowLayoutPanel gb2 = new FlowLayoutPanel();
            //TableLayoutPanel gb2 = new TableLayoutPanel();
            //gb2.ColumnCount = 3;
            //gb2.RowCount = 1;
            gb2.Top = 5;
            gb2.Left = 715;
            gb2.Width = 60;
            //gb2.Width = 72;
            //gb2.Height = 24;
            //foreach (ColumnStyle cs in gb2.ColumnStyles)
            //{
            //    cs.Width = 24;
            //}
            PictureBox start = new PictureBox();
            start.Width = 18;
            start.Height = 18;
            //start.Image = Image.FromFile(@"../../Resources/images/start.png");
            start.Image = global::GovDocSearch.Properties.Resources.start;
            start.Cursor = Cursors.Hand;
            start.MouseClick += OnStartMouseClick;
            start.Visible = false;
            ToolTip startTip = new ToolTip();
            startTip.SetToolTip(start, "开始上传");
            PictureBox pause = new PictureBox();
            pause.Width = 18;
            pause.Height = 18;
            //pause.Image = Image.FromFile(@"../../Resources/images/pause.png");
            pause.Image = global::GovDocSearch.Properties.Resources.pause;
            pause.Cursor = Cursors.Hand;
            ToolTip pauseTip = new ToolTip();
            pauseTip.SetToolTip(pause, "暂停上传");
            pause.MouseClick += OnPauseMouseClick;
            PictureBox del = new PictureBox();
            del.Width = 18;
            del.Height = 18;
            //del.Image = Image.FromFile(@"../../Resources/images/del.png");
            del.Image = global::GovDocSearch.Properties.Resources.del;
            del.Cursor = Cursors.Hand;
            ToolTip delTip = new ToolTip();
            delTip.SetToolTip(del, "删除");
            del.MouseClick += OnDelMouseClick;
            gb2.Controls.Add(start);
            gb2.Controls.Add(pause);
            gb2.Controls.Add(del);
            //gb2.Controls.Add(start, 0, 0);
            //gb2.Controls.Add(pause, 1, 0);
            //gb2.Controls.Add(del, 2, 0);
            Controls.Add(gb2);

            comps.progressBar = pbar;
            comps.fileStatus = fileStatus;
            comps.fileStatusTip = fileStatusTip;
            comps.btnPanel = gb2;
            comps.start = start;
            comps.pause = pause;
            comps.del = del;           //
            comps.labelProgressBar = labelProgressBar;
        }

        private delegate void UpdateProgressBar(int i);
        public void updateProgressBar(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateProgressBar(updateProgressBar), value);
            }
            else
            {                
                comps.progressBar.Value = value;
                Application.DoEvents();
            }          
            comps.labelProgressBar.Text = (value * 100 / (comps.progressBar.Maximum+1)).ToString() + "%";//显示百分比  
           
        }
      
        private delegate void UpdateStatus(string status);
        public void updateStatus(string status)
        {
         //Result objs = JsonHelper.Json2Object<Result>(comps.vo.result.description);
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateStatus(updateStatus), status);
            }
            else
            {
                if (status == "pause")
                {                   
                    return;
                }
                else if (status == "success")
                {
                    comps.fileStatus.Text = "上传成功";
                    uploadDetail.uploading_FileCountLabel.Text = "正在上传" + (uploadHelper.voList.Count - 1) + "个文档";
                    this.uploadingItemContainer.Controls.Remove(this);
                    uploadDetail.del(comps);

                }
                else if (status == "fail1")
                {
                    failFun();
                }
                else {
                    failFun();
                }
                comps.start.Visible = false;
                comps.pause.Visible = false;
                comps.btnPanel.Left = 727;
            }
        }
        private void failFun()
        {
            //comps.fileStatus.Width = 150;
            comps.fileStatus.Top = 0;
            //comps.fileStatus.Left = 542;
            comps.fileStatus.Font = new Font("微软雅黑", 9);
            comps.fileStatus.Text = "上传失败";
            comps.fileStatus.Font = new Font("微软雅黑", 9);
            comps.fileStatusTip.ForeColor = Color.Red;
            comps.fileStatusTip.Visible = true;
            comps.fileStatusTip.Left = 537;
            comps.fileStatusTip.Text =comps.vo.desc;
        }
        private void OnStartMouseClick(object sender, MouseEventArgs e)
        {
            uploadDetail.start(comps);
        }
        private void OnPauseMouseClick(object sender, MouseEventArgs e)
        {
            uploadDetail.pause(comps);
        }
        private void OnDelMouseClick(object sender, MouseEventArgs e)
        {
            this.uploadingItemContainer.Controls.Remove(this);
            uploadDetail.del(comps);
        }
    }
}
