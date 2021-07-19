using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex8
{
    class Compte
    {
        // Attributs
        private double solde;
        private int code;
        private Client propriétaire;
        private static int nombrecomptes = 0;

        public int NombreComptes
        {
            get { return nombrecomptes; }
            set { nombrecomptes = value; }
        }
        
        // Accesseurs
        public Client Propriétaire
        {
            get { return propriétaire; }
            set { propriétaire = value; }
        }

        public int Code
        {
            get { return code; }
        }

        public double Solde
        {
            get { return solde; }
        }

        // Constructeurs    
        public Compte(Client propriétaire)
        {
            nombrecomptes++;
            code = nombrecomptes;
            this.propriétaire = propriétaire;
        }

        // Méthodes
        public void Créditer(double montant)
        {
            solde += montant;
            MessageInfos("Transaction");
        }

        public void Créditer(double montant, Compte compte_débité)
        {
            if (montant <= compte_débité.solde)
            {
                solde += montant;
                compte_débité.solde -= montant;
                MessageInfos("Transaction");
            }
            else
            {
                MessageInfos("Insuffisance");
            }
            
        }

        public void Débiter(double montant)
        {
            if (montant <= solde)
            {
                solde -= montant;
                MessageInfos("Transaction");
            }
            else
            {
                MessageInfos("Insuffisance");
            }
            
        }

        public void Débiter(double montant, Compte compte_crédité)
        {
            if (montant <= solde)
            {
                solde -= montant;
                compte_crédité.solde += montant;
                MessageInfos("Transaction");
            }
            else
            {
                MessageInfos("Insuffisance");
            }
            
            
        }

        private void MessageInfos(string sujet)
        {
            switch (sujet)
            {
                case "Transaction":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Transactions effectuéees avec succés.");
                    Console.ResetColor();
                    break;
                case "Insuffisance": 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Transactions non effectuéees. Solde insuffisant !");
                    Console.ResetColor();
                    break;
                default: 
                    ArgumentException MotCléFaux = new ArgumentException();
                    Console.WriteLine(MotCléFaux.Message);
                    break;
            }
            
        }

        public void Afficher()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tNuméro de compte: " + code);
            Console.WriteLine("\tSolde du compte: " + solde);
            Console.WriteLine("\tPropriétaire du compte:");
            propriétaire.Afficher();
            Console.ResetColor();
        }

        public static void AfficherNombreComptes()
        {
            Console.WriteLine("Le nombre de comptes créés est: " + nombrecomptes);
        }
    }
}
