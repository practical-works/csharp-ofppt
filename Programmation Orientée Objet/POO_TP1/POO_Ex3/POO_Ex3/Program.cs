using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Rectangle abcd = new Rectangle();
            Console.WriteLine("Caractéristiques d'un rectangle");
            Console.WriteLine("");
            Console.Write("Entrez la longueur: "); abcd.Longueur = double.Parse(Console.ReadLine());
            Console.Write("Entrez la largeur: "); abcd.Largeur = double.Parse(Console.ReadLine());
            abcd.AfficherRectangle();
            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
