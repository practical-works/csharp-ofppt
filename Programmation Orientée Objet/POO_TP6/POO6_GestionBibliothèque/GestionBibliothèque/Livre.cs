using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBibliothèque
{
    class Livre : Ouvrage
    {
        private string auteur;
        private string editeur;

        public string Auteur { get { return auteur; } }
        public string Editeur { get { return editeur; } }

        public Livre() : base()
        {

        }
        public Livre(string Titre, string Auteur, string Editeur) : base(Titre)
        {
            auteur = Auteur;
            editeur = Editeur;
        }

        public override void Emprunter()
        {
            nbr_emprunt++;
            etat = false;
            Console.WriteLine("le livre " + titre + " a été emprunté avec succès");
        }
        public override void Retourner()
        {
            etat = true;
            Console.WriteLine("le livre " + titre + " a été retourné avec succès");
        }

        public override string ToString()
        {
            return base.ToString() + "\nAuteur: " + auteur + ", Editeur: " + editeur + ".";
        }
    }
}
