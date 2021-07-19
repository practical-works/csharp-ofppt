using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex7
{
    class Article
    {
        private int référence;
        private string désignation;
        private double prixHT;
        private static double tauxTVA = 0; //constante partagée au niveau de la classe Article

        public static double TauxTVA
        {
            get { return tauxTVA; }
            set { tauxTVA = value; }
        }
        
        public double PrixHT
        {
            get { return prixHT; }
            set { prixHT = value; }
        }
        

        public string Désignation
        {
            get { return désignation; }
            set { désignation = value; }
        }
        
        public int Référence
        {
            get { return référence; }
            set { référence = value; }
        }

        public Article(int référence=0, string désignation="", double prixHT=0)
        {
            this.référence = référence;
            this.désignation = désignation;
            this.prixHT = prixHT;
        }
        public Article(int référence, string désignation)
        {
            this.référence = référence;
            this.désignation = désignation;
        }
        public Article(Article article)
        {
            référence = article.référence;
            désignation = article.désignation;
            prixHT = article.prixHT;
        }
        public double CalculerPrixTTC() //PrixTTC = PrixHT + (PrixHT*TauxTVA/100)
        {
            return prixHT + (prixHT * tauxTVA / 100);
        }
        public void AfficherArticle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tRéférence: " + référence);
            Console.WriteLine("\tDésignation: " + désignation);
            Console.WriteLine("\tPrix HT: "+ prixHT);
            Console.WriteLine("\tLe Prix TTC est: " + CalculerPrixTTC());
            Console.ResetColor();
        }

    }
}
