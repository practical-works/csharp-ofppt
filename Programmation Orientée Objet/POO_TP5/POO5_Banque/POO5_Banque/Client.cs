using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO5_Banque
{
    class Client
    {
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }

        public Client()
        {

        }
        public Client(string CIN, string Nom, string Prenom, string Adresse)
        {
            this.CIN = CIN;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
        }

        public override string ToString()
        {
            return "\tCIN: " + CIN + "\n\tNom complet: " + Nom + " " + Prenom + "\n\tAdresse: " + Adresse;
        }
    }
}
