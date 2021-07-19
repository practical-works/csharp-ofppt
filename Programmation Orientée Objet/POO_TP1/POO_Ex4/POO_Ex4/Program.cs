using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Complexe Z = new Complexe(), A = new Complexe();
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.WriteLine("Nombres complexes"); Console.ResetColor();
            Z.SetComplexe();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nModule: " + Z.getModule().ToString());
            Console.ResetColor();
            choix:
            Console.Write("\n\t[1.Ajouter] [2.Soustraire] [Autre.Relancer] un nombre complexe ? \n\t\t * Choix: ");
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1: A.SetComplexe(); Console.WriteLine(""); Z.Afficher(); Console.Write(" + ");
                        A.Afficher() ; Console.Write(" = ");
                        Z.Plus(A).Afficher();
                        goto choix;
                case 2: A.SetComplexe(); Console.WriteLine(""); Z.Afficher(); Console.Write(" - ");
                        A.Afficher(); Console.Write(" = ");
                        Z.Moins(A).Afficher();
                        goto choix;
                default: Console.Clear(); goto start;
                       
            } 
            Console.ReadKey();
        }
    }
}
