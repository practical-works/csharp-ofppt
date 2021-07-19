using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Film f1, f2, f3;
            Exemplaire e1, e2, e3;

            f1 = new Film();
            f2=new Film("34TRV","Les chauveaux de Dieu","2013","Drama","Arabe");
            f3 = new Film(f2);
            f3.Code = "12SST";
            f3.Titre = "Road to Kabul";
            f3.Date = "2012";


            e1 = new Exemplaire();
            e2=new Exemplaire("34TRV","Les chauveaux de Dieu","2013","Drama","Arabe",125,"CD","2013/06/14");
            e3 = new Exemplaire(e2);
            e3.Code = "CVX30";
            e3.Titre = "Road to Kabul";
            e3.Date_achat = "2012/12/13";

            Console.WriteLine(f1.ToString() + "\n");
            Console.WriteLine(f2.ToString() + "\n");
            Console.WriteLine(f3.ToString() + "\n");
            Console.WriteLine("Le nombre de films est : {0} \n", Film.C);
 
            Console.WriteLine(e1.ToString() + "\n");
            Console.WriteLine(e2.ToString() + "\n");
            Console.WriteLine(e3.ToString() + "\n");
            Console.WriteLine("Le nombre d'exemplaire est : {0} ", Exemplaire.C);

            Console.ReadKey();





        }
    }
}
