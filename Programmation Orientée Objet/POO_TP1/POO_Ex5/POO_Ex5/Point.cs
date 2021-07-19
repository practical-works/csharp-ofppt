using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex5
{
    class Point
    {
        private double x, y;

        public double Y
        {
            get { return  y; }
            set {  y = value; }
        }
        
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public Point(double x=0, double y=0 )
        {
            this.x = x;
            this.y = y;
        }
        public void Afficher()
        {
            Console.WriteLine("POINT({0},{1})", x,y);
        }
        public double Distance(Point origine)
        {
            double x0 = origine.x, y0 = origine.y;
            return Math.Sqrt(((x - x0) * (x - x0)) + ((y - y0) * (y - y0))); // Racine( (x-x0)² + (y-y0)² )

        }
    }
}
