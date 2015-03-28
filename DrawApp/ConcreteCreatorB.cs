using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Rectangle : Shape
    {
        protected int width;
        protected int height;

        public Rectangle(Pen pen, int x, int y, int width, int height)
            :base(pen, x, y)
        {
            this.width = width;
            this.height = height;
        }
        public override DrawingShape FactoryMethod() { return new DrawRectangle(); }

    }
}
