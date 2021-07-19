using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionFichiers
{
    class Catégorie
    {
        string nomCat;
        Catégorie categorie;

        public string Nom { get { return nomCat; } set { nomCat = value; } }
        public Catégorie Categorie { get { return categorie; } set { categorie = value; } }

        public Catégorie()
        {

        }
        public Catégorie(string Nom, Catégorie Categorie)
        {
            nomCat = Nom;
            this.Categorie = Categorie;
        }

        public override string ToString()
        {
            return Categorie + " > " + Nom;
        }
    }
}
