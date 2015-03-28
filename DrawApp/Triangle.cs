﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Triangle : Line
    {
        public override DrawingShape FactoryMethod() { return new DrawTriangle(Pen, X, Y, x1, y1); }
    }
}
