using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
       
       
        static void Main(string[] args)
        { 
            double[] t;
            t = new double[3];
            int i;
            Eleve e1 = new Eleve();
            Eleve e2 = new Eleve();
            Console.Write("entrez le nom :");
            e2.Nom = Console.ReadLine();
            Console.Write("entrez le prénom :");
            e2.Prénom = Console.ReadLine();
            for (i = 0; i < 3; i++)
            {
                Console.Write("entrez la note {0}", i+1+" :");
                t[i] = double.Parse(Console.ReadLine());
            }
            e2.Note = t;
            Eleve e3 = new Eleve(e2);
            e3.Nom="El allami";
            Console.Write("\n\n");
            Console.WriteLine(e1.Nom); Console.WriteLine(e1.Prénom); Console.WriteLine(e1.Moyenne());
            Console.WriteLine("______________________");
            Console.WriteLine(e2.Nom); Console.WriteLine(e2.Prénom); Console.WriteLine(e2.Moyenne());
            Console.WriteLine("______________________");
            Console.WriteLine(e3.Nom); Console.WriteLine(e3.Prénom); Console.WriteLine(e3.Moyenne());

            Console.ReadKey();

            


           





        }
    }
}
