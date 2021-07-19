using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionHôtel
{
    abstract class Personne
    {
        private string nom;
        private string prenom;
        private string adresse;

        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public string Adresse { get { return adresse; } set { adresse = value; } }

        public Personne()
        {

        }
        public Personne(string Nom, string Prenom, string Adresse)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
        }

        public override string ToString()
        {
            return "Nom/Prénom: " + Nom + " " + Prenom + ", Adresse: " + Adresse;
        }
    }
}
