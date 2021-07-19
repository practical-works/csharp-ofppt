using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace POO5_Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque B = new Banque("Exemple de banque");
            Client C1 = new Client("E111", "Biba", "Salima", "Avenue Prince N°71 Guliz Marrakech");
            Client C2 = new Client("EE251", "Elise", "Mina", "Avenue Moulmay N°12 Brikola Rajab");
            Client C3 = new Client("E890", "Hosni", "Hassan", "DB IfranX N°35 ADDZ Romania");
            Compte Cmp1 = new Compte(500, C1), Cmp2 = new Compte(100, C2), Cmp3 = new Compte(60, C3);
            //-------------------------------------------------------------------------------------
            Console.WriteLine("BANQUE :"); Thread.Sleep(1000);
            Console.WriteLine("\nAjout de comptes ...\n"); Thread.Sleep(1000);
            B.Ajouter(Cmp1); 
            B.Ajouter(Cmp2); 
            B.Ajouter(Cmp3);
            Console.WriteLine("\nAffichage des comptes ...\n"); Thread.Sleep(1000);
            B.Afficher();
            Console.WriteLine("\nAffichage des comptes en 70 et 700 DH ...\n"); Thread.Sleep(1000);
            B.Afficher(70, 700);
            Console.WriteLine("\nAffichage des comptes du client de CIN EE251 ...\n"); Thread.Sleep(1000);
            B.Afficher("EE251");

            Console.WriteLine("\nModification du compte 1 ..."); Thread.Sleep(1000);
            B.Modifier(1, new Compte(1000, new Client("X100", "XxX", "Nikki", "The D Area")));

            Console.WriteLine("\nAffichage des comptes ...\n"); Thread.Sleep(1000);
            B.Afficher();

            Console.WriteLine("\nSuppression du compte 1 ..."); Thread.Sleep(1000);
            B.Supprimer(1);

            Console.WriteLine("\nAffichage des comptes ...\n"); Thread.Sleep(1000);
            B.Afficher();

            Console.WriteLine("\nRecherche du compte 1 ..."); Thread.Sleep(1000);
            int p = B.Rechercher(1);
            if (p == -1) Console.WriteLine("Compte introuvable!");
            else Console.WriteLine(B.Liste[p]);

            Console.WriteLine("\nRecherche du compte 2 ..."); Thread.Sleep(1000);
            p = B.Rechercher(2);
            if (p == -1) Console.WriteLine("Compte introuvable!");
            else Console.WriteLine(B.Liste[p]);

            Console.ReadKey();
        }
    }
}
