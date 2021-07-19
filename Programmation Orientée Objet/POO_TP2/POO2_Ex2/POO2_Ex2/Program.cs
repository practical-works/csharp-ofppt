using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Comptes Bancaires";
            Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°° Gestion de comptes bancaires °°°°°°°°°°°°°°°°°°°°°°°°°");

            Console.ForegroundColor = ConsoleColor.Yellow;
            CompteBancaire C = new CompteBancaire();        Console.WriteLine("Compte bancaire C créé.");
            CompteEpargne CE = new CompteEpargne();         Console.WriteLine("Compte épargne CE créé.");
            ComptePayant CP = new ComptePayant();           Console.WriteLine("Compte payant CP créé.\n");
            Random S = new Random(); double m; int max=1000;

            Console.ForegroundColor = ConsoleColor.Cyan;
            m = S.Next(max);        C.deposer(m);           Console.WriteLine(m + " DH déposé en C.");
            m = S.Next(max);        CE.deposer(m);          Console.WriteLine(m + " DH déposé en CE.");
            m = S.Next(max);        CP.deposer(m);          Console.WriteLine(m + " DH déposé en CP.\n");
            m = S.Next(max);        C.retirer(m);           Console.WriteLine(m + " DH retiré de C.");
            m = S.Next(max);        CE.retirer(m);          Console.WriteLine(m + " DH retiré de CE.");
            m = S.Next(max);        CP.retirer(m);          Console.WriteLine(m + " DH retiré de CP.\n");
            CE.CalculInteret();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(C);
            Console.WriteLine(CE);
            Console.WriteLine(CP);
            Console.ReadKey();
        }
    }
}
