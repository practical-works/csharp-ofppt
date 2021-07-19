using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Point2D
    {
        private double abscisse, ordonné;
        public Point2D()
        {
            this.abscisse = 0;
            this.ordonné = 0;
        }
        public Point2D(double abscisse ,double ordonné)
        {
            this.abscisse = abscisse;
            this.ordonné = ordonné;
        }
        public Point2D(Point2D p)
        {
            this.abscisse =p.abscisse;
            this.ordonné = p.ordonné ;
        }
        public double Abscisse
        {
            get { return abscisse; }
            set { abscisse = value; }
        }
        public double Ordonné
        {
            get { return ordonné; }
            set { ordonné = value; }
        }
        public double Distance(Point2D m)
        {
            double a, b, d;

            a = Math.Pow(((m.abscisse) - (abscisse)), 2);
            b = Math.Pow(((m.ordonné) - (ordonné)), 2);
            d = Math.Sqrt(a + b);
            return d;
        }
        public double Norme()
        {
            return Distance(new Point2D());//le constructeur par defauts met 0 dans l'abss et l'ordonn (l'origine)


        }
           

    }
}
