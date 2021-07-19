using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_4
{
    class Rectangle
    {
        protected double largeur, longueur;
        protected static int c = 0;

        public Rectangle()
        {
            largeur = 0;
            longueur = 0;
            c++;
        }
        public Rectangle(double largeur,double longueur)
        {
            this.largeur = largeur;
            this.longueur = longueur;
            c++;
        }
        public Rectangle(Rectangle r)
        {
            largeur = r.largeur;
            longueur = r.longueur;
            c++;
        }

        public double Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }
        public double Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }
        public static int C
        { get { return c; } }

        public override string ToString()
        {
            return "La largeur = " + largeur + "    La longueur = " + longueur;
        }
        public override bool Equals(object obj)
        {
            Rectangle r=(Rectangle)obj;
            return this.longueur==r.longueur&&this.largeur==r.largeur;
        }
        public double Périmetre()
        {
            return ((this.largeur + this.longueur) *2);
        }
        public double Surface()
        {
            return (this.largeur * this.longueur) ;
        }


    }
}
