using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1, r2, r3;string m,n;
            Parallélépipéde p1, p2, p3;

            r1 = new Rectangle();
            r1.Largeur = 4; r1.Longueur = 9.5;
            Console.WriteLine(r1.ToString());
            Console.WriteLine("La surface : " + r1.Surface()+"\n Le nombre de rectangle : "+Rectangle.C +"\n\n");
            r2 = new Rectangle(4, 6);
            Console.WriteLine(r2.ToString());
            Console.WriteLine("La surface : " + r2.Surface() + "\n Le nombre de rectangle : " + Rectangle.C+"\n\n");
            r3 = new Rectangle(r1);
            Console.WriteLine(r3.ToString());
            Console.WriteLine("La surface : " + r3.Surface() + "\n Le nombre de rectangle : " + Rectangle.C + "\n\n");
            if (r1.Equals(r2) == true)
                m = "le premier rectangle et le deuxiéme rectangle sont éguaux";
            else
            { m = m = "le premier rectangle et le deuxiéme rectangle sont différents"; }
            Console.WriteLine(m + "\n\n");

            p1 = new Parallélépipéde();
            p1.Largeur = 4; p1.Longueur = 9.5; p1.Hauteur = 10.6;
            Console.WriteLine(p1.ToString());
            Console.WriteLine("La surface : " + p1.Surface() + "\nLe volume : " + p1.Volume() + "\n\n");
            p2 = new Parallélépipéde(4, 6,5);
            Console.WriteLine(p2.ToString());
            Console.WriteLine("La surface : " + p2.Surface() + "\nLe volume : " + p2.Volume() + "\n\n");
            p3 = new Parallélépipéde(p1);
            Console.WriteLine(p3.ToString());
            Console.WriteLine("La surface : " + p3.Surface() + "\nLe volume : " + p3.Volume() + "\n Le nombre de parallélepipéde : " + Parallélépipéde.C + "\n\n");
            if (p1.Equals(p2) == true)
                n = "le premier parallélepipéde et le deuxiéme parallélepipéde sont éguaux";
            else
                n = "le premier parallélepipéde et le deuxiéme parallélepipéde sont différents";
            Console.WriteLine(n + "\n\n");

            Console.ReadKey();


       

               

            

        }
    }
}
