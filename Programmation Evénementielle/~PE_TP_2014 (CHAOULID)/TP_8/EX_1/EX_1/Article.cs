using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_1
{
  [Serializable()] class Article
    {
        private int référence;
        private string nom;
        private double prixDeVente;
        private int quantité;

        public Article()
        {
            référence = 0;
            nom = "anonyme";
            prixDeVente = 0;
            quantité = 0;
        }
        public Article(int référence,string nom,double prixDeVente,int quantité)
        {
            this.référence = référence;
            this.nom = nom;
            this.prixDeVente = prixDeVente;
            this.quantité = quantité;
        }
        public Article(Article a)
        {
            référence = a.référence;
            nom = a.nom;
            prixDeVente = a.prixDeVente;
            quantité = a.quantité;
        }

        public int Référence
        {
            get { return référence; }
            set { référence = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public double PrixDeVente
        {
            get { return prixDeVente; }
            set { prixDeVente = value; }
        }
        public int Quantité
        {
            get { return quantité; }
            set { quantité = value; }
        }
        public override string ToString()
        {
            return "La référence : " + référence + "  Le nom : " + nom + "  Le prix de vente : " + prixDeVente + "  La quantité : " + quantité;
        }

        


    }
}
