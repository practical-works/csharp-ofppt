using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_4
{
    class Salarié
    {
        private string nom;
        private int annéeDeRecrutement;
        private double salaire;
        public Salarié(string nom, int annéeDeRecrutement, double salaire)
        {
            this.nom = nom;
            this.annéeDeRecrutement = annéeDeRecrutement;
            this.salaire = salaire;
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int AnnéeDeRecrutement
        {
            get { return annéeDeRecrutement; }
            set { annéeDeRecrutement = value; }
        }
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public override string ToString()
        {
            return "Le nom : " + nom + "   L'année de recrutement : " + annéeDeRecrutement + "   Le salaire : " + salaire;

        }
        public override bool Equals(object obj)
        {
            Salarié s = obj as Salarié;
            return nom == s.nom && annéeDeRecrutement == s.annéeDeRecrutement && salaire == s.salaire;
        }


    }
}
