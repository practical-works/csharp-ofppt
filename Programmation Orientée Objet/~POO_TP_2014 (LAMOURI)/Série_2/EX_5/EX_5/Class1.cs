using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_5
{
    class Cylindre : Disque
    {
        private double hauteur;
        private static int c = 0;

        public Cylindre()
            : base()
        {
            hauteur = 0;
            c++;
        }
        public Cylindre(double rayon,double hauteur)
            : base(rayon)
        {
            this.hauteur = hauteur;
            c++;
        }
        public Cylindre(Cylindre y)
            : base(y.rayon)
        {
            hauteur =y. hauteur;
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
            return "Le rayon : " + rayon + " / La hauteur : " + hauteur;
        }

        public  bool Eqauls(object obj)
        {
            Cylindre y = (Cylindre)obj;
            return this.rayon == y.rayon && this.hauteur == y.hauteur;
        }

        public override double Surface()
        {
            return ((rayon * 2 * 3.14) * hauteur) + (base.Surface() * 2);
        }



    }
}
