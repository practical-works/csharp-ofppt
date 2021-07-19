using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Commande c = new Commande();
            
            Console.Write("entrez le code de l'article : ");
            c.Code = int.Parse(Console.ReadLine()); 
            Console.Write("entrez le nombre d'article : ");
            c.NombreArticle = int.Parse(Console.ReadLine());
             Console.Write("entrez la référence d'article :");
             c.A.Référence = (Console.ReadLine());
             Console.Write("entrez l'intitulé d'article : ");
             c.A.Intitulé = (Console.ReadLine());
             Console.Write("entrez le prix unitaire d'article : ");
             c.A.PrixUnitaire = double.Parse(Console.ReadLine());


             Console.WriteLine("\n\n");
             Console.WriteLine("le code est : {0}",c.Code);
             Console.WriteLine("le nombre d'article est : {0}",c.NombreArticle);
             Console.WriteLine("le prix unitaire est :{0}",c.A.PrixUnitaire);
             Console.WriteLine("le mantant est :{0}", c.Mantant(c.NombreArticle,c.A. PrixUnitaire));
             Console.ReadKey();


            
        }
    }
}
