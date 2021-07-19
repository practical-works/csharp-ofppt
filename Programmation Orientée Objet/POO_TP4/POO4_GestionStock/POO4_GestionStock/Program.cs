using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO4_GestionStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gestion de Stock";

            List<Article> Stock = new List<Article>();

            Stock.Add(new Article(17,"Clavier",55,7));
            Stock.Add(new Article(18, "Souris", 30, 10));
            Stock.Add(new Article(19, "Haut-parleurs", 60, 12));
            Stock.Add(new Article(20, "Moniteur", 120, 11));
            Stock.Add(new Article(21, "Clé USB", 50, 27));

            int Numero, Quantite, index;
            string Nom;
            double Prix;

            Menu:
            Console.WriteLine(">-----------------------------< Gestion de stock >-----------------------------<");
            Console.WriteLine("STOCK : " + Stock.Count + " articles.\n");
            Console.WriteLine("1. Rechercher un article par numéro");
            Console.WriteLine("2. Ajouter un article");
            Console.WriteLine("3. Supprimer un article");
            Console.WriteLine("4. Modifier un article");
            Console.WriteLine("5. Rechercher un article par nom.");
            Console.WriteLine("6. Rechercher un article par intervalle de prix");
            Console.WriteLine("7. Afficher tous les articles");
            Console.WriteLine("8. Quitter");
            Console.Write("\n* Choix: ");
            int choix = int.Parse(Console.ReadLine());
            
            switch (choix)
            {
                case 1: 
                    Console.Write("Entrez le numéro de l'article à rechercher: ");
                    Numero = int.Parse(Console.ReadLine());
                    index = Stock.FindIndex(A => A.Numero == Numero);
                    if (index == -1) Console.WriteLine("Article introuvable!");
                    else Console.WriteLine(Stock[index]);
                    break; 
                case 2:
                    Console.WriteLine("Nouveau article:");
                    Numero:
                    Console.Write("Entrez le numéro: "); 
                    Numero = int.Parse(Console.ReadLine());
                    bool NumeroExiste = Stock.Exists(A => A.Numero == Numero);
                    if (NumeroExiste)
                    {
                        Console.WriteLine("Un article du même numéro existe déjà!");
                        goto Numero;
                    }
                    Console.Write("Entrez le nom: ");
                    Nom = Console.ReadLine();
                    Console.Write("Entrez le prix: ");
                    Prix = double.Parse(Console.ReadLine());
                    Console.Write("Entrez la quantité: ");
                    Quantite = int.Parse(Console.ReadLine());
                    Stock.Add(new Article(Numero, Nom, Prix, Quantite));
                    break;
                case 3:
                    Console.Write("Entrez le numéro de l'article à supprimer: ");
                    Numero = int.Parse(Console.ReadLine());
                    index = Stock.FindIndex(A => A.Numero == Numero);
                    if (index == -1) Console.WriteLine("Article introuvable!");
                    else Stock.RemoveAt(index); Console.WriteLine("Article supprimé.");
                    break;
                case 4: 
                    Console.Write("Entrez le numéro de l'article à modifier: ");
                    Numero = int.Parse(Console.ReadLine());
                    index = Stock.FindIndex(A => A.Numero == Numero);
                    if (index == -1) Console.WriteLine("Article introuvable!");
                    else
                    {
                        Console.Write("Entrez le nouveau nom: ");
                        Stock[index].Nom = Console.ReadLine();
                        Console.Write("Entrez le nouveau prix: ");
                        Stock[index].Prix = double.Parse(Console.ReadLine());
                        Console.Write("Entrez la nouvelle quantité: ");
                        Stock[index].Quantite = int.Parse(Console.ReadLine());
                    }
                    break;
                case 5 :
                    Console.Write("Entrez le nom de l'article à rechercher: ");
                    Nom = Console.ReadLine();
                    List<Article> ArticlesNom = Stock.FindAll(A => A.Nom.Contains(Nom));
                    if (ArticlesNom.Count == 0) Console.WriteLine("Article introuvable!");
                    else
                    {
                        foreach (Article A in ArticlesNom) Console.WriteLine(A);
                    }
                    break;
                case 6:
                    Console.WriteLine("Entrez l'intervalle de prix de l'article à rechercher: ");
                    Prix:
                    Console.Write("Prix minimal: ");
                    double PrixMin = double.Parse(Console.ReadLine());
                    Console.Write("Prix maximal: ");
                    double PrixMax = double.Parse(Console.ReadLine());
                    if (PrixMin > PrixMax)
                    {
                        Console.WriteLine("Le prix minimal doit être inférieur au prix maximal!");
                        goto Prix;
                    }
                    List<Article> ArticlesPrix = Stock.FindAll(A => A.Prix >= PrixMin && A.Prix <= PrixMax);
                    if (ArticlesPrix.Count == 0) Console.WriteLine("Article introuvable!");
                    else
                    {
                        foreach (Article A in ArticlesPrix) Console.WriteLine(A);
                    }
                    break;
                case 7:
                    Console.WriteLine("Liste des articles en stock:");
                    foreach (Article A in Stock)
                    {
                        Console.WriteLine(A);
                    }
                    break;
                case 8:
                    //Environment.Exit(0);
                    return;
                default: Console.WriteLine("Choix invalide!");
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            goto Menu;
        }
    }
}
