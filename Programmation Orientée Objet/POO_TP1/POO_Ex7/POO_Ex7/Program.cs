using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Articles en Vente";
            start:
            Console.Clear();
            Action<string> msg = s => Console.Write(s);
            Action<string> msgl = s => Console.WriteLine(s);

            Article[] item = new Article[4];
            msgl("[ Articles en Vente ]\n");
            msg("Donner le taux de TVA pour tous les articles (%): "); Article.TauxTVA = double.Parse(Console.ReadLine());
            msgl("Le taux TVA est " + Article.TauxTVA + "%");

            msgl("\nArticle 1:");
            item[0] = new Article();
            item[0].AfficherArticle();

            msgl("\nArticle 2:");
            int REF; string DES; double HT;
            msg("Donner la référence: "); REF = int.Parse(Console.ReadLine());
            msg("Donner la désignation: "); DES = Console.ReadLine();
            msg("Donner le prix HT: "); HT = double.Parse(Console.ReadLine());
            item[1] = new Article(REF,DES,HT);
            item[1].AfficherArticle();

            msgl("\nArticle 3:");
            msg("Donner la référence: "); REF = int.Parse(Console.ReadLine());
            msg("Donner la désignation: "); DES = Console.ReadLine();
            item[2] = new Article(REF, DES);
            item[2].AfficherArticle();

            msgl("\nArticle 4 (Copie de Article 2):");
            item[3] = new Article(item[1]);
            item[3].AfficherArticle();

            Console.ReadKey();
            goto start;
        }
    }
}
