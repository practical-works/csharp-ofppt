using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employé e1, e2, e3;
            Eleve l1, l2, l3;

            e1 = new Employé(1, "Bla", "Fadma", 20, "Général de cord d'armée");
            e2 = new Employé(2, " 3abbas", "Tikwando", 19, "Commandant");
            e3 = new Employé(3, " bakha", "stankovic", 23, "Colonel majeur");

            l1 = new Eleve(1, "Activia", "ayoub", 20, "TDI 1", 17.5);
            l2 = new Eleve(2, "salimi", "Ahmad", 24, "TDI 1", 15);
            l3 = new Eleve(3, "Ikrami", "Hanane", 19, "TDI 1", 14.5);

            Console.WriteLine(e1.ToString() + "\n\n");
            Console.WriteLine(e2.ToString() + "\n\n");
            Console.WriteLine(e3.ToString() + "\n\n");
            Console.WriteLine("\n\n\n");
            Console.WriteLine(l1.ToString() + "\n\n");
            Console.WriteLine(l2.ToString() + "\n\n");
            Console.WriteLine(l3.ToString() + "\n\n");
            Console.WriteLine(Employé.C);
            Console.WriteLine(e1.Equals(e2));
            Console.ReadKey();


        }
    }
}
