using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GameUI
{
    public partial class Game : Form
    {
        private int size;
        public Game()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.Focus();
        }

        private void ControlPaint(object sender, PaintEventArgs e)
        {
            Map.GenerateMap("map.txt");

            var size =
                Math.Min(Control.Size.Width / Map.MapComponents[0].Length, Control.Size.Height / Map.MapComponents.Length);
            this.size = size;

            var currentCoordsHorizontal = new Point(0, 0);
            var currentCoordsVertical = new Point(0, 0);

            Character.Location = new Point(size * Map.characterCoordinates.X, size * Map.characterCoordinates.Y);
            Character.Size = new Size(size, size);

            foreach (var c in Map.MapComponents)
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (Map.TryMove(1, 0))
            {
                Character.Left += size;
                Control.Invalidate();
            }

        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (Map.TryMove(-1, 0))
            {
                Character.Left += size;
                Control.Invalidate();
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (Map.TryMove(0, 1))
            {
                Character.Left += size;
                Control.Invalidate();
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (Map.TryMove(0, -1))
            {
                Character.Left += size;
                Control.Invalidate();
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (Map.TryMove(0, -1))
                    {
                        Character.Top -= size;
                    }
                    break;
                case Keys.Down:
                    if (Map.TryMove(0, 1))
                    { 
                        Character.Top += size;
                    }
                    break;
                case Keys.Left:
                    if (Map.TryMove(-1, 0))
                    {
                        Character.Left -= size;
                    }
                    break;
                case Keys.Right:
                    if (Map.TryMove(1, 0))
                    {
                        Character.Left += size;
                    }
                    break;
            }

            Control.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus(); // Set focus to the form to ensure it receives key events
        }

        private void RightButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.IsInputKey = true;
                Character.Left += size;
            }
 
        }

        private void UpButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void LeftButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void DownButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
