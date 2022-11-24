using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionFarmersIrrigation
{
    public class PanelCornerRound:Panel
    {
        //Fields
        private int borderRadius = 30;


        //Constructor
        public PanelCornerRound()
        {
            this.Size = new Size(350, 200);
        }

        //Properties
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }

        //Methods
        private GraphicsPath GetPanelCornerPath(RectangleF rectangleF, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangleF.Width-radius, rectangleF.Height-radius,radius,radius,0,90);
            path.AddArc(rectangleF.X, rectangleF.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangleF.X, rectangleF.Y, radius, radius, 180, 90);
            path.AddArc(rectangleF.Width - radius, rectangleF.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        //Override
        protected override void OnPaint(PaintEventArgs eventArgs)
        {
            base.OnPaint(eventArgs);
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius>2)
            {
                using(GraphicsPath path = GetPanelCornerPath(rectangleF,borderRadius))
                using(Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    eventArgs.Graphics.DrawPath(pen, path);
                }
            }
            else
            {
                this.Region = new Region(rectangleF);
            }
        }
    }
}
