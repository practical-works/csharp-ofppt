using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO7_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Paramètres Console
            try
            {
                Console.Title = "Annuaire Téléphonique";
                Console.SetWindowSize(80, 30);
            }
            catch (Exception X)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(X.Message + "\n");
                Console.ResetColor();
            }
            #endregion

            #region Déclarations
            Annuaire A = new Annuaire();
            string Nom = "", Prenom = "", Telephone = "0600000000";
            #endregion      

            #region Affichage
            Start:
            Console.WriteLine("Annuaire Téléphonique: \n");
            Console.WriteLine("===========================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            A.Afficher();
            Console.ResetColor();
            Console.WriteLine("===========================================\n");
            #endregion

            #region Menu
            try
            {
                Console.Write("\t 1. Ajouter Contact \n" +
                              "\t 2. Rechercher Contact par Nom/Prénom \n" +
                              "\t 3. Supprimer Contact par Nom/Prénom \n" +
                              "\t 4. Effacer Tous les Contacts \n" +
                              "\t 5. Modifier Contact \n" +
                              "\t 6. Quitter \n");
                Console.Write("\n=> Entrez votre choix: ");
                int choix = int.Parse(Console.ReadLine());
                
                switch (choix)
                {
                    case 1: // Ajouter Contact
                        Console.WriteLine("Ajouter un nouveau contact:");
                        Console.Write("Entrez Nom: "); Nom = Console.ReadLine();
                        Console.Write("Entrez Prénom: "); Prenom = Console.ReadLine();
                        Console.Write("Entrez Téléphone: "); Telephone = Console.ReadLine();
                        A.Ajouter(Nom, Prenom, Telephone);
                        Console.WriteLine("Contact bien ajouté.");
                        Nom = Prenom = Telephone = string.Empty;
                        break;
                    case 2: // Rechercher Contact par Nom/Prénom
                        Console.WriteLine("Rechercher un contact par nom et prénom:");
                        Console.Write("Entrez Nom: "); Nom = Console.ReadLine();
                        Console.Write("Entrez Prénom: "); Prenom = Console.ReadLine();
                        if (!A.ContientCle(Nom, Prenom))
                        {
                            Console.WriteLine("Contact recherché introuvable!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Contact recherché trouvé:");
                            Console.ResetColor();
                        }
                        Nom = Prenom = Telephone = string.Empty;
                        break;
                    case 3: // Supprimer Contact par Nom/Prénom
                        Console.WriteLine("Supprimer un contact par nom et prénom:");
                        Console.Write("Entrez Nom: "); Nom = Console.ReadLine();
                        Console.Write("Entrez Prénom: "); Prenom = Console.ReadLine();
                        if (!A.ContientCle(Nom, Prenom))
                        {
                            Console.WriteLine("Contact à supprimer introuvable!");
                        }
                        else
                        {
                            A.Supprimer(Nom, Prenom);
                            Console.WriteLine("Contact bien supprimé:");
                        }
                        Nom = Prenom = Telephone = string.Empty;
                        break;
                    case 4: // Effacer Tous les Contacts
                        Console.WriteLine("Effacer Tous les Contacts:");
                        A.Vider();
                        Console.WriteLine("Liste des contacts bien vidée!");
                        break;
                    case 5: // Modifier Contact
                        Console.WriteLine("Modifier un contact:");
                        Console.Write("Entrez Nom: "); Nom = Console.ReadLine();
                        Console.Write("Entrez Prénom: "); Prenom = Console.ReadLine();
                        if (!A.ContientCle(Nom, Prenom))
                        {
                            Console.WriteLine("Contact à modifier introuvable!");
                        }
                        else
                        {
                            //Edit:
                            Console.WriteLine("Contact à modifier trouvé:");
                            //Console.Write("\t 1. Modifier Nom \n" +
                            //              "\t 2. Modifier Prénom \n" +
                            //              "\t 3. Modifier Téléphone \n" +
                            //              "\t 4. Retourner \n");
                            //Console.Write("\n=> Entrez votre choix: ");
                            //int c = int.Parse(Console.ReadLine());
                            //switch (c)
                            //{
                            //    case 1: // Modifier Nom
                            //        Console.Write("Entrez Nouveau Nom: "); Nom = Console.ReadLine();
                            //        break;
                            //    case 2: // Modifier Prénom
                            //        Console.Write("Entrez Nouveau Prénom: "); Prenom = Console.ReadLine();
                            //        break;
                            //    case 3: // Modifier Téléphone
                            Console.Write("Entrez Nouveau Téléphone: "); Telephone = Console.ReadLine();
                            //        break;
                            //    case 4: // Retrourner
                            //        Nom = Prenom = Telephone = string.Empty;
                            //        Console.Clear();
                            //        goto Start;
                            //    default: // Choix invalide
                            //        throw new Exception("Choix invalide!");
                            //}
                            A.Liste[new Personne(Nom, Prenom)] = Telephone;
                            Console.WriteLine("Contact bien modifié.");
                            //goto Edit;

                        }
                        Nom = Prenom = Telephone = string.Empty;
                        break;
                    case 6: // Quitter
                        Environment.Exit(0);
                        break;
                    default: // Choix invalide
                        throw new Exception("Choix invalide!");
                }
            }
            catch (Exception Exc)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Exc.Message);
                Console.ResetColor();

            }
            #endregion

            #region Relancement
            Console.ReadLine();
            Console.Clear();
            goto Start;
            #endregion
        }
    }
}
