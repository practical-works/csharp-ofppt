using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_1
{
    public enum carburant{Essence,Diesel}
    interface IVehicule
    {
        carburant C{get;set;}
        int Puissance { get; set; }
        int NombrePlace { get; set; }
        int Distance { get; set; }
        double Reserve { get; set; }
       void Deplacer(int distance);
       void Approvisionner(int nbLitres);



    }
}
