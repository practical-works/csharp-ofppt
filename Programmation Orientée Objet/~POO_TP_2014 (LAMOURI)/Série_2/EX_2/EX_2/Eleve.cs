using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
    class Eleve : Personne
    {
        private string niveau;
        private double moyenne;
        private static int c = 0;

        public Eleve()
            : base()
        {
            niveau = "anonyme";
            moyenne=0;
            c++;
        }
        public Eleve(int code, string nom, string prénom, int age, string niveau,double moyenne)
            : base(code, nom, prénom, age)
        {
            this.niveau =niveau ;
            this.moyenne = moyenne;
            c++;
        }
        public Eleve(Eleve e)
            : base(e.Code, e.Nom, e.Prénom, e.Age)
        {
            e.niveau = niveau;
            e.moyenne = moyenne;
            c++;
        }

        public string Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }
        public double Moyenne
        {
            get { return moyenne; }
            set { moyenne = value; }
        }
        public static int C
        {
            get { return c; }
        }

        public new string ToString()
        {
            return "\nLe niveau :" + niveau + "\nla moyenne : " + moyenne;

        }
        public new bool Equals(object obj)
        {
            Eleve e = (Eleve)obj;
            return this.Code == e.Code;
        }

    }
}
