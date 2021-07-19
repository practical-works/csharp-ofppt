using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO5_Banque
{
    class Banque
    {
        public string Nom { get; set; }
        private List<Compte> ListeComptes = new List<Compte>();
        public List<Compte> Liste { get { return ListeComptes; } }

        public Banque()
        {

        }
        public Banque(string Nom)
        {
            this.Nom = Nom;
        }

        public int Rechercher(int Numero)
        {
            return ListeComptes.FindIndex(C => C.Numero == Numero);
        }

        public void Ajouter(Compte C)
        {
            ListeComptes.Add(C);
        }
        public void Supprimer(int Numero)
        {
            ListeComptes.RemoveAt(Rechercher(Numero));
        }
        public void Modifier(int Numero, Compte C)
        {
            ListeComptes[Rechercher(Numero)] = C;
        }

        public void Afficher()
        {
            foreach (Compte C in ListeComptes)
            {
                Console.WriteLine(C);
            }
        }
        public void Afficher(double Solde_Min, double Solde_Max)
        {
            foreach (Compte C in ListeComptes)
            {
                if (C.Solde >= Solde_Min && C.Solde <= Solde_Max)
                {
                    Console.WriteLine(C);
                }
            }
        }
        public void Afficher(string CIN)
        {
            foreach (Compte C in ListeComptes)
            {
                if (C.Propriétaire.CIN == CIN)
                {
                    Console.WriteLine(C);
                }
            }
        }
    }
}
