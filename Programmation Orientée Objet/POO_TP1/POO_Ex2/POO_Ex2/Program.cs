using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> msgr = s => Console.WriteLine(s);
            Action<string> msg = s => Console.Write(s);
            //-------------------------------------------------
            Livre kitabi = new Livre();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            msgr("~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Informations d'un livre ~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.Gray;
            msg("Entrez titre: "); kitabi.set_titre(Console.ReadLine());
            msg("Entrez auteur: "); kitabi.set_auteur(Console.ReadLine());
            msg("Entrez prix: "); kitabi.set_prix(double.Parse(Console.ReadLine()));
            msgr("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            kitabi.afficher();

            Console.ReadKey();
        }
    }
}
