using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO7_Ex1
{
    class Annuaire
    {
        private Dictionary<Personne, string> col = new Dictionary<Personne, string>();
        public Dictionary<Personne, string> Liste { get { return col; } }
        public int Nombre { get { return col.Count; } }

        public Annuaire() { }

        public void Ajouter(string Nom, string Prenom, string Telephone)
        {
            col.Add(new Personne(Nom, Prenom), Telephone);
        }
        public void Vider()
        {
            col.Clear();
        }
        public bool ContientCle(string Nom, string Prenom)
        {
            return col.ContainsKey(new Personne(Nom, Prenom));
        }
        public bool ContientValeur(string Telephone)
        {
            return col.ContainsValue(Telephone);
        }
        public void Supprimer(string Nom, string Prenom)
        {
            col.Remove(new Personne(Nom, Prenom));
        }

        public void Afficher()
        {
            if (Nombre == 0)
            {
                Console.WriteLine("\tAucun élément.");
            }
            else
            {
                foreach (KeyValuePair<Personne,string> C in col)
                {
                    Console.WriteLine("\t" + C.Key + " : " + C.Value);
                    //Console.WriteLine("\t\tHashCode: " + C.GetHashCode());
                }
            }
        }
    }
}
