using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex5
{
    abstract class Employe
    {
        private int matricule;
        private string nom;
        private string prenom;
        private DateTime datenaissance;

        public DateTime DateNaissance
        {
            get { return datenaissance; }
            set { datenaissance = value; }
        }
        
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        
        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public Employe(int matricule = 0, string nom = "", string prenom = "", DateTime datenaissance = new DateTime())
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.datenaissance = datenaissance;
        }

        public override string ToString()
        {
            return "Matricule: " + matricule + " / Nom: " + nom + " / Prénom: " + prenom 
                + " / Date de Naissance: " + datenaissance.ToShortDateString();
        }

        public abstract double GetSalaire();
    }
}
