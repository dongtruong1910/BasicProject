using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject.Model
{
    internal class Point2D 
    {
        private int x, y;

        public Point2D() { }

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX { get { return x; } set { x = value; } }
        public int getY { get { return y; } set { y = value; } }


    }
}
