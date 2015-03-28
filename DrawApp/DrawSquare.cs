using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class DrawSquare : DrawingShape
    {
        private Pen pen;
        private int x;
        private int y;
        private int side;

        public DrawSquare(Pen pen, int x, int y, int side) {
            this.pen = pen;
            this.x = x;
            this.y = y;
            this.side = side;
        }

        public override void Draw(Graphics g) {
            g.DrawRectangle(pen, x, y, side, side);
            g.Save();
        }
    }
}
