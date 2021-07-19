using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_5
{
    class Disque :  FormeGeometrique 
    {
        protected double rayon;
        private static int c = 0;

        public Disque()
            : base()
        {
            rayon = 0;
            c++;
        }
        public Disque(double rayon)
            : base()
        {
            this.rayon = rayon;
            c++;
        }
        public Disque(Disque d)
            : base()
        {
            rayon = d.rayon;
            c++;
        }

        public double Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }
        public new static int C
        {
            get { return c; }
        }

        public override string ToString()
        {
            return "Le rayon = " + rayon;
        }

        public override bool Equals(object obj)
        {
            Disque d = (Disque)obj;
            return this.rayon == d.rayon;
        }

        public override double Surface()
        {
            return rayon * rayon * Math.PI;
        }
        





    }
}
