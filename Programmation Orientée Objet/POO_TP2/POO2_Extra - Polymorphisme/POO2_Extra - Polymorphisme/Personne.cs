using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaClassePersonne
{
    class Personne
    {
        private string nom;
        private string prenom;
        private DateTime datenaissance;

        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public DateTime DateNaissance { get { return datenaissance; } set { datenaissance = value; } }

        public Personne() { }
        public Personne(string nom, string prenom, DateTime datenaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.datenaissance = datenaissance;
        }
        public Personne(Personne perso)
        {
            this.nom = perso.nom;
            this.prenom = perso.prenom;
            this.datenaissance = perso.datenaissance;
        }

        public virtual void Afficher()
        {
            Console.WriteLine("[Nom: " + nom + "] [Prénom: " + prenom + "] [Date de naissance: " + datenaissance.ToShortDateString()+"]");
        }
    }
}
