using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovDocSearch.cc.topware.form.comp
{
    public partial class Messagebox : Form
    {        

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);

        [DllImport("Shell32.dll")]
        public extern static int ExtractIconEx(string libName, int iconIndex, IntPtr[] largeIcon, IntPtr[] smallIcon, int nIcons);

        static private IntPtr[] largeIcon;
        static private IntPtr[] smallIcon;

        static private Messagebox newMessageBox;
        static private Label frmTitle;
        static private Label frmMessage;
        static private PictureBox pIcon;
        static private FlowLayoutPanel flpButtons;
        static private TableLayoutPanel tlpMessagePanel;
        static private TableLayoutPanel tlp;
        static private Icon frmIcon;

        static private Button btnOK;
        static private Button btnAbort;
        static private Button btnRetry;
        static private Button btnIgnore;
        static private Button btnCancel;
        static private Button btnYes;
        static private Button btnNo;

        static private DialogResult CYReturnButton;

        public enum MyIcon
        {
            Error,
            Explorer,
            Find,
            Information,
            Mail,
            Media,
            Print,
            Question,
            RecycleBinEmpty,
            RecycleBinFull,
            Stop,
            User,
            Warning
        }

        public enum MyButtons
        {
            AbortRetryIgnore,
            OK,
            OKCancel,
            RetryCancel,
            YesNo,
            YesNoCancel
        }

        static private void BuildMessageBox(string title)
        {
            newMessageBox = new Messagebox();
            newMessageBox.Text = title;
            newMessageBox.Size = new Size(350, 160);
            newMessageBox.StartPosition = FormStartPosition.CenterScreen;
            newMessageBox.FormBorderStyle = FormBorderStyle.None;
            newMessageBox.Paint += new PaintEventHandler(newMessageBox_Paint);
            newMessageBox.BackColor = Color.Blue;             
            newMessageBox.MouseMove += new MouseEventHandler(newMessageBox_MouseMove);
           
            frmTitle = new Label();
            frmTitle.Size = new Size(350,30);
            frmTitle.Padding = new Padding(0, 5, 0, 5);
            frmTitle.BackColor = Color.Blue;
            frmTitle.ForeColor = Color.White;
            frmTitle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            frmTitle.Location = new Point(0, 0);
            newMessageBox.Controls.Add(frmTitle);
            frmTitle.MouseMove += new MouseEventHandler(frmTitle_MouseMove);

            frmMessage = new Label();
            frmMessage.Dock = DockStyle.Fill;
            frmMessage.BackColor = Color.White;
            frmMessage.Font = new Font("Tahoma", 16, FontStyle.Regular);
            //frmMessage.Location = new Point(50, 40);

            tlp = new TableLayoutPanel();
            tlp.RowCount = 2;
            tlp.ColumnCount = 1;
            //tlp.Dock = DockStyle.Fill;           
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
            tlp.BackColor = Color.White;
            tlp.Padding = new Padding(2, 2, 2, 2);
            tlp.Size = new Size(350, 130);
            tlp.Location = new Point(0,30);

            largeIcon = new IntPtr[250];
            smallIcon = new IntPtr[250];
            pIcon = new PictureBox();
            ExtractIconEx("shell32.dll", 0, largeIcon, smallIcon, 250);
           


            flpButtons = new FlowLayoutPanel();
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Padding = new Padding(0, 5, 5, 0);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.BackColor = Color.White;

            tlpMessagePanel = new TableLayoutPanel();
            tlpMessagePanel.BackColor = Color.White;
            tlpMessagePanel.Dock = DockStyle.Fill;
            tlpMessagePanel.ColumnCount = 2;
            tlpMessagePanel.RowCount = 1;
            tlpMessagePanel.Padding = new Padding(4, 5, 4, 4);
            tlpMessagePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            tlpMessagePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMessagePanel.Controls.Add(pIcon);
            tlpMessagePanel.Controls.Add(frmMessage);
            tlpMessagePanel.Location = new Point(0,60);

            tlp.Controls.Add(tlpMessagePanel);
            tlp.Controls.Add(flpButtons);
            newMessageBox.Controls.Add(tlp);           
        }

        /// <summary>
        /// Message: Text to display in the message box.
        /// </summary>
        static public DialogResult Show(string Message)
        {
            BuildMessageBox("");
            frmMessage.Text = Message;
            ShowOKButton();
            newMessageBox.ShowDialog();
            return CYReturnButton;
        }

        /// <summary>
        /// Title: Text to display in the title bar of the messagebox.
        /// </summary>
        static public DialogResult Show(string Message, string Title)
        {
            BuildMessageBox(Title);
            frmTitle.Text = Title;
            frmMessage.Text = Message;
            ShowOKButton();
            newMessageBox.ShowDialog();
            return CYReturnButton;
        }

        /// <summary>
        /// MButtons: Display MyButtons on the message box.
        /// </summary>
        static public DialogResult Show(string Message, string Title, MyButtons MButtons)
        {
            BuildMessageBox(Title); // BuildMessageBox method, responsible for creating the MessageBox
            frmTitle.Text = Title; // Set the title of the MessageBox
            frmMessage.Text = Message; //Set the text of the MessageBox
            ButtonStatements(MButtons); // ButtonStatements method is responsible for showing the appropreiate buttons
            newMessageBox.ShowDialog(); // Show the MessageBox as a Dialog.
            return CYReturnButton; // Return the button click as an Enumerator
        }

        /// <summary>
        /// MIcon: Display MyIcon on the message box.
        /// </summary>
        static public DialogResult Show(string Message, string Title, MyButtons MButtons, MyIcon MIcon)
        {
            BuildMessageBox(Title);
            frmTitle.Text = Title;
            frmMessage.Text = Message;
            ButtonStatements(MButtons);
            IconStatements(MIcon);
            Image imageIcon = new Bitmap(frmIcon.ToBitmap(), 38, 38);
            pIcon.Image = imageIcon;
            newMessageBox.ShowDialog();
            return CYReturnButton;
        }

        static void btnOK_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.OK;
            newMessageBox.Dispose();
        }

        static void btnAbort_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.Abort;
            newMessageBox.Dispose();
        }

        static void btnRetry_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.Retry;
            newMessageBox.Dispose();
        }

        static void btnIgnore_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.Ignore;
            newMessageBox.Dispose();
        }

        static void btnCancel_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.Cancel;
            newMessageBox.Dispose();
        }

        static void btnYes_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.Yes;
            newMessageBox.Dispose();
        }

        static void btnNo_Click(object sender, EventArgs e)
        {
            CYReturnButton = DialogResult.No;
            newMessageBox.Dispose();
        }

        static private void ShowOKButton()
        {
            btnOK = new Button();
            btnOK.Text = "确定";
            btnOK.Size = new Size(118, 32);
            btnOK.BackColor = Color.FromArgb(0, 140, 238);
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(134)));
            btnOK.ForeColor = Color.White;
            btnOK.Cursor = Cursors.Hand;
            btnOK.Click += new EventHandler(btnOK_Click);
            flpButtons.Controls.Add(btnOK);
        }

        static private void ShowAbortButton()
        {
            btnAbort = new Button();
            btnAbort.Text = "Abort";
            btnAbort.Size = new Size(118, 32);
            btnAbort.BackColor = Color.FromArgb(255, 255, 255);
            btnAbort.Font = new Font("Tahoma", 8, FontStyle.Regular);
            btnAbort.Click += new EventHandler(btnAbort_Click);
            flpButtons.Controls.Add(btnAbort);
        }

        static private void ShowRetryButton()
        {
            btnRetry = new Button();
            btnRetry.Text = "Retry";
            btnRetry.Size = new Size(118, 32);
            btnRetry.BackColor = Color.FromArgb(255, 255, 255);
            btnRetry.Font = new Font("Tahoma", 8, FontStyle.Regular);
            btnRetry.Click += new EventHandler(btnRetry_Click);
            flpButtons.Controls.Add(btnRetry);
        }

        static private void ShowIgnoreButton()
        {
            btnIgnore = new Button();
            btnIgnore.Text = "Ignore";
            btnIgnore.Size = new Size(118, 32);
            btnIgnore.BackColor = Color.FromArgb(255, 255, 255);
            btnIgnore.Font = new Font("Tahoma", 8, FontStyle.Regular);
            btnIgnore.Click += new EventHandler(btnIgnore_Click);
            flpButtons.Controls.Add(btnIgnore);
        }

        static private void ShowCancelButton()
        {
            btnCancel = new Button();
            btnCancel.Text = "取消";
            btnCancel.Size = new Size(118, 32);
            btnCancel.BackColor = Color.FromArgb(255, 255, 255);
            btnCancel.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(134)));
            btnCancel.Click += new EventHandler(btnCancel_Click);
            flpButtons.Controls.Add(btnCancel);
        }

        static private void ShowYesButton()
        {
            btnYes = new Button();
            btnYes.Text = "Yes";
            btnYes.Size = new Size(80, 25);
            btnYes.BackColor = Color.FromArgb(255, 255, 255);
            btnYes.Font = new Font("Tahoma", 8, FontStyle.Regular);
            btnYes.Click += new EventHandler(btnYes_Click);
            flpButtons.Controls.Add(btnYes);
        }

        static private void ShowNoButton()
        {
            btnNo = new Button();
            btnNo.Text = "No";
            btnNo.Size = new Size(80, 25);
            btnNo.BackColor = Color.FromArgb(255, 255, 255);
            btnNo.Font = new Font("Tahoma", 8, FontStyle.Regular);
            btnNo.Click += new EventHandler(btnNo_Click);
            flpButtons.Controls.Add(btnNo);
        }

        static private void ButtonStatements(MyButtons MButtons)
        {
            if (MButtons == MyButtons.AbortRetryIgnore)
            {
                ShowIgnoreButton();
                ShowRetryButton();
                ShowAbortButton();
            }

            if (MButtons == MyButtons.OK)
            {
                ShowOKButton();
            }

            if (MButtons == MyButtons.OKCancel)
            {
                ShowCancelButton();
                ShowOKButton();
            }

            if (MButtons == MyButtons.RetryCancel)
            {
                ShowCancelButton();
                ShowRetryButton();
            }

            if (MButtons == MyButtons.YesNo)
            {
                ShowNoButton();
                ShowYesButton();
            }

            if (MButtons == MyButtons.YesNoCancel)
            {
                ShowCancelButton();
                ShowNoButton();
                ShowYesButton();
            }
        }

        static private void IconStatements(MyIcon MIcon)
        {
            if (MIcon == MyIcon.Error)
            {
                MessageBeep(30);
                frmIcon = Icon.FromHandle(largeIcon[109]);
            }

            if (MIcon == MyIcon.Explorer)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[220]);
            }

            if (MIcon == MyIcon.Find)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[22]);
            }

            if (MIcon == MyIcon.Information)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[221]);
            }

            if (MIcon == MyIcon.Mail)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[156]);
            }

            if (MIcon == MyIcon.Media)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[116]);
            }

            if (MIcon == MyIcon.Print)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[136]);
            }

            if (MIcon == MyIcon.Question)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[23]);
            }

            if (MIcon == MyIcon.RecycleBinEmpty)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[31]);
            }

            if (MIcon == MyIcon.RecycleBinFull)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[32]);
            }

            if (MIcon == MyIcon.Stop)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[27]);
            }

            if (MIcon == MyIcon.User)
            {
                MessageBeep(0);
                frmIcon = Icon.FromHandle(largeIcon[170]);
            }

            if (MIcon == MyIcon.Warning)
            {
                MessageBeep(30);
                frmIcon = Icon.FromHandle(largeIcon[217]);
            }
        }

        static void newMessageBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle frmTitleL = new Rectangle(0, 0, (newMessageBox.Width / 2), 22);
            Rectangle frmTitleR = new Rectangle((newMessageBox.Width / 2), 0, (newMessageBox.Width / 2), 22);
            Rectangle frmMessageBox = new Rectangle(0, 0, (newMessageBox.Width - 1), (newMessageBox.Height - 1));
            LinearGradientBrush frmLGBL = new LinearGradientBrush(frmTitleL, Color.FromArgb(87, 148, 160), Color.FromArgb(209, 230, 243), LinearGradientMode.Horizontal);
            LinearGradientBrush frmLGBR = new LinearGradientBrush(frmTitleR, Color.FromArgb(209, 230, 243), Color.FromArgb(87, 148, 160), LinearGradientMode.Horizontal);
            // Pen frmPen = new Pen(Color.FromArgb(63, 119, 143), 0);
            g.FillRectangle(frmLGBL, frmTitleL);
            g.FillRectangle(frmLGBR, frmTitleR);
            // g.DrawRectangle(frmPen, frmMessageBox);
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            //ShowDialog对话框返回的结果是OK
            this.DialogResult = DialogResult.OK;
           this.Close();
        }
      private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //ShowDialog对话框返回的结果是Cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        static public void newMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(newMessageBox.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        static public void frmTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(newMessageBox.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
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
                return cp;
            }
        }
        #endregion
    }
}
