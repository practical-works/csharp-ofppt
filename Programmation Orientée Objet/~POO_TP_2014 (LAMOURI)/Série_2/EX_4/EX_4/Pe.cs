using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_4
{
    class Parallélépipéde : Rectangle
    {
        private double hauteur;
        private static int c = 0;

        public Parallélépipéde()
            : base()
        {
            hauteur = 0;
            c++;
        }
        public Parallélépipéde(double largeur, double longueur, double hauteur)
            : base(largeur, longueur)
        {
            this.hauteur = hauteur;
            c++;
        }
        public Parallélépipéde(Parallélépipéde p)
            : base(p.largeur,p.longueur)
        {
            hauteur = p.hauteur;
            c++;
        }

        public double Hauteur
        {
            get { return hauteur; }
            set { hauteur = value; }
        }
        public new static int C
        {
            get { return c; }
        }

        public override string ToString()
        {
            return base.ToString() + "    La hauteur=" + hauteur;
        }
        public override bool Equals(object obj)
        {
            Parallélépipéde p=(Parallélépipéde)obj;
            return this.largeur == p.largeur && this.longueur == p.longueur && this.hauteur == p.hauteur;
        }
        public override double Surafce()
        {
            return base.Périmetre()* this.hauteur;
        }
        public double Volume()
        {
           return this.hauteur * base.Surface();
        }




        
        
    }
}
