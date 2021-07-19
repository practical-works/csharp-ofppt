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
            Vecteur2D v1, v2, v3;
            Vecteur3D w1, w2, w3;
            v1 = new Vecteur2D(1, 4);
            v2 = new Vecteur2D(8, 7);
            v3 = new Vecteur2D(4, 2);
           w1 = new Vecteur3D(6, 7,8);
            w2 = new Vecteur3D(8, 5, 7);
            w3 = new Vecteur3D(1, 4,3);
            Console.WriteLine(v1.Norme()+"\n\n");
            Console.WriteLine(v1.ToString() + "\n\n");
            Console.WriteLine(v2.Norme() + "\n\n");
            Console.WriteLine(v2.ToString() + "\n\n");
            Console.WriteLine(v3.Norme() + "\n\n");
            Console.WriteLine(v3.ToString() + "\n\n");
            Console.WriteLine("le nombre de vecteur2d est : {0}",Vecteur2D.C + "\n\n");
            Console.WriteLine(w1.Norme() + "\n\n");
            Console.WriteLine(w1.ToString() + "\n\n");
            Console.WriteLine(w2.Norme() + "\n\n");
            Console.WriteLine(w2.ToString() + "\n\n");
            Console.WriteLine(w3.Norme() + "\n\n");
            Console.WriteLine(w3.ToString() + "\n\n");
            Console.WriteLine("le nombre de vecteur3d est : "+Vecteur3D.C + "\n\n");
            Console.ReadKey();
            
            








           
         
         
        }
    }
}
