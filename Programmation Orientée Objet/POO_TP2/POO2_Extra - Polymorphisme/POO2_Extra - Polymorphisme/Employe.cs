using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaClassePersonne
{
    class Employe : Personne
    {
        private double salaire;

        public double Salaire { get { return salaire; } set { salaire = value; } }

        public Employe() : base() 
        { }
        public Employe(string nom, string prenom, DateTime datenaissance, double salaire)
            : base(nom, prenom, datenaissance)
        {
            this.salaire = salaire;
        }
        public Employe(Employe emp)
            : base(emp)
        {
            this.salaire = emp.salaire;
        }

        public override void Afficher()
        {
            base.Afficher(); 
            Console.WriteLine("Salaire: $" + salaire);
        }
    }
}
