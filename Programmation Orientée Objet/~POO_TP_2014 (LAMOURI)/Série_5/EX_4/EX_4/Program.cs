using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EX_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                StreamReader f = File.OpenText("données.txt");
                while (!f.EndOfStream)
                {
                    Console.WriteLine(f.ReadLine());
                }

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
