using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex2
{
    class Livre
    {
        private string titre, auteur;
        private double prix;

        Action<string> msgr = s => Console.WriteLine(s);
        Action<string> msg = s => Console.Write(s);
        public Livre(string titre="", string auteur="", double prix=0)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.prix = prix;
        }
        public void afficher()
        {
            msgr( "\tNom du livre : " + titre
                + "\n\tAuteur : " + auteur
                + "\n\tPrix : " + prix );
        }

        public void set_titre(string titre)
        {
            this.titre = titre;
        }

        public void set_auteur(string auteur)
        {
            this.auteur = auteur;
        }
        
        public void set_prix(double prix)
        {
            this.prix = prix;
        }
    }

}
