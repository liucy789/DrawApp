using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    abstract class Shape
    {
        private Pen pen = new Pen(Color.FromArgb(69, 18, 123));
        private int x;
        private int y;

        public Shape(Pen pen, int x, int y)
        {
            this.pen = pen;
            this.x = x;
            this.y = y;
        }

        public abstract DrawingShape FactoryMethod();
    }
}
