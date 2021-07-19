using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionFichiers
{
    class Fichier : F_D
    {
        private int taille;
        private Dossier dossier;


        public Dossier DossierParent
        {
            get { return dossier; }
            set { dossier = value; }
        }
        
        public int Taille
        {
            get { return taille; }
            set { taille = value; }
        }

        public Fichier() : base()
        {

        }
        public Fichier(string Nom, int Taille, Dossier DossierParent) : base(Nom)
        {
            this.Taille = Taille;
            this.DossierParent = DossierParent;
        }

        public override string ToString()
        {
            return DossierParent + "\\" + Nom + " (" + Taille + " Ko)";
        }
    }
}
