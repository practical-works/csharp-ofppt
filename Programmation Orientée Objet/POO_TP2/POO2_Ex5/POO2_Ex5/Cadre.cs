using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex5
{
    class Cadre : Employe
    {
        private int indice;

        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }

        public Cadre() : base()
        {

        }
        public Cadre(int matricule, string nom, string prenom, DateTime datenaissance, int indice)
            : base(matricule, nom, prenom, datenaissance)
        {
            this.indice = indice;
        }

        public override string ToString()
        {
            return base.ToString() + " / Indice: " + indice;
        }

        public override double GetSalaire()
        {
            if (indice == 1) return Math.Round((double)13000 / 12 , 2); //SalaireMensuel = SalaireAnnuel/12
            else if (indice == 2) return Math.Round((double)150000 / 12 , 2);
            else if (indice == 3) return Math.Round((double)17000 / 12 , 2);
            else if (indice == 4) return Math.Round((double)20000 / 12 , 2);
            else return -1;
        }
    }
}
