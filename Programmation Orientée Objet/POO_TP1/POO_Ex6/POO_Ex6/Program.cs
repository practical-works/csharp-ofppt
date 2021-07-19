using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Employé dans une entreprise";
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black;
            start:
            Console.Clear();
            Employé houda = new Employé();
            Action<string> msg = s => Console.Write(s);
            //--------------------------------------------------------------------------
            //--------------------------------------------------------------------------
            msg("[ Employé dans une entreprise ]\n\n");
            msg("Entrez le matricule: "); houda.Matricule = int.Parse(Console.ReadLine());
            msg("Entrez le nom: "); houda.Nom = Console.ReadLine();
            msg("Entrez le prénom: "); houda.Prénom = Console.ReadLine();
            //--------------------------------------------------------------------------
            msg("\nEntrez la date de naissance:\n");
            msg("\tJour: "); int day = int.Parse(Console.ReadLine());
            msg("\tMois: "); int month = int.Parse(Console.ReadLine());
            msg("\tAnnée: "); int year = int.Parse(Console.ReadLine());
            houda.DateNaissance = new DateTime(year,month,day);
            //--------------------------------------------------------------------------
                msg("\t* L'age: " + houda.Age() + " ans.");
            //--------------------------------------------------------------------------
            msg("\n\nEntrez la date d'embauche:\n");
            msg("\tJour: "); day = int.Parse(Console.ReadLine());
            msg("\tMois: "); month = int.Parse(Console.ReadLine());
            msg("\tAnnée: "); year = int.Parse(Console.ReadLine());
            houda.DateEmbauche = new DateTime(year, month, day);
            //--------------------------------------------------------------------------
                msg("\t* L'ancienneté: " + houda.Anciennete() + " ans.");
            //--------------------------------------------------------------------------
                msg("\n\nEntrez le salaire (DH): "); houda.Salaire = int.Parse(Console.ReadLine());
            //--------------------------------------------------------------------------
                houda.AugmentationDuSalaire();
                msg("\t* Salaire après augmentation: " + houda.Salaire + " DH.");
            //--------------------------------------------------------------------------
                msg("\n\nAperçu des informations de l'employé:\n");
                houda.AfficherEmployé();
            //--------------------------------------------------------------------------
                Console.ReadKey();
                goto start;
            //--------------------------------------------------------------------------
            
        }
    }
}
