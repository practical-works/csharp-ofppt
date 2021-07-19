using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVehicules
{
    class Vehicule
    {
        public string Marque { get; set; }
        public int Consommation { get; set; } // Quantité consommée par 100 Km parcourues
        public string Carburant { get; set; }
        public int CapReservoir { get; set; }
        public int QteReservoir { get; set; } // = 0
        public int DistanceParcourue { get; set; } // en Km

        private static string[] liste_carburants = { "Diesel", "Essence" };
        public static string[] ListeCarburants { get { return liste_carburants; } }
        
        public Vehicule()
        {
            QteReservoir = 0;
            DistanceParcourue = 0;
        }
        public Vehicule(string Marque, int Consommation, string Carburant, int CapReservoir)
        {
            QteReservoir = 0;
            DistanceParcourue = 0;
            this.Marque = Marque;
            this.Consommation = Consommation;
            this.Carburant = Carburant;
            this.CapReservoir = CapReservoir;
        }

        public void RemplirReservoir(int Quantite)
        {
            if (Quantite + QteReservoir > CapReservoir)
            {
                throw new Exception("Capacité du réservoir dépassée!");
            }
            else
            {
                QteReservoir += Quantite;
            }
        }
        public void RemplirReservoir()
        {
            QteReservoir = CapReservoir;
        }
        public bool ParcourirDistance(int Distance)
        {
            int QteConsommee = Consommation*(Distance/100);
            if (QteReservoir - QteConsommee <= 0)
            {
                return false;
            }
            else
            {
                QteReservoir -= QteConsommee;
                return true;
            }
        }
    }
}
