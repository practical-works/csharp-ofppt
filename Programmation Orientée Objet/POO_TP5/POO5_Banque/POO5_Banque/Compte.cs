using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO5_Banque
{
    class Compte
    {
        private int numero;
        private static int count = 0;
        private double solde;
        private Client propriétaire;

        public Client Propriétaire
        {
            get { return propriétaire; }
            set { propriétaire = value; }
        }
        public double Solde
        {
            get { return solde; }
        }
        public static int Count
        {
            get { return count; }
        }
        public int Numero
        {
            get { return numero; }
        }
        

        public Compte()
        {
            count++;
            numero = count;
        }
        public Compte(double Solde, Client Propriétaire)
        {
            count++;
            numero = count;
            solde = Solde;
            propriétaire = Propriétaire;
        }

        public override string ToString()
        {
            return "Numéro: " + Numero + "\nSolde: " + Solde + " DH" + "\nPropriétaire:\n" + propriétaire + "\n";
        }
    }
}
