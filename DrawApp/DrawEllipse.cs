using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class DrawEllipse : DrawingShape
    {
        private Pen pen;
        private int x;
        private int y;
        private int width;
        private int height;

        public DrawEllipse(Pen pen, int x, int y, int width, int height) {
            this.pen = pen;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g) {
            g.DrawEllipse(pen, x, y, width, height);
            g.Save();
        }
    }
}
