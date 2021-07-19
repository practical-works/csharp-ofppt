using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_EX3
{
    class Vecteur2D
    {
        protected double x, y;
        private static int nombrevecteurs = 0;

        public static int NombreVecteurs
        {
            get { return nombrevecteurs; }
            set { nombrevecteurs = value; }
        }
        
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public Vecteur2D()
        {
            nombrevecteurs++;
        }
        public Vecteur2D(double x, double y)
        {
            nombrevecteurs++;
            this.x = x;
            this.y = y;
        }
        public Vecteur2D(Vecteur2D V)
        {
            nombrevecteurs++;
            this.x = V.x;
            this.y = V.y;
        }

        public override string ToString()
        {
            return "X = " + x + " - " + "Y = " + y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj == this)
            {
                return true;
            }
            else if (obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Vecteur2D V = (Vecteur2D)obj;
                if (this.x == V.x && this.y == V.y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public virtual double Norme()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
