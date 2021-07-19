using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaClassePersonne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 40);

            Personne[] P = new Personne[8];
            P[0] = new Employe("Mustapha","Mohamed",DateTime.Parse("1991 12 30"),5000);
            P[1] = new Employe("Ali", "Ibrahim", DateTime.Parse("1981 7 28"), 4000);
            P[2] = new Employe("Nariman", "Nouhaila", DateTime.Parse("1989 1 5"), 3000);
            P[3] = new Employe("Ait Ahmed", "Fatima Ezzahra", DateTime.Parse("1992 6 4"), 5000);
            P[4] = new Employe("Nabil", "Said", DateTime.Parse("1993 9 22"), 2500);
            P[5] = new Chef("Essadiq", "Nouâman", DateTime.Parse("1980 10 7"), 8000, "Marketing");
            P[6] = new Chef("Ben Hadi", "Zineb", DateTime.Parse("1981 12 3"), 7000, "Communication");
            P[7] = new Directeur("El hafid", "Kenza", DateTime.Parse("1980 11 1"), 70000000, "Science","ARG Universal");

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < P.Length; i++)
            {
                P[i].Afficher();
                Console.WriteLine("-----------------------------------------------------------------------------");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Personne p in P)
            {
                p.Afficher();
                Console.WriteLine("-----------------------------------------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
