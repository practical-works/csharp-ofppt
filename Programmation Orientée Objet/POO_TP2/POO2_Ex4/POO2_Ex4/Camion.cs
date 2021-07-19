using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex4
{
    class Camion : Vehicule
    {
        public Camion() : base()
        {
            
        }
        public Camion(int anneemodele, double prix) : base(anneemodele,prix)
        {

        }

        public override void Demarrer()
        {
            Console.WriteLine("Démarrage du camion");
        }
        public override void Accelerer()
        {
            Console.WriteLine("Accélération du camion");
        }
    }
}
