using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_3
{
    class Exemplaire : Film
    {
        private int n_exemplaire;
        private string support, date_achat;
        private static int c=0;

        public Exemplaire()
            : base()
        {
            n_exemplaire = 0;
            support = "CD";
            date_achat = "anonyme";
            c++;
        }
        public Exemplaire(string code, string titre, string date, string genre, string langue, int n_exemplaire, string support, string date_achat)
            : base(code, titre, date, genre, langue)
        {
            this.n_exemplaire = n_exemplaire;
            this.support = support;
            this.date_achat = date_achat;
            c++;
        }
        public Exemplaire (Exemplaire e):base(e.code,e.titre,e.date,e.genre,e.langue)
        {
            n_exemplaire = e.n_exemplaire;
            support = e.support;
            date_achat = e.date_achat;
            c++;
        }

        public int N_exemplaire
        {
            get { return n_exemplaire; }
            set { n_exemplaire = value; }
        }
        public string Support 
        {
            get { return support; }
            set { support = value; }
        }
        public string  Date_achat
        {
            get { return date_achat; }
            set { date_achat = value; }
        }
        public new static int C
        {
            get { return c; }
        }

        public new string ToString()
        {
           return base.ToString() + "\nLe N°exemplaire : " + n_exemplaire + "\nLe support : " + support + "\nLa date d'achat : " + date_achat;
        }
        public new bool Equals(object obj)
        {
            Exemplaire e = (Exemplaire)obj;
            return this.n_exemplaire == e.n_exemplaire;
        }


    }
}
