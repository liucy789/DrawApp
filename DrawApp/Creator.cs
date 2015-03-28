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

        public Pen Pen {
            get { return pen; }
            set { pen = value; }
        }

        public int X {
            get { return x; }
            set { x = value; }
        }

        public int Y {
            get { return y; }
            set { y = value; }
        }

        public void SetPosition(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public abstract void SetDimensions(int x1, int y1);

        public abstract DrawingShape FactoryMethod();
    }
}
