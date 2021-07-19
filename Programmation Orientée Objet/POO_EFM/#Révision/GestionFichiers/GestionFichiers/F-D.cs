using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionFichiers
{
    abstract class F_D
    {
        private string nom;
        private Catégorie cat;
        private Propriétaire prop;
        
        public string Nom { get { return nom; } set { nom = value; } }
        public Catégorie Categorie { get { return cat; } set { cat = value; } }
        public Propriétaire Proprietaire { get { return prop; } set { prop = value; } }

        public F_D()
        {

        }
        public F_D(string Nom)
        {
            this.Nom = Nom;
        }

        public override string ToString()
        {
            return Categorie + " > " + Nom  + "[" + Proprietaire + "]";
        }
    }
}
