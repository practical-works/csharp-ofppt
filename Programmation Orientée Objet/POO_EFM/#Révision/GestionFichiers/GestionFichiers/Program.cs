using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionFichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Catégorie Général = new Catégorie("Général", null);
            Catégorie Cours = new Catégorie("Cours", null);
            Catégorie Programmation = new Catégorie("Programmation",Cours);
            Catégorie POO = new Catégorie("POO", Programmation);

            Console.WriteLine(Programmation);
            Console.WriteLine();

            Dossier Racine = new Dossier();
            Dossier Dossier1 = new Dossier("dossier1",Racine);
            Dossier Dossier2 = new Dossier("dossier2",Dossier1);

            Console.WriteLine(Dossier2);
            Console.WriteLine();

            Fichier Fichier1 = new Fichier("fichier1.ext", 100, Racine);
            Fichier Fichier2 = new Fichier("fichier2.ext", 200, Dossier2);
            Fichier1.Categorie = Programmation;
            Fichier2.Categorie = Général;

            Console.WriteLine(Fichier1 + " ==> " + Fichier1.Categorie);
            Console.WriteLine(Fichier2 + " ==> " + Fichier2.Categorie);

            Console.ReadLine();
        }
    }
}
