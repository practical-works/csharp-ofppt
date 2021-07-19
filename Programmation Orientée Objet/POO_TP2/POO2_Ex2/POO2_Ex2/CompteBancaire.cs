using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex2
{
    class CompteBancaire
    {
        protected double solde;
        private int code;
        private static int nombrecomptes = 0;

        public static int NombreComptes
        {
            get { return nombrecomptes; }
        }
        
        public int Code
        {
            get { return code; }
        }
        
        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }

        public CompteBancaire()
        {
            nombrecomptes++;
            code = nombrecomptes;
        }
        public CompteBancaire(double solde)
        {
            nombrecomptes++;
            code = nombrecomptes;
            this.solde = solde;
        }

        public virtual void deposer(double montant)
        {
            solde += montant;
        }
        public virtual void retirer(double montant)
        {
            solde -= montant;
        }

        public override string ToString()
        {
            return "Code: " + code + " ; Solde: " + solde;
        }
    }
}
