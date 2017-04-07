using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovDocSearch.cc.topware.form.comp
{
    public class MyProgressBar : ProgressBar
    {
        public MyProgressBar()
        {
            base.SetStyle(ControlStyles.UserPaint, true);
        }
        //重写OnPaint方法
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = null;           
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), bounds);
            bounds.Height -= 4;
            bounds.Width = ((int)(bounds.Width * (((double)base.Value) / ((double)base.Maximum)))) - 4;
            brush = new SolidBrush(this.ForeColor);
            e.Graphics.FillRectangle(brush, 2, 2, bounds.Width, bounds.Height);
            ControlPaint.DrawBorder(e.Graphics, bounds, Color.Transparent, ButtonBorderStyle.None);
        }
        //private static int WM_PAINT = 0x000F;
        protected override void OnResize(EventArgs e)
        {           
                this.Region = null;
                GraphicsPath FormPath;            
                FormPath = new GraphicsPath();
                Rectangle rect = new Rectangle(-1, 2, this.Width, this.Height-2);
                FormPath = GetRoundedRectPath(rect, 25);
                this.Region = new Region(FormPath);            
        }
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)

        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            //   左上角   

            path.AddArc(arcRect, 180, 90);

            //   右上角   

            arcRect.X = rect.Right - diameter;

            path.AddArc(arcRect, 270, 90);

            //   右下角   

            arcRect.Y = rect.Bottom - diameter-2;

            path.AddArc(arcRect, 0, 90);

            //   左下角   

            arcRect.X = rect.Left;

            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();

            return path;

        }       
    }
}