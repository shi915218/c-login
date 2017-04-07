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
    public partial class UploadedItem : Panel
    {
        private UploadDetail uploadDetail;
        private FlowLayoutPanel uploadedItemContainer;
        public UploadInfoComps comps;

        public UploadedItem()
        {
            InitializeComponent();
        }

        public UploadedItem(UploadDetail uploadDetail, UploadItemVO obj)
        {
            this.uploadDetail = uploadDetail;
            this.uploadedItemContainer = uploadDetail.getUploadedItemContainer();
            InitializeComponent();

            comps = new UploadInfoComps();
            comps.vo = obj;
            init();
            addItems(obj);
            this.uploadedItemContainer.Controls.Add(this);
        }

        public UploadedItem(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void init()
        {
            Font = new Font("微软雅黑", 12, Font.Style);
            this.Width = this.uploadedItemContainer.Bounds.Width - 30;
            this.Height = 40;
            this.Margin = new Padding(0, 20, 0, 0);
        }

        public void addItems(UploadItemVO obj)
        {
            if (null == obj)
                return;

            Panel gb1 = new Panel();
            gb1.Width = 260;
            gb1.Height = 40;
            gb1.Left = 38;
            PictureBox filePic = new PictureBox();
            //filePic.Image = Image.FromFile(@"../../Resources/images/word.png");
            //filePic.Image = global::GovDocSearch.Properties.Resources.word_24;
            filePic.Image = UploadHelper.getImage(obj.fileExtension);
            filePic.SizeMode = PictureBoxSizeMode.StretchImage;
            filePic.Width = 40;
            filePic.Height = 40;
            Label fileName = new Label();
            fileName.Text = obj.fileName;
            fileName.Width = 200;
            fileName.Left = 50;
            Label fileSize = new Label();
            fileSize.Font = new Font("微软雅黑", 9, fileName.Font.Style);
            //fileSize.Text = obj.fileSize + "KB";
            fileSize.Text = Helper.ByteConvertGBMBKB(obj.fileSize);
            fileSize.Top = 25;
            fileSize.Left = 51;
            gb1.Controls.Add(filePic);
            gb1.Controls.Add(fileName);
            gb1.Controls.Add(fileSize);
            Controls.Add(gb1);
            Label endTime = new Label();
            endTime.Text = obj.endTime;
            endTime.Top = 5;
            endTime.Width = 200;
            endTime.Left = 295;
            Controls.Add(endTime);
            Label category = new Label();
            Dictionary<string, object> categoryObj = (Dictionary<string, object>)obj.category;
            if (null != categoryObj)
            {
                category.Text = categoryObj["name"].ToString();
            }
            category.Width = 150;
            category.Top = 5;
            category.Left = 542;
            Controls.Add(category);
            FlowLayoutPanel gb2 = new FlowLayoutPanel();
            gb2.Top = 5;
            gb2.Left = 727;
            gb2.Width = 24;
            //gb2.BorderStyle = BorderStyle.FixedSingle;
            PictureBox del = new PictureBox();
            del.Width = 18;
            del.Height = 18;
            //del.Image = Image.FromFile(@"../../Resources/images/del.png");
            del.Image = global::GovDocSearch.Properties.Resources.del;
            del.Cursor = Cursors.Hand;
            ToolTip delTip = new ToolTip();
            delTip.SetToolTip(del, "删除");
            del.MouseClick += OnDelMouseClick;
            gb2.Controls.Add(del);
            Controls.Add(gb2);
        }

        private void OnDelMouseClick(object sender, MouseEventArgs e)
        {
            this.uploadedItemContainer.Controls.Remove(this);
            uploadDetail.delSuccessItem(comps);
        }
    }
}
