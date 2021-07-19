using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionFichiers
{
    class Dossier : F_D
    {
        private Dossier dossier;

        public Dossier DossierParent
        {
            get { return dossier; }
            set { dossier = value; }
        }

        public Dossier() : base()
        {

        }
        public Dossier(string Nom, Dossier DossierP) : base(Nom)
        {
            this.DossierParent = DossierP;
        }
        public override string ToString()
        {
            if (DossierParent != null) return DossierParent + "\\" + Nom;
            else return "";
        }
    }
}
