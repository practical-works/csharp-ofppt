using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionVehicules
{
    static class Garage
    {
        private static List<Vehicule> garage = new List<Vehicule>();

        public static List<Vehicule> Liste { get { return garage; } }

        public static int Rechercher(string Marque)
        {
            foreach (Vehicule V in garage)
            {
                if (V.Marque == Marque)
                {
                    return garage.IndexOf(V);
                }
            }
            return -1;
        }
        public static bool Ajouter(Vehicule V)
        {
            int p = Rechercher(V.Marque);
            if (p == -1)
	        {
                garage.Add(V);
                return true;
	        }
            return false;
        }
        public static bool Modifier(string Marque, Vehicule V)
        {
            int p = Rechercher(Marque);
            if (p != -1)
            {
                garage[p] = new Vehicule(V.Marque, V.Consommation, V.Carburant, V.CapReservoir);
                garage[p].DistanceParcourue = V.DistanceParcourue;
                garage[p].QteReservoir = V.QteReservoir;
                return true;
            }
            return false;
        }
        public static bool Supprimer(string Marque)
        {
            int p = Rechercher(Marque);
            if (p != -1)
            {
                garage.RemoveAt(p);
                return true;
            }
            return false;
        }
    }
}
