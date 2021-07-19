using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO3_Ex5
{
    class Eleve
    {
        private string nom;
        private int age;
        private double moyenne;

        public double Moyenne
        {
            get { return moyenne; }
            set { if (value >= 0 && value <= 20) moyenne = value; else throw new InvalidNoteException(); }
        }
        
        public int Age
        {
            get { return age; }
            set { if (value >= 18 && value <= 26) age = value; else throw new InvalidAgeException(); }
        }
        
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Eleve()
        {

        }
        public Eleve(string nom, int age, double moyenne)
        {
                Nom = nom;
                Age = age;
                Moyenne = moyenne;
        }

        public override string ToString()
        {
            return "Nom: " + nom + "| Age: " + age + " ans | Moyenne: " + moyenne;
        }
    }
}
