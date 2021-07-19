using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Passage_2015
{
    class Habit : Article
    {
        private double taille;
        private string couleur;

        public double Taille
        {
            get { return taille; }
            set { if (value >= 0) taille = value; else throw new Exception("Taille doit être positive!"); }
        }
        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        public Habit() : base() { }
        public Habit(int Numero, double PrixHT, int Quantite, int QuantiteMIN, double Taille, string Couleur) 
            : base(Numero,PrixHT,Quantite,QuantiteMIN)
        {
            this.Taille = Taille;
            this.Couleur = Couleur;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTaille: " + Taille + " m, Couleur: " + Couleur;
        }
    }
}
