using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO3_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Les élèves";
            Console.WriteLine("Les élèves :");
            start:
            try
            {
                Console.WriteLine("\nNouveau élève (1) :");
                Console.Write("\t* Nom: "); string nom = Console.ReadLine();
                Console.Write("\t* Age: "); int age = int.Parse(Console.ReadLine());
                Console.Write("\t* Moyenne: "); double moyenne = double.Parse(Console.ReadLine());
                Eleve e1 = new Eleve(nom, age, moyenne);
                Eleve e2 = new Eleve();
                Console.WriteLine("\nNouveau élève (2) :");
                Console.Write("\t* Nom: "); e2.Nom = Console.ReadLine();
                Console.Write("\t* Age: "); e2.Age = int.Parse(Console.ReadLine());
                Console.Write("\t* Moyenne: "); e2.Moyenne = double.Parse(Console.ReadLine());
            }
            catch (InvalidAgeException age_e)
            {
                Console.WriteLine(age_e.Message);
            }
            catch (InvalidNoteException note_e)
            {
                Console.WriteLine(note_e.Message); ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            goto start;
            Console.ReadLine();
        }
    }
}
