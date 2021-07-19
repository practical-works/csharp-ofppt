using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Passage_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gestion des ventes d'un magasin";
            try
            {
                Console.WriteLine("\n[ Tricot ]");
                Habit Tricot = new Habit(1, 25, 0, 10, 1.75, "Bleu");
                Tricot.Approvisionner(100);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Tricot);
                Console.ResetColor();

                Console.WriteLine("\n[ Réfrigérateur ]");
                Electromenager Refrigerateur = new Electromenager(2, 4000, 5, 5, 100, 3);
                Refrigerateur.Achat(4);
                Console.WriteLine("Date de fin de garantie: " + Refrigerateur.DateFinGuarantie().ToLongDateString());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Refrigerateur);
                Console.ResetColor();
            }
            catch (Exception EXC)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(EXC.Message);
                Console.ResetColor();
            }

            Console.ReadLine();
        }
    }
}
