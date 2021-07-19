using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaClassePersonne
{
    class Chef : Employe
    {
        private string service;

        public string Service { get { return service; } set { service = value; } }

        public Chef() : base() 
        { }
        public Chef(string nom, string prenom, DateTime datenaissance, double salaire, string service)
            : base(nom,prenom,datenaissance,salaire)
        {
            this.service = service;
        }
        public Chef(Chef chf) : base(chf)
        {
            this.service = chf.service;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Service: "+service);
        }
    }
}
