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
            int c = 1;
            string nom;
            double age; 
            double[] note=new double[3];
            CEléve ce = new CEléve();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            while (c != 6)
            {
                Console.WriteLine("\n1. Pour ajouter un eléve");
                Console.WriteLine("2. Pour rechercher un eléve");
                Console.WriteLine("3. Pour supprimer un eléve");
                Console.WriteLine("4. Pour effacer tous les eléves");
                Console.WriteLine("5. Pour afficher la liste des eléves");
                Console.WriteLine("6. Pour quitter le programme");
                Console.Write("\n   Entrez votre choix SVP : ");
                c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    double[] m = new double[3];
                    Console.Write("\nEntrez le nom SVP : ");
                    nom = Console.ReadLine();
                    Console.Write("Entrez l'age SVP : ");
                    age = double.Parse(Console.ReadLine());
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("Entre la note {0} : ",i+1);
                        m[i] = double.Parse(Console.ReadLine());
                    }
                    note = m;
                    ce.Add(nom,age,note);
                }

                else if (c == 2)
                {
                    string noom;bool a=false;
                    Console.Write("\nEntrez le nom à rechercher SVP : ");
                    noom = Console.ReadLine();

                    foreach (Elève e in ce)
                    {
                        if (e.Nom == noom)
                        {
                            a = true;
                            Console.WriteLine("Lindice est : {0}",ce.IndexOf(e)); 
                        }
                    }
                    if(a==false)
                        Console.Write("Ce nom à n'existe pas \n ");
                }

                
                
                else if (c == 3)
                {
                    string noom; bool a = false;
                    Console.Write("\nEntrez le nom à supprimer SVP : ");
                    noom = Console.ReadLine();

                    foreach (Elève e in ce)
                    {
                        if (e.Nom == noom)
                        {
                            a = true;
                            ce.Delete(ce.IndexOf(e));
                            break;
                        }
                    }
                    if (a == false)
                        Console.Write("Ce nom à n'existe pas \n ");

                    
                }
                else if (c == 4)
                {
                    ce.Clear();
                }
                else if (c == 5)
                {
                    foreach (Elève e in ce)
                        Console.WriteLine(e);
                }

            }
        }
    }
}
