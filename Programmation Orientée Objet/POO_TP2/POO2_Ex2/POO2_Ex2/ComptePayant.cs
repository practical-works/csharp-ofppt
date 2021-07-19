using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex2
{
    class ComptePayant : CompteBancaire
    {
        public ComptePayant()
        {

        }
        public ComptePayant(double solde) : base(solde)
        {

        }

        public override void deposer(double montant)
        {
            base.deposer(montant);
            base.retirer(5);
        }
        public override void retirer(double montant)
        {
            base.retirer(montant);
            base.retirer(5);
        }

        public override string ToString()
        {
            return "[Compte payant] " + base.ToString();
        }
    }
}
