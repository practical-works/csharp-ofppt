using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_1
{
    class Vecteur2D
    {
        protected double x, y;
        protected static int c = 0;

        public Vecteur2D()
        {
            x = 0;
            y = 0;
            c++;
        }
        public Vecteur2D(double x,double y)
        {
            this.x = x;
            this.y = y;
            c++;
        }
        public Vecteur2D(Vecteur2D v)
        {
            x = v.x;
            y = v.y;
            c++;
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public static int C
        {
            get { return c; }
        }
        
        public new string ToString()
        {
           return "X="+x+"  Y="+y;
        }
        public new bool Equals(object obj)
        {
            Vecteur2D v=(Vecteur2D)obj;
            return this.x == v.x && this.y == v.y;
        }
        public double Norme()
        {
            return Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
        }
    }

        



    }


