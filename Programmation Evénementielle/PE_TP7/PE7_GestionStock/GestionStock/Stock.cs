using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionStock
{
    static class Stock
    {
        private static List<Article> stock = new List<Article>();

        static Stock()
        {
            //---------------POUR TEST-------------------
            stock.Add(new Article(1,"Clavier",100,279));
            stock.Add(new Article(2, "Souris", 50, 187));
            stock.Add(new Article(3, "Imprimente", 2000, 85));
            stock.Add(new Article(4, "Carte Graphique", 2500, 128));
            stock.Add(new Article(5, "Casque", 80, 625));
            //---------------POUR TEST-------------------
        }

        public static List<Article> Get()
        {
            return stock;
        }
        public static List<Article> Get(string MotCle)
        {
            return stock.FindAll(item => item.Nom.ToLower().Contains(MotCle.ToLower()));
        }

        public static int Rechercher(int Reference)
        {
            foreach (Article item in stock)
            {
                if (item.Reference == Reference)
                {
                    return stock.IndexOf(item);
                }
            }
            return -1;
        }

        public static void Ajouter(Article A)
        {
            stock.Add(A);
        }
        public static void Modifier(int Reference, Article B)
        {
            if (Stock.Rechercher(Reference) != -1)
            {
                Article A = stock.Find(item => item.Reference == Reference);
                A.Nom = B.Nom;
                A.PrixVente = B.PrixVente;
                A.Quantite = B.Quantite;
            }
        }

        public static void Supprimer(int Reference)
        {
            if (Stock.Rechercher(Reference) != -1)
            {
                stock.Remove(stock.Find(item => item.Reference == Reference));
            }
        }
        public static void Vider()
        {
            stock.Clear();
        }
    }
}
