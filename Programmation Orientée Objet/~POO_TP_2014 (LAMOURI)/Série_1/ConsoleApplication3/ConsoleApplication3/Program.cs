using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D a = new Point2D();
            Point2D b = new Point2D(8,6 );
            Point2D c = new Point2D(5, 9);
            Console.WriteLine(c.Distance(a));
            Console.ReadKey();


        }
    }
}
