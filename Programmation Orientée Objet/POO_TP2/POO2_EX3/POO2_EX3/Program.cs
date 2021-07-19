using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Vecteurs";
            Console.WriteLine("====== Vecteurs dans le plan (Vecteurs 2D) et dans l'espace (Vecteurs 3D) ======\n");
            double x, y, z;

            Console.WriteLine("Vecteurs dans le plan (Vecteurs 2D) :");
            Vecteur2D[] V = new Vecteur2D[3];

            Console.WriteLine("\n\t1er Vecteur :");
            V[0] = new Vecteur2D();
            Console.WriteLine(V[0]);
            Console.WriteLine("Norme = " + V[0].Norme());

            Console.WriteLine("\n\t2ème Vecteur :");
            Console.Write("\tx = "); x = double.Parse(Console.ReadLine());
            Console.Write("\ty = "); y = double.Parse(Console.ReadLine());
            V[1] = new Vecteur2D(x, y);
            Console.WriteLine(V[1]);
            Console.WriteLine("Norme = " + V[1].Norme());

            Console.WriteLine("\n\t3ème Vecteur :");
            V[2] = new Vecteur2D(V[1]);
            Console.WriteLine(V[2]);
            Console.WriteLine("Norme = " + V[2].Norme());

            if (V[1].Equals(V[2]))
            {
                Console.WriteLine("\nLe 1er vecteur est Identique au 2ème vecteur!");
            }
            else
            {
                Console.WriteLine("\nLe 1er vecteur est Différent du 2ème vecteur.");
            }

            Console.WriteLine("\n\nVecteurs dans l'espace (Vecteurs 3D) :");
            Vecteur3D[] W = new Vecteur3D[3];

            Console.WriteLine("\n\t1er Vecteur :");
            W[0] = new Vecteur3D();
            Console.WriteLine(W[0]);
            Console.WriteLine("Norme = " + W[0].Norme());

            Console.WriteLine("\n\t2ème Vecteur :");
            Console.Write("\tx = "); x = double.Parse(Console.ReadLine());
            Console.Write("\ty = "); y = double.Parse(Console.ReadLine());
            Console.Write("\tz = "); z = double.Parse(Console.ReadLine());
            W[1] = new Vecteur3D(x, y, z);
            Console.WriteLine(W[1]);
            Console.WriteLine("Norme = " + W[1].Norme());

            Console.WriteLine("\n\t3ème Vecteur :");
            W[2] = new Vecteur3D(W[1]);
            Console.WriteLine(W[2]);
            Console.WriteLine("Norme = " + W[2].Norme());

            if (W[1].Equals(W[2]))
            {
                Console.WriteLine("\nLe 1er vecteur est Identique au 2ème vecteur!");
            }
            else
            {
                Console.WriteLine("\nLe 1er vecteur est Différent du 2ème vecteur.");
            }

            Console.WriteLine("\nNombre total de vecteurs construits : " + Vecteur2D.NombreVecteurs);
            Console.ReadKey();
        }
    }
}
