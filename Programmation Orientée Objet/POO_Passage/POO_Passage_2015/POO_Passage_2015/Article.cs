using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Passage_2015
{
    class Article
    {
        private int numero;
        private double prix_ht;
        private int quantite;
        private int quantite_min;

        public int Numero
        {
            get { return numero; }
            set { if (value > 0) numero = value; else throw new Exception("Numéro doit être strictement positif!"); }
        }
        public double PrixHT
        {
            get { return prix_ht; }
            set { if (value >= 0) prix_ht = value; else throw new Exception("PrixHt doit être positif"); }
        }
        public int Quantite
        {
            get { return quantite; }
            set { if (value >= 0) quantite = value; else throw new Exception("Quantité doit être positive!"); }
        }
        public int QuantiteMIN
        {
            get { return quantite_min; }
            set { if (value >= 0) quantite_min = value; else throw new Exception("QuantitéMIN doit être positive!"); }
        }

        public Article() { }
        public Article(int Numero, double PrixHT, int Quantite, int QuantiteMIN)
        {
            this.Numero = Numero;
            this.PrixHT = PrixHT;
            this.Quantite = Quantite;
            this.QuantiteMIN = QuantiteMIN;
        }

        public override string ToString()
        {
            return "Numéro: " + Numero + ", Prix HT: " + PrixHT 
                + " DH, Quantité: " + Quantite + ", Quantité MIN: " + QuantiteMIN;
        }

        public void Approvisionner(int Quantite)
        {
            if (Quantite >= 0)
            {
                this.Quantite += Quantite;
                Console.WriteLine("Quantité de " + Quantite + " unités ajoutées au stock.");
            }
            else
            {
                throw new Exception("Quantité à ajouter doit être positif!");
            }            
        }

        public void Achat(int Quantite)
        {
            if (Quantite >= 0)
            {
                if (this.Quantite >= Quantite)
                {
                    this.Quantite -= Quantite;
                    if (this.Quantite < this.QuantiteMIN)
                    {
                        Console.WriteLine("Quantité restante au stock inférieure à la minimale!");
                    }
                    Console.WriteLine("Quantité de " + Quantite + " unités  retirées du stock.");
                }
                else
                {
                    throw new Exception("Quantité demandéee supérieure à celle disponible!");
                }
            }
            else
            {
                throw new Exception("Quantité à retirer doit être positif!");
            }           
        }
    }
}
