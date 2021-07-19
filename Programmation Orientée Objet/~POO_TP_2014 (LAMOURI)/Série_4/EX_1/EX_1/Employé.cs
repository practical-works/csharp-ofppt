using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_1
{

    class Employé
    {
        private string nom;
        private int annéeDeNaissance, annéeDeRecrutement;
        private double salaire;

        public Employé(string nom, int annéeDeNaissance,int annéeDeRecrutement, double salaire)
        {
            this.nom = nom;
            this.annéeDeNaissance = annéeDeNaissance;
            this.annéeDeRecrutement = annéeDeRecrutement;
            this.salaire = salaire;
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int AnnéeDeNaissance
        {
            get { return annéeDeNaissance; }
            set { annéeDeNaissance = value; }
        }
        public int AnnéeDeRecrurement
        {
            get { return annéeDeRecrutement; }
            set { annéeDeRecrutement = value; }
        }
        public override string ToString()
        {
            return string.Format("\n  Le nom :  {0}    L'année de naissance : {1}    L'anné de recrutement : {2}    Le salaire : {3}", nom, annéeDeNaissance, annéeDeRecrutement, salaire);

        }
        public override bool Equals(object obj)
        {
            Employé e = obj as Employé;
            return nom == e.nom;
        }
             


    }
}
