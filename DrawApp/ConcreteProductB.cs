using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class DrawRectangle : DrawingShape
    {
        private Pen pen;
        private int x;
        private int y;
        private int width;
        private int height;

        public DrawRectangle(Pen pen, int x, int y, int width, int height) {
            this.pen = pen;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void Draw(Graphics g) {
            g.DrawLine(pen, x, y, x + (width - x) / 2, height);
            g.DrawLine(pen, x + (width - x) / 2, height, width, y);
            g.DrawLine(pen, x, y, width, y);
           // g.DrawRectangle(pen, 200, 200, 300, 300);

            //   e.Graphics.DrawLine(MyPen, x, y, x + (x - w), h);
            //   e.Graphics.DrawLine(MyPen, w, h, x + (x - w), h);
            g.Save();
        }
    }
}
