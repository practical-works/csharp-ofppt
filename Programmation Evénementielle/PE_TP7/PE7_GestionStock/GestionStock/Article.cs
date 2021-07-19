using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionStock
{
    class Article
    {
        public int Reference { get; set; }
        public string Nom { get; set; }
        public double PrixVente { get; set; }
        public int Quantite { get; set; }

        public Article() { }
        public Article(int Reference, string Nom, double PrixVente, int Quantite)
        {
            this.Reference = Reference;
            this.Nom = Nom;
            this.PrixVente = PrixVente;
            this.Quantite = Quantite;
        }
    }
}
