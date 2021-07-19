using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture();
            v.C = carburant.Diesel;
            v.Puissance = 3;
            v.NombrePlace = 4;
            v.Reserve = 8;
            v.ReserveMax = 8.5;
            v.Distance = 120;

            Console.WriteLine(v);
           v.Deplacer(v.Distance);
           Voiture v1 = new Voiture();
           v1.C = carburant.Diesel;
           v1.Puissance = 2;
           v1.NombrePlace = 4;
           v1.Reserve = 5;
           v1.ReserveMax = 5.5;
           v1.Distance = 130;

           Console.WriteLine(v1);
           v.Deplacer(v1.Distance);
            Console.ReadKey();
        }
    }
}
