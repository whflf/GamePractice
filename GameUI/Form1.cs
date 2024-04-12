using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GameUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void 

        private void ControlPaint(object sender, PaintEventArgs e)
        {
            var map = new Map("map.txt");

            var size =
                Math.Min(Control.Size.Width / map.MapComponents[0].Length, Control.Size.Height / map.MapComponents.Length);

            var currentCoordsHorizontal = new Point(0, 0);
            var currentCoordsVertical = new Point(0, 0);

            foreach (var c in map.MapComponents)
            {
                foreach (var c2 in c)
                {
                    if (c2 != ' ')
                    {
                        var rect = new Rectangle(currentCoordsHorizontal.X, currentCoordsHorizontal.Y, size, size);
                        var brush = new SolidBrush(Color.Pink);
                        e.Graphics.FillRectangle(brush, rect);
                    }

                    currentCoordsHorizontal.X += size;
                }

                currentCoordsVertical.Y += size;
                currentCoordsHorizontal = new Point(0, currentCoordsVertical.Y);
            }
        }

        private void ControlResize(object sender, EventArgs e)
        {
            Control.Invalidate();
        }
    }
}
