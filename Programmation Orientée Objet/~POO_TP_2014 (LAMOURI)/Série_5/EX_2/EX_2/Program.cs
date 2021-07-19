using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Eléve e = new Eléve();
            
                try
                {
                    Console.Write("Entrez le nom :  "); e.Nom = Console.ReadLine();
                    Console.Write("Entrez l'âge :  "); e.Age = int.Parse(Console.ReadLine());
                    Console.Write("Entrez la moyenne:  "); e.Moyenne = double.Parse(Console.ReadLine());

                    Console.WriteLine(e);
                }
                catch (InvalidAgeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidNoteException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (FormatException ex)
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
