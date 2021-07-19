using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Révision
{
    class Program
    {
        static void Main(string[] args)
        {
            Character personnage = new Character("Spirit",100,999999,10000,5000,1000,1000);
            Player joueur = new Player("Yasuo",18,1800,2000,0,717,120);
            Enemy monstre = new Enemy("Baron Nashdor",0,0,40000,0,5000,600);

            Console.WriteLine(personnage);
            Console.WriteLine(joueur);
            Console.WriteLine(monstre);

            Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                joueur.Attack(monstre);
                Console.WriteLine(joueur.Name + " Attacked " + monstre.Name + " ! (" + (joueur.ATK-monstre.DEF) + " DMG delt)");
            }
            

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(joueur);
            Console.WriteLine(monstre);

            Console.ReadKey();
        }
    }
}
