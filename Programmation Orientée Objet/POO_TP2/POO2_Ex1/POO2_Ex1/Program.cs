using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************** Maison : Bâtiment **************************\n");
            Batiment building = new Batiment("Rue A, N°7, SYBA, Marrakech");
            Console.WriteLine(building);
            Maison house = new Maison("Avenue B, N°10, AS, Casablanca", 17);
            Console.WriteLine(house);
            Console.WriteLine("créer une maison :");
            Console.Write("\tEntrez une adresse: "); string adresse = Console.ReadLine();
            Console.Write("\tEntrez un nombre de pièces: "); int NbPieces = int.Parse(Console.ReadLine());
            Maison custom_house = new Maison(adresse, NbPieces);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(custom_house);
            Console.ReadKey();
        }
    }
}
