using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Employés";
            Console.WriteLine(">----------------------------< Gestion d'employés >----------------------------<");
            int jour, mois, annee;

            Console.WriteLine("Créer un ouvrier :");
            Ouvrier ouv = new Ouvrier();
            Console.Write("* Matricule: "); ouv.Matricule = int.Parse(Console.ReadLine());
            Console.Write("* Nom: "); ouv.Nom = Console.ReadLine();
            Console.Write("* Prénom: "); ouv.Prenom = Console.ReadLine();
            Console.WriteLine("* Date de naissance:");
            Console.Write("\tJour de naissance: "); jour = int.Parse(Console.ReadLine());
            Console.Write("\tMois de naissance: "); mois = int.Parse(Console.ReadLine());
            Console.Write("\tAnnée de naissance: "); annee = int.Parse(Console.ReadLine());
            ouv.DateNaissance = new DateTime(annee, mois, jour);
            Console.WriteLine("* Date d'entrée :");
            Console.Write("\tJour: "); jour = int.Parse(Console.ReadLine());
            Console.Write("\tMois: "); mois = int.Parse(Console.ReadLine());
            Console.Write("\tAnnée: "); annee = int.Parse(Console.ReadLine());
            ouv.DateEntree = new DateTime(annee, mois, jour);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ouv);
            Console.WriteLine("Salaire mensuel: " + ouv.GetSalaire());
            Console.ResetColor();

            Console.WriteLine("Créer un cadre :");
            Cadre cad = new Cadre();
            Console.Write("* Matricule: "); cad.Matricule = int.Parse(Console.ReadLine());
            Console.Write("* Nom: "); cad.Nom = Console.ReadLine();
            Console.Write("* Prénom: "); cad.Prenom = Console.ReadLine();
            Console.WriteLine("* Date de naissance:");
            Console.Write("\tJour de naissance: "); jour = int.Parse(Console.ReadLine());
            Console.Write("\tMois de naissance: "); mois = int.Parse(Console.ReadLine());
            Console.Write("\tAnnée de naissance: "); annee = int.Parse(Console.ReadLine());
            cad.DateNaissance = new DateTime(annee, mois, jour);
            Console.Write("* Indice (entre 1 et 4): "); cad.Indice = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cad);
            Console.WriteLine("Salaire mensuel: " + cad.GetSalaire());
            Console.ResetColor();

            Console.WriteLine("Créer un patron :");
            Patron pat = new Patron();
            Console.Write("* Matricule: "); pat.Matricule = int.Parse(Console.ReadLine());
            Console.Write("* Nom: "); pat.Nom = Console.ReadLine();
            Console.Write("* Prénom: "); pat.Prenom = Console.ReadLine();
            Console.WriteLine("* Date de naissance:");
            Console.Write("\tJour de naissance: "); jour = int.Parse(Console.ReadLine());
            Console.Write("\tMois de naissance: "); mois = int.Parse(Console.ReadLine());
            Console.Write("\tAnnée de naissance: "); annee = int.Parse(Console.ReadLine());
            pat.DateNaissance = new DateTime(annee, mois, jour);
            Console.WriteLine("* Chiffre d'affaire de l'entreprise: "); Patron.ChiffreAffaire = double.Parse(Console.ReadLine());
            Console.WriteLine("* Pourcentage de la part du patron du chiffre d'affaire (en %): "); pat.Pourcentage = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(pat);
            Console.WriteLine("Salaire mensuel: " + pat.GetSalaire());
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
