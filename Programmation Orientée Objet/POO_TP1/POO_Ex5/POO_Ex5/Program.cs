using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cercle C = new Cercle();
          //--------------------------------------------------------------------
            Action<string> msg = s => Console.Write(s);
         //--------------------------------------------------------------------
            msg("Caractéristiques d'un cercle\n\n");
            msg("Entrez les coordonnées (x,y) du point centre du cercle:\n");
            msg("\tx = "); C.Centre.X = double.Parse(Console.ReadLine());
            msg("\ty = "); C.Centre.Y = double.Parse(Console.ReadLine());
            msg("Entrez le rayon (R) du cercle:\n");
            msg("\tR = "); C.Rayon = double.Parse(Console.ReadLine());
        //---------------------------------------------------------------------
            msg("\nExpression représentative du cercle:\n\t");
            C.Afficher();
        //---------------------------------------------------------------------
            msg("\nPérimètre (P) du cercle:\n\t");
            msg("P = " + C.getPerimetre().ToString(".##"));
        //---------------------------------------------------------------------
            msg("\n\nSurface du (S) cercle:\n\t");
            msg("S = " + C.getSurface().ToString(".##"));
        //---------------------------------------------------------------------
            msg("\n\nVérifier si un point (M) de coordonnées (a,b) appartient au cercle:\n");
            Point M = new Point();
            msg("\ta = "); M.X = double.Parse(Console.ReadLine());
            msg("\tb = "); M.Y = double.Parse(Console.ReadLine());
            if (C.appartient(M))
            {
                msg("\nLe point (M) APPARTIENT au cercle.");
            }
            else
            {
                msg("\nLe point (M) N'appartient PAS au cercle.");
            }
        //---------------------------------------------------------------------   
            Console.ReadKey();
        }
    }
}
