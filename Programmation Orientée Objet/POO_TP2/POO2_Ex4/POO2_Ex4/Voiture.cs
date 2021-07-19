using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex4
{
    class Voiture : Vehicule
    {
        public Voiture() : base()
        {
            
        }
        public Voiture(int anneemodele, double prix) : base(anneemodele,prix)
        {

        }

        public override void Demarrer()
        {
            Console.WriteLine("Démarrage de la voiture");
        }
        public override void Accelerer()
        {
            Console.WriteLine("Accélération de la voiture");
        }
    }
}
