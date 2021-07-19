using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex1
{
    class Point
    {
        private int x, y;
        public void setx(int x)
        {
            this.x = x;
        }
        public int getx()
        {
            return x;
        }
        public void sety(int y)
        {
            this.y = y;
        }
        public int gety()
        {
            return y;
        }
        public Point(int x=0, int y=0) 
        {
            this.x = x;
            this.y = y;
        }
        public double norme()
        {
            //R² = x² + y² => Norme = RC(R) = RC(x²+y²)
            return Math.Sqrt((x*x)+(y*y));
        }
    }
}
