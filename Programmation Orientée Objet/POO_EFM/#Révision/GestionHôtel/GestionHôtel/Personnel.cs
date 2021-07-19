using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionHôtel
{
    class Personnel : Personne
    {
        private string matricule;
        private string fonction;

        public string Matricule { get { return matricule; } set { matricule = value; } }
        public string Fonction { get { return fonction; } set { fonction = value; } }

        public Personnel() : base()
        {

        }
        public Personnel(string Matricule, string Nom, string Prenom, string Fonction, string Adresse)
            : base(Nom, Prenom, Adresse)
        {
            this.Matricule = Matricule;
            this.Fonction = Fonction;
        }

        public override string ToString()
        {
            return "MAT-" + Matricule + ", Fonction: " + Fonction + "\n" + base.ToString();
        }
    }
}
