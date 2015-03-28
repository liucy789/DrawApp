﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Square : Shape
    {
        private int side;

        public override void SetDimensions(int x1, int y1) {
            if (x1 < X) {
                X ^= x1;
                x1 ^= X;
                X ^= x1;
            }
            if ((x1 - X) < (y1 - Y)) 
                this.side = x1 - X;
            else
                this.side = y1 - Y;
            if (y1 < Y) {
                Y ^= y1;
                y1 ^= Y;
                Y ^= y1;
                Y = Y + side;
            }
            

        }

        public override DrawingShape FactoryMethod() { return new DrawSquare(Pen, X, Y, side); }
    }
}
