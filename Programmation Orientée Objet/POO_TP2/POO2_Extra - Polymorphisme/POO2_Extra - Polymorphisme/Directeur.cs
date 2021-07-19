using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaClassePersonne
{
    class Directeur : Chef
    {
        private string societe;

        public string Societe { get { return societe; } set { societe = value; } }

        public Directeur() : base()
        {
        }
        public Directeur(string nom, string prenom, DateTime datenaissance, double salaire, string service, string societe)
            : base(nom,prenom,datenaissance,salaire,service)
        {
            this.societe = societe;
        }
        public Directeur(Directeur direct)
            : base(direct)
        {
            this.societe = direct.societe;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Société: "+societe);
        }
    }
}
