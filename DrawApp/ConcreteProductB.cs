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
        public override void Draw() { 
                          
        }
    }
}
