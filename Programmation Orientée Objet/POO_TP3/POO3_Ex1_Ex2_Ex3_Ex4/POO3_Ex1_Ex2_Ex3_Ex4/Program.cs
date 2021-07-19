using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO3_Ex1_Ex2_Ex3_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            start :
            try
            {
                Console.Write("Entrez un entier: "); int n = int.Parse(Console.ReadLine());
                Console.Write("Entrer une date de naissance: "); DateTime d = DateTime.Parse(Console.ReadLine());
                if (d.Year <= DateTime.Today.Year-100) throw new Exception("Année de naissance impossible!");
                Console.Write("Entrez une date de départ: "); DateTime dd = DateTime.Parse(Console.ReadLine());
                Console.Write("Entrez une date d'arrivée: "); DateTime da = DateTime.Parse(Console.ReadLine());
                if (dd > da) throw new Exception("Erreur! La date de départ est supérieur à celle d'arrivée!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto start;
            }

            Console.ReadKey();
        }
    }
}
