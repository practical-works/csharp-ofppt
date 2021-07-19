using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Véhicules";
            Console.WriteLine("============================= Gestion de Véhicules =============================");

            int annee;
            double prix;

            Console.WriteLine("Créer une voiture :");
            Console.Write("* Année de modèle : "); annee = int.Parse(Console.ReadLine());
            Console.Write("* Prix : "); prix = double.Parse(Console.ReadLine());
            Voiture V = new Voiture(annee, prix);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(V);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            V.Demarrer();
            V.Accelerer();

            Console.ResetColor();
            Console.WriteLine("");

            Console.WriteLine("Créer un camion :");
            Console.Write("* Année de modèle : "); annee = int.Parse(Console.ReadLine());
            Console.Write("* Prix : "); prix = double.Parse(Console.ReadLine());
            Camion C = new Camion(annee, prix);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(C);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            C.Demarrer();
            C.Accelerer();

            Console.ReadKey();
        }
    }
}
