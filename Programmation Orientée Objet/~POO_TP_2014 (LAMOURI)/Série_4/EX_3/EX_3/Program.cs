using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow ;
            Console.ForegroundColor = ConsoleColor.Blue ;
            //Console.Clear();
            Annuaire a = new Annuaire();
            int c = 1, d;
            string nom, prénom, tel;
            do
            {
                Console.WriteLine("\n1. Pour ajouter un contact");
                Console.WriteLine("2. Pour rechercher un contact par son nom et prénom");
                Console.WriteLine("3. Pour Pour supprimer un contact par son nom et prénom");
                Console.WriteLine("4. Pour effacer tous tous les contacts");
                Console.WriteLine("5. Pour afficher la liste des contacts");
                Console.WriteLine("6. Pour quitter le programme");
                Console.Write("\n   Entrez votre choix SVP : ");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:


                        Console.Write("entrez le nom du contact à ajouter");
                        nom = Console.ReadLine();
                        Console.Write("entrez le prénom du contact à ajouter");
                        prénom = Console.ReadLine();
                        Console.Write("entrez le téléphone du contact à ajouter");
                        tel = Console.ReadLine();
                        if (a.ContientClé(nom, prénom))
                            Console.WriteLine("Ce contact éxiste déja");
                        else
                        {
                            a.Ajouter(nom, prénom, tel);
                        }
                        break;

                    case 2:

                        Console.Write("entrez le nom du contact à rechercher");
                        nom = Console.ReadLine();
                        Console.Write("entrez le prénom du contact à rechercher");
                        prénom = Console.ReadLine();

                        if (a.ContientClé(nom, prénom))
                        {
                            tel = a[new Personne(nom, prénom)];
                            Console.WriteLine("le nom : " + nom + " le prénom : " + prénom + " Tel : " + tel);
                        }
                        else
                            Console.WriteLine("Ce contact n'existe pas");
                        break;

                    case 3:

                        Console.Write("entrez le nom du contact à supprimer");
                        nom = Console.ReadLine();
                        Console.Write("entrez le prénom du contact à supprimer");
                        prénom = Console.ReadLine();

                        if (a.ContientClé(nom, prénom))
                        {
                            a.Supprimer(nom, prénom);
                            Console.WriteLine("Contact bien supprimé");
                        }
                        else
                            Console.WriteLine("Ce contact n'existe pas");
                        break;

                    case 4:
                        a.Vider();
                        Console.WriteLine("l'annuaire est vide");
                        break;

                    case 5:
                        Console.Write("entrez le nom du contact à modifier");
                        nom = Console.ReadLine();
                        Console.Write("entrez le prénom du contact à modifier");
                        prénom = Console.ReadLine();

                        if (a.ContientClé(nom, prénom))
                        {
                            Console.Write("Entrez le nouveau N° du Tel");
                            tel = Console.ReadLine();
                            a[new Personne(nom, prénom)] = tel;

                        }
                        else
                            Console.WriteLine("Ce contact n'existe pas");
                        break;

                    case 6:
                        Console.WriteLine("Fin du programme");
                        break;
                }
                Console.ReadKey();
            } while (c != 6);
           
        }
                
            
                    



        
    }
}
    