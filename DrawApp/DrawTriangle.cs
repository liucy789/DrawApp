using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class DrawTriangle : DrawingShape
    {
        private Pen pen;
        private int x;
        private int y;
        private int x1;
        private int y1;

        public DrawTriangle(Pen pen, int x, int y, int x1, int y1) {
            this.pen = pen;
            this.x = x;
            this.y = y;
            this.x1 = x1;
            this.y1 = y1;
        }

        public override void Draw(Graphics g) {
            g.DrawLine(pen, x, y, x + (x1 - x) / 2, y1);
            g.DrawLine(pen, x + (x1 - x) / 2, y1, x1, y);
            g.DrawLine(pen, x, y, x1, y);
            g.Save();
        }
    }
}
