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

        private void rectangle_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // an array of creators
            Shape[] shapes = { new Line(), new Rectangle() };
            // iterate over creators and create products
            foreach (Shape shape in shapes)
            {
                DrawingShape drawingShape = shape.FactoryMethod();
                Console.WriteLine("Created {0}", drawingShape.Draw());
            }
        }
    }
}
