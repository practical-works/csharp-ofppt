using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_1
{
    class Voiture : IVehicule
    {
        private carburant c;
        private int puissance, nombrePlace, distance;
        private double reserve, reserveMax;

        public Voiture()
        {
            c = carburant.Diesel;
            puissance = 0;
            nombrePlace = 0;
            distance = 0;
            reserve = 0;
            reserveMax = 0;
        }
        public Voiture(carburant c, int puissance, int nombrePlace, int distance, double reserve, double reserveMax)
        {
            this.c = carburant.Diesel;
            this.puissance = puissance;
            this.nombrePlace = nombrePlace;
            this.distance = distance;
            this.reserve = reserve;
            this.reserveMax = reserveMax;
        }
        public Voiture(Voiture v)
        {
            c = v.c;
            puissance = v.puissance;
            nombrePlace = v.nombrePlace;
            distance = v.distance;
            reserve = v.reserve;
            reserveMax = v.reserveMax;
        }

        public carburant C
        {
            get { return c; }
            set { c = value; }
        }
        public int Puissance
        {
            get { return puissance; }
            set { puissance = value; }
        }
        public int NombrePlace
        {
            get { return nombrePlace; }
            set { nombrePlace = value; }
        }
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public double Reserve
        {
            get { return reserve; }
            set { reserve = value; }
        }
        public double ReserveMax
        {
            get { return reserveMax; }
            set { reserveMax = value; }
        }

        public void Deplacer(int distance)
        {
            if (this.c == carburant.Essence)
            {
                if (reserve < (distance * 7) / 100)
                    Console.WriteLine("Votre reserve n'est pas suffisant");
                else
                {
                    Console.WriteLine("Le nombre des litres d'essence necéssaire est  : " + (distance * 7) / 100);
                    reserve-=(reserve-(distance * 7) / 100);
                    this.distance+=distance;
                }
            }

            if (this.c == carburant.Diesel)
            {
                if (reserve < (distance * 6) / 100)
                    Console.WriteLine("Votre reserve n'est pas suffisant");
                else
                {
                    Console.WriteLine("Le nombre des litres de diesel necéssaire est  : " + (distance * 6) / 100);
                    reserve -= (reserve - (distance * 6) / 100);
                    this.distance += distance;
                }
            }

        }
        public void Approvisionner(int nbLitre)
        {
            if (reserve + nbLitre > reserveMax)
            {
                Console.WriteLine("Reserve max");
                reserve = reserveMax;
                return;
            }
            reserve += nbLitre;

        }
        public override string ToString()
        {
            return string.Format("Le carburant  : {0} \nLa puissance : {1} \nLe nombre de places : {2} \nLa distance : {3} \nLe reserve : {4} \nLe rserve maximum : {5}", c, puissance, nombrePlace, distance, reserve, reserveMax);
        }


    }
}
