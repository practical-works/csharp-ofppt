using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex5
{
    class Patron : Employe
    {
        private static double chiffreaffaire;
        private double pourcentage;

        public double Pourcentage
        {
            get { return pourcentage; }
            set { pourcentage = value; }
        }
        
        public static double ChiffreAffaire
        {
            get { return chiffreaffaire; }
            set { chiffreaffaire = value; }
        }

        public Patron() : base()
        {

        }
        public Patron(int matricule, string nom, string prenom, DateTime datenaissance, double pourcentage) 
            : base(matricule, nom, prenom, datenaissance)
        {
            this.pourcentage = pourcentage;
        }

        public override string ToString()
        {
            return base.ToString() + " / Chiffre d'affaire: " + chiffreaffaire +" / Pourcentage: " + pourcentage + "%";
        }

        public override double GetSalaire()
        {
            return Math.Round(chiffreaffaire * (pourcentage / 100) / 12, 2); //SalaireMensuel = SalaireAnnuel/12
        }
    }
}
