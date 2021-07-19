using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
        string g ;
            
            
            try
            {
                StreamWriter f = File.CreateText("données.txt");
                Console.WriteLine("Entrez votre texte");
                
                
                do
                {
                    g = Console.ReadLine();
                    f.WriteLine(g);


                } while (g != "");
                    f.Close();
                   Console.WriteLine("Enregistrement términé");
                
                
            }
            catch (IndexOutOfRangeException ex)
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
