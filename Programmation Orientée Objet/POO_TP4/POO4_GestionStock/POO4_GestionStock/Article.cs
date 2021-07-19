using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO4_GestionStock
{
    class Article
    {
        public int Numero { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }

        public Article()
        {

        }
        public Article(int Numero, string Nom, double Prix, int Quantite)
        {
            this.Numero = Numero;
            this.Nom = Nom;
            this.Prix = Prix;
            this.Quantite = Quantite;
        }

        public override string ToString()
        {
            return "N°" + Numero + " Nom: " + Nom + " .... Prix: " + Prix + " DH .... Quantité: " + Quantite + " Unité(s).";
        }
    }
}
