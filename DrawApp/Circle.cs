﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Circle : Shape
    {
        private int radius;

        public override void SetDimensions(int x1, int y1)
        {
            if (x1 < X)
            {
                X ^= x1;
                x1 ^= X;
                X ^= x1;
            }
            if (y1 < Y)
            {
                Y ^= y1;
                y1 ^= Y;
                Y ^= y1;
            }
                this.radius = x1 - X;


        }

        public override DrawingShape FactoryMethod() { return new DrawCircle(Pen, X, Y, radius); }
    }
}
