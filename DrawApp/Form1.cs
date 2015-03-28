using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Pen pen = new Pen(Color.FromArgb(69, 18, 123));
        int x;
        int y;
        int width;
        int height;
        Shape shape = new Rectangle();

        private void rectangle_radioBtn_CheckedChanged(object sender, EventArgs e) {
                shape = new Rectangle();
        }

        private void boxForDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (x == 0 || y == 0)
                {
                    x = e.X;
                    y = e.Y;
                }

                else
                {
                    //    w = Math.Abs(e.X - x);
                    //   h = Math.Abs(e.Y - y);
                    //   w = e.X - x;
                    //    h = e.Y - y;

                    width = e.X;
                    height = e.Y;

                }
                boxForDrawing.Refresh();

            }
        }

        private void boxForDrawing_MouseUp(object sender, MouseEventArgs e)
        {

            shape.SetPosition(x, y);
            shape.SetDimensions(width, height);

            Graphics g = Graphics.FromImage(boxForDrawing.Image);

            DrawingShape drawingShape = shape.FactoryMethod();
            drawingShape.Draw(g);

           /* g.DrawLine(pen, x, y, x + (width - x) / 2, height);
            g.DrawLine(pen, x + (width - x) / 2, height, width, y);
            g.DrawLine(pen, x, y, width, y);
            g.Save();*/
            x = 0;
            y = 0;
            width = 0;
            height = 0;
        }

        private void boxForDrawing_Paint(object sender, PaintEventArgs e)
        {
            shape.SetPosition(x, y);
            shape.SetDimensions(width, height);
            DrawingShape drawingShape = shape.FactoryMethod();
            drawingShape.Draw(e.Graphics);
        }

        private void line_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            shape = new Line();
        }
    }
}
