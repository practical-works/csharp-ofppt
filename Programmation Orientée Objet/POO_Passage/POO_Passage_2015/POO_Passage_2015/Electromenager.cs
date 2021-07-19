using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Passage_2015
{
    class Electromenager : Article
    {
        private double poids;
        private int duree_garantie;

        public double Poids
        {
            get { return poids; }
            set { if (value >= 0) poids = value; else throw new Exception("Poids doit être positif!"); }
        }    
        public int DureeGarantie
        {
            get { return duree_garantie; }
            set { if (value >= 0) duree_garantie = value; else throw new Exception("Durée doit être positif!"); }
        }

        public Electromenager() : base() {}
        public Electromenager(int Numero, double PrixHT, int Quantite, int QuantiteMIN, double Poids, int DureeGarantie) 
            : base(Numero,PrixHT,Quantite,QuantiteMIN)
	    {
            this.Poids = Poids;
            this.DureeGarantie = DureeGarantie;
	    }

        public override string ToString()
        {
            return base.ToString() + "\nPoids: " + Poids + ", Durée Guarantie: " + DureeGarantie
                + " mois, Date Fin Guarantie: " +  DateFinGuarantie().ToShortDateString();
        }

        public DateTime DateFinGuarantie()
        {
            return DateTime.Today.AddMonths(DureeGarantie);
        }
    }
}
