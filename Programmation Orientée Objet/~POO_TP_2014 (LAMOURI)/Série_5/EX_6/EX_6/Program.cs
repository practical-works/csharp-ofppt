using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EX_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("entrez le nom du fichier : ");
                StreamReader f = File.OpenText(Console.ReadLine());
                StreamWriter g = File.CreateText("Copie_De_" + Console.ReadLine());
                while (!f.EndOfStream) g.WriteLine(f.ReadLine());
                f.Close();
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
