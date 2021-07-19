using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Carré c1, c2; Disque d1; Cylindre y1, y2;
            
            c1=new Carré(6);
            Console.WriteLine(c1.ToString());
            Console.WriteLine("La surface : "+c1.Surface());
            Console.WriteLine("Le nombre des carré : " + Carré.C+"\n\n");

            c2 = new Carré(5.5);
            Console.WriteLine(c2.ToString());
            Console.WriteLine("La surface : "+c2.Surface());
            Console.WriteLine("Le nombre des carré : " + Carré.C + "\n\n");

            d1 = new Disque(5);
            Console.WriteLine(d1.ToString());
            Console.WriteLine("La surface : " + d1.Surface());
            Console.WriteLine("Le nombre des disque : " + Disque.C + "\n\n");

            y1 = new Cylindre(6,3);
            Console.WriteLine("La surface : " + y1.ToString());
            Console.WriteLine(y1.Surface());
            Console.WriteLine("Le nombre des cylindres : " +Cylindre.C + "\n\n");

            y2 = new Cylindre(6, 3);
            Console.WriteLine(y2.ToString());
            Console.WriteLine("La surface : "+y2.Surface());
            Console.WriteLine("Le nombre des cylindres : " + Cylindre.C + "\n\n");
            Console.WriteLine( y2.Eqauls(y1));
            Console.ReadKey();

            





        }
    }
}
