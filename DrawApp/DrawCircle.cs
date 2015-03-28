using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class DrawCircle : DrawingShape
    {
        private Pen pen;
        private int x;
        private int y;
        private int radius;

        public DrawCircle(Pen pen, int x, int y, int radius) {
            this.pen = pen;
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw(Graphics g) {
            g.DrawEllipse(pen, x, y, radius, radius);
            g.Save();
        }
    }
}
