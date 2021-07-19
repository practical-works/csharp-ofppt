using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_1
{
    class Program
    {
        static void Main(string[] args)
        {
            erreur1 :
            int a, b;
            try
            {
                Console.Write("entrez le nombre a : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("entrez le nombre b : ");
                b = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.Write(ex.Message+"\n");
                goto erreur1;

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
