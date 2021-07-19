using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace POO_EFM_2015
{
    class Facture
    {
        private int numero;
        private static int nombre = 0;
        private DateTime date;
        private List<Achat> achats;

        public Facture()
        {
            nombre++;
            this.numero = nombre;
            this.date = DateTime.Today;
            this.achats = new List<Achat>();
        }
        public Facture(List<Achat> Achats)
        {
            nombre++;
            this.numero = nombre;
            this.date = DateTime.Today;
            this.achats = new List<Achat>();
            this.achats.AddRange(Achats);
        }

        public void Ajouter(Achat a)
        {
            bool AchatExiste = false;
            foreach (Achat A in this.achats)
            {
                if (a.Numero == A.Numero)
                {
                    AchatExiste = true;
                    break;
                }
            }
            if (!AchatExiste)
            {
                achats.Add(a);
            }
            else
            {
                Console.WriteLine("Achat existe déjà!");
            }
        }

        public double Montant()
        {
            double montant = 0;
            foreach (Achat A in achats)
            {
                montant += A.ArticleAchete.getPrix() * A.Quantite;
            }
            return montant;
        }

        public void Enregistrer(string NomFichier)
        {
            List<Achat> L = new List<Achat>();
            L.AddRange(achats);
            for (int i = 0; i < L.Count; i++)
            {
                for (int j = i + 1; j < L.Count; j++)
                {
                    if (L[i].ArticleAchete.Designation.CompareTo(L[j].ArticleAchete.Designation) == -1)
                    {
                        Achat tmp = L[i];
                        L[i] = L[j];
                        L[j] = tmp;
                    }
                }
            }
            Stream S = File.OpenWrite(NomFichier);
            BinaryFormatter B = new BinaryFormatter();
            B.Serialize(S, L);
        }

        public override string ToString()
        {
            string S = "";
            S += "Numéro facture: " + this.numero + " \tDate facture: " + this.date.ToShortDateString() + "\n\n";
            S += "Liste des achats\n\n";
            S += "Désignation \tRemise \tPrix \t\tQuantité \tPrixTotal\n";
            foreach (Achat A in achats)
            {
                S += A.ArticleAchete.Designation + " \t";
                if (A.ArticleAchete.GetType() == typeof(ArticleEnSolde))
                {
                    ArticleEnSolde AS = (ArticleEnSolde)A.ArticleAchete;
                    S += AS.Remise + "%\t";
                }
                else
                {
                    S += "-\t";
                }
                S += A.ArticleAchete.getPrix() + " DH\t\t";
                S += A.Quantite + "\t";
                S += A.ArticleAchete.getPrix() * A.Quantite + " DH\n";
            }
            S += "\nMontant de la facture: " + this.Montant() + " DH";
            return S;
        }
    }
}
