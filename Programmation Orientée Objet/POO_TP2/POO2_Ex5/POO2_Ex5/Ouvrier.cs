using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex5
{
    class Ouvrier : Employe
    {
        private DateTime dateentree;
        private static double smig = 2500;

        public static double SMIG
        {
            get { return smig; }
        }
        
        public DateTime DateEntree
        {
            get { return dateentree; }
            set { dateentree = value; }
        }

        public Ouvrier() : base()
        {

        }
        public Ouvrier(int matricule, string nom, string prenom, DateTime datenaissance, DateTime dateentree) 
            : base(matricule,nom,prenom,datenaissance)
        {
            this.dateentree = dateentree;
        }

        public override string ToString()
        {
            return base.ToString() + " / Date d'entrée: " + dateentree.ToShortDateString();
        }

        public override double GetSalaire()
        {
            TimeSpan anciennete = DateTime.Today - dateentree;
            double salaire = smig + ((int)anciennete.Days/365) * 100; // 1_année = 365_jrs => x_années = x_jrs / 365
            if (salaire <= smig*2)
            {
                return salaire;
            }
            else
            {
                return smig * 2;
            }
        }
    }
}
