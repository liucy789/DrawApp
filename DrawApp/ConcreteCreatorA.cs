using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Line : Shape
    {
        public override void SetDimensions(int x1, int y1)
        {
            throw new NotImplementedException();
        }
        public override DrawingShape FactoryMethod() { return new DrawLine(); }
    }
}
