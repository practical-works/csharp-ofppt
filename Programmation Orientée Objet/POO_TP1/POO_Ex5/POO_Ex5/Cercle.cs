using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex5
{
    class Cercle
    {
        private Point centre;
        private double rayon;

        public double Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }
        
        public Point Centre
        {
            get { return centre; }
            set { centre = value; }
        }

        public Cercle(Point centre, double rayon=0)
        {
            this.centre = centre;
            this.rayon = rayon;
        }

        public Cercle()
        {
            centre = new Point();
            centre.X = 0;
            centre.Y = 0;
            rayon = 0;
        }

        public double getPerimetre()
        {
            return 2 * Math.PI * rayon;
        }
        public double getSurface()
        {
            return Math.PI * rayon * rayon;
        }
        public bool appartient(Point Pt)
        {
            if (Pt.Distance(centre) <= rayon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Afficher()
        {
            Console.WriteLine("CERCLE( ({0},{1}) , {2} )", centre.X,centre.Y,rayon);
        }
    }
}
