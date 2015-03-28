using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Ellipse : Shape
    {
        private int width;
        private int height;

        public override void SetDimensions(int x1, int y1) {
            if (x1 < X) {
                X ^= x1;
                x1 ^= X;
                X ^= x1;
            }
            if (y1 < Y) {
                Y ^= y1;
                y1 ^= Y;
                Y ^= y1;
            }
            this.width = x1 - X;
            this.height = y1 - Y;
        }

        public override DrawingShape FactoryMethod() { return new DrawEllipse(Pen, X, Y, width, height); }

    }
}
