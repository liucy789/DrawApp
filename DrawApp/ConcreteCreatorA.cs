using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Line : Shape
    {
        protected int x1;
        protected int y1;

        public override void SetDimensions(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }

        public override DrawingShape FactoryMethod() { return new DrawLine(Pen, X, Y, x1, y1); }
    }
}
