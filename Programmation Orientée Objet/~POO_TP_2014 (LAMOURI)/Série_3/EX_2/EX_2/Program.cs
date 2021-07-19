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
            Complexe a, b;
            a = new Complexe(3, 5);
            b = new Complexe(7);

            Console.WriteLine("La partie reéle de a est : "+a[0]);
            Console.WriteLine("La partie imaginaire de a est : " + a[1]);
            Console.WriteLine("Le module de a est  : " + a[2]);
            Console.WriteLine("\nLa partie reéle de b est : " + b[0]);
            Console.WriteLine("La partie imaginaire de b est : " + b[1]);
            Console.WriteLine("Le module de b est  : " + b[2]+"\n");
            Console.WriteLine("\na = "+a); 
            Console.WriteLine("\nb = "+b);
            Console.WriteLine("\na+b = " +(a+b));
            Console.WriteLine("\nb+3 = " + (b+3));
            Console.WriteLine("\na+8 = " + (a + 8));
            Console.WriteLine("\na-b = " + (a - b));
            Console.WriteLine("\nb*3 = " + (b * 3));
            Console.WriteLine("\na*8 = " + (a * 8));
            Console.WriteLine("\na*b = " + (a * b));
            Console.WriteLine("\nEst ce que a egale à b : " + (a == b));
            Console.WriteLine("\nEst ce que a différent de  b : " + (a == b));

            Console.WriteLine("\nLe nombre des compléxes est : " +Complexe.Nbre);





            Console.ReadKey();
        }
    }
}
