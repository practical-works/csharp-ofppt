using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P = new Point();
            Action<string> msgr = s => Console.WriteLine(s);
            Action<string> msg = s => Console.Write(s);
            //-------------------------------------------------
            msgr("Calcul de la norme d'un point dans le plan :");
            msg("Entrez l'abscisse (x) du point: "); P.setx(int.Parse(Console.ReadLine()));
            msg("Entrez l'ordonnée (y) du point: "); P.sety(int.Parse(Console.ReadLine()));
            msgr("La norme du point est: " + P.norme());
            
            Console.ReadKey();
        }
    }
}
