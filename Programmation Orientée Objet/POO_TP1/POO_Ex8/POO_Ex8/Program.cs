using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gestion des Comptes des Clients";
            start:
            Console.Clear();
            Action<string> msg = s => Console.Write(s);
            Action<string> msgl = s => Console.WriteLine(s);
            msgl("[ Gestion des Comptes des Clients ]\n");
        //--------------------------------------------------------------------------------------------
            Compte[] account = new Compte[2];
            account[0] = new Compte(new Client());
            account[1] = new Compte(new Client());

            msgl("Compte 1:");
            msg("Donner Le CIN: "); account[0].Propriétaire.CIN = Console.ReadLine();
            msg("Donner Le Nom: "); account[0].Propriétaire.Nom = Console.ReadLine();
            msg("Donner Le Prénom: "); account[0].Propriétaire.Prénom = Console.ReadLine();
            msg("Donner Le numéro de téléphone: "); account[0].Propriétaire.Téléphone = int.Parse(Console.ReadLine());
            account[0].Afficher();
            msg("Donner le montant à déposer: "); account[0].Créditer(double.Parse(Console.ReadLine()));
            account[0].Afficher();
            msg("Donner le montant à retirer: "); account[0].Débiter(double.Parse(Console.ReadLine()));
            account[0].Afficher();

            msgl("\nCompte 2:");
            msg("Donner Le CIN: "); account[1].Propriétaire.CIN = Console.ReadLine();
            msg("Donner Le Nom: "); account[1].Propriétaire.Nom = Console.ReadLine();
            msg("Donner Le Prénom: "); account[1].Propriétaire.Prénom = Console.ReadLine();
            msg("Donner Le numéro de téléphone: "); account[1].Propriétaire.Téléphone = int.Parse(Console.ReadLine());
            account[1].Afficher();
            msgl("Créditer le compte 2 à partir du compte 1:");
            msg("Donner le montant à déposer: "); account[1].Créditer(double.Parse(Console.ReadLine()),account[0]);
            msgl("Débiter le compte 1 et créditer le commpte 2:");
            msg("Donner le montant à retirer: "); account[0].Débiter(double.Parse(Console.ReadLine()), account[1]);
            msgl("");
            account[0].Afficher();
            msgl("");
            account[1].Afficher();
            msgl("");
            Compte.AfficherNombreComptes();
        //--------------------------------------------------------------------------------------------
            Console.ReadKey();
            goto start;
        }
    }
}
