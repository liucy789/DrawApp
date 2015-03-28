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
        private int width;
        private int height;

        public override void SetDimensions(int x1, int y1) {
         /*   if (x1 < X)
                X ^= x1 ^= X ^= x1;
            if (y1 < Y)
                Y ^= y1 ^= Y ^= y1;
           
            this.width = X - x1;
            this.height = Y - y1;*/
            this.width = x1;
            this.height = y1;
        }

        public override DrawingShape FactoryMethod() { return new DrawRectangle(Pen, X, Y, width, height); }

    }
}
