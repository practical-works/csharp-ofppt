using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex2
{
    class CompteEpargne : CompteBancaire
    {
        private static int tauxinteret = 6;

        public static int TauxInteret
        {
            get { return tauxinteret; }
            set { tauxinteret = value; }
        }

        public CompteEpargne()
        {

        }
        public CompteEpargne(double solde) : base(solde)
        {

        }

        public void CalculInteret()
        {
            deposer((tauxinteret * solde) / 100);
        }

        public override string ToString()
        {
            return "[Compte épargne] " + base.ToString() + " ; Taux d'interêt: " + tauxinteret + " %";
        }
    }
}
