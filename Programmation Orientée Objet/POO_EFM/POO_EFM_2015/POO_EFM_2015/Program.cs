using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_EFM_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "POO_EFM_2015 : Gestion des factures d'un magasin";

                Article Ordinateur = new Article(1, "i7-980Ti", 17990, "Informatique");
                ArticleEnSolde Souris = new ArticleEnSolde(2, "BS-GM-KULT1", 19.80, ArticleEnSolde.ListeCategories[0], 20);

                Achat AchatOrdinateur = new Achat();
                AchatOrdinateur.Numero = 10;
                AchatOrdinateur.ArticleAchete = Ordinateur;
                AchatOrdinateur.Quantite = 17;

                Achat AchatSouris = new Achat();
                AchatSouris.Numero = 11;
                AchatSouris.ArticleAchete = Souris;
                AchatSouris.Quantite = 27;

                Facture Commande = new Facture();
                Commande.Ajouter(AchatOrdinateur);
                Commande.Ajouter(AchatSouris);

                Console.WriteLine("\n");
                Console.WriteLine(Commande);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + ex.Message);
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
