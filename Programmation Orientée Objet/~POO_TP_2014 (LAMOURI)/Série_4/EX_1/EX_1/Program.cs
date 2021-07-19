using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace EX_1
{
    
    class Program
    {

        static void Main(string[] args)
        {
            int c=1;
            string nom;
            int annéeDeNaissance,annéeDeRecrurement;
            double salaire;

            ArrayList l = new ArrayList();
            
            while(c!=6)
            {
               Console.WriteLine("\n1. Pour ajouter un employé");
               Console.WriteLine("2. Pour rechercher un employé");
               Console.WriteLine("3. Pour supprimer un employé");
               Console.WriteLine("4. Pour effacer tous les employés");
               Console.WriteLine("5. Pour afficher la liste des employés");
               Console.WriteLine("6. Pour quitter le programme");
               Console.Write("\n   Entrez votre choix SVP : ");
                c=int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    Console.Write("\nEntrez le nom SVP : ");
                    nom = Console.ReadLine();
                    Console.Write("Entrez la date de naissance SVP : ");
                    annéeDeNaissance =int .Parse (Console.ReadLine());
                    Console.Write("Entrez la date de recrutement SVP : ");
                    annéeDeRecrurement =int.Parse(Console.ReadLine());
                    Console.Write("Entrez le salaire SVP : ");
                    salaire = double.Parse(Console.ReadLine());

                    l.Add(new Employé(nom, annéeDeNaissance, annéeDeRecrurement, salaire));
                }

                else if (c == 2)
                {
                    int a;
                    Console.WriteLine("Entrez les information de l'employé à rechercher");
                    Console.Write(" le nom : ");
                    nom = Console.ReadLine();
                    Console.Write("la date de naissance : ");
                    annéeDeNaissance = int.Parse(Console.ReadLine());
                    Console.Write("la date de recrutement : ");
                    annéeDeRecrurement = int.Parse(Console.ReadLine());
                    Console.Write("Entrez le salaire : ");
                    salaire = double.Parse(Console.ReadLine());
                    a = l.IndexOf(new Employé(nom, annéeDeNaissance, annéeDeRecrurement, salaire));
                    if (a < 0)
                        Console.Write("Cet employé n'existe pas");
                    else
                        Console.Write("Cet employé existe à la position {0}", a + 1);

                }
                else if (c == 3)
                {
                    int a;
                    Console.WriteLine("Entrez les information de l'employé à supprimer");
                    Console.Write(" le nom : ");
                    nom = Console.ReadLine();
                    Console.Write("la date de naissance : ");
                    annéeDeNaissance =int.Parse(Console.ReadLine());
                    Console.Write("la date de recrutement : ");
                    annéeDeRecrurement =int.Parse (Console.ReadLine());
                    Console.Write("Entrez le salaire : ");
                    salaire = double.Parse(Console.ReadLine());
                    a = l.IndexOf(new Employé(nom, annéeDeNaissance, annéeDeRecrurement, salaire));
                    if (a < 0)
                        Console.Write("Cet employé n'existe pas");
                    else
                        l.RemoveAt(a);
                }
                else if (c == 4)
                {
                    l.Clear();
                }
                else if (c == 5)
                {
                    foreach (Employé e in l)
                        Console.WriteLine(e);
                }
                
            }



                     

               
            
            

        }
    }
    }

