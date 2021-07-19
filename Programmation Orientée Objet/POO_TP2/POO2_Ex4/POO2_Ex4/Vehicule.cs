using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex4
{
    abstract class Vehicule
    {
        private int matricule;
        private int anneemodele;
        private double prix;
        private static int nombrevehicules = 0;

        public static int NombreVehicules
        {
            get { return nombrevehicules; }
        }
        
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        
        public int AnneeModele
        {
            get { return anneemodele; }
            set { anneemodele = value; }
        }
        
        public int Matricule
        {
            get { return matricule; }
        }

        public Vehicule()
        {
            nombrevehicules++;
            matricule = nombrevehicules;
        }
        public Vehicule(int anneemodele, double prix)
        {
            nombrevehicules++;
            matricule = nombrevehicules;
            this.anneemodele = anneemodele;
            this.prix = prix;
        }

        public abstract void Demarrer();
        public abstract void Accelerer();

        public override string ToString()
        {
            return "Matricule: " + matricule + " / Année de modèle: " + anneemodele + " / Prix: " + prix;
        }
    }
}
