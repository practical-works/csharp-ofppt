using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Sérialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList l = new ArrayList();
            Personne p;
            string nom, prénom; int age, c = 1;

            while (c != 3)
            {
                Console.WriteLine("1: Pour saisir les informations d’une personne et l’enregistrer");
                Console.WriteLine("2: Pour charger les informations d’une personne");
                Console.WriteLine("3: Pour quitter");
                try
                {
                    Console.Write("Entrez votre choix : "); c = int.Parse(Console.ReadLine());
                    switch (c)
                    {
                        case 1:


                            Console.Write("Entrez le nom : ");
                            nom = Console.ReadLine();
                            Console.Write("Entrez le prénom : ");
                            prénom = Console.ReadLine();
                            Console.Write("Entrez l'age : ");
                            age = int.Parse(Console.ReadLine());
                            p = new Personne(nom, prénom, age);

                            FileStream f = new FileStream("Personne", FileMode.Create);
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Serialize(f, p);

                            break;
                        case 2:

                            BinaryFormatter b = new BinaryFormatter();
                            FileStream k = new FileStream("Personne", FileMode.Open);
                            p = (Personne)b.Deserialize(k);
                            k.Close();
                            Console.WriteLine(p);


                            break;
                        case 3:
                            Console.WriteLine("Fin du programme");
                            break;
                        default:
                            Console.WriteLine("Choix non valid");
                            break;
                    }
                }


                catch (InvalidAgeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    Console.ReadKey();
                }

            }
        }
    }
}             
            




    
