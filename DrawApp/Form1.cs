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
        public Form1() {
            InitializeComponent();
        }
        private Pen pen = new Pen(Color.FromArgb(69, 18, 123));
        int x;
        int y;
        int x1;
        int y1;
        Shape shape = new Rectangle();

        private void rectangle_radioBtn_CheckedChanged(object sender, EventArgs e) {
                shape = new Rectangle();
        }

        private void boxForDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                if (x == 0 || y == 0) {
                    x = e.X;
                    y = e.Y;
                }
                else {
                    x1 = e.X;
                    y1 = e.Y;
                }

                boxForDrawing.Refresh();
            }
        }

        private void boxForDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            shape.SetPosition(x, y);
            shape.SetDimensions(x1, y1);

            Graphics g = Graphics.FromImage(boxForDrawing.Image);
            DrawingShape drawingShape = shape.FactoryMethod();
            drawingShape.Draw(g);

            x = 0;
            y = 0;
            x1 = 0;
            y1 = 0;
        }

        private void boxForDrawing_Paint(object sender, PaintEventArgs e)
        {
            shape.SetPosition(x, y);
            shape.SetDimensions(x1, y1);
            DrawingShape drawingShape = shape.FactoryMethod();
            drawingShape.Draw(e.Graphics);
        }

        private void line_radioBtn_CheckedChanged(object sender, EventArgs e) {
            ColorDialog myDialog = new ColorDialog();
            if (myDialog.ShowDialog() == DialogResult.OK)
            shape = new Line();
            shape.Pen.Color = myDialog.Color;
        }

        private void square_radioBtn_CheckedChanged(object sender, EventArgs e) {
            shape = new Square();
        }

        private void circle_radioBtn_CheckedChanged(object sender, EventArgs e) {
            shape = new Circle();
        }

        private void ellipse_radioBtn_CheckedChanged(object sender, EventArgs e) {
            shape = new Ellipse();
        }

        private void triangle_radioBtn_CheckedChanged(object sender, EventArgs e) {
            shape = new Triangle();
        }
    }
}
