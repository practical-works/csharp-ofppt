using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_5
{
    class Carré : FormeGeometrique
    {
        private double arrètte;
        private static int c = 0;

        public Carré()
            : base()
        {
            arrètte = 0;
            c++;
        }
        public Carré(double arrètte)
            : base()
        {
            this.arrètte = arrètte;
            c++;
        }
        public Carré(Carré a)
            : base()
        {
            arrètte = a.arrètte;
            c++;
        }

        public double Arrètte
        {
            get { return arrètte; }
            set { arrètte = value; }
        }
        public new static int C
        {
            get { return c; }
        }

        public new string ToString()
        {
            return "L'arrètte = " + arrètte;
        }

        public override bool Equals(object obj)
        {
            Carré a = (Carré)obj;
            return this.arrètte == a.arrètte;
        }
        public override double Surface()
        {
            return arrètte * arrètte;
        }





    }
}
