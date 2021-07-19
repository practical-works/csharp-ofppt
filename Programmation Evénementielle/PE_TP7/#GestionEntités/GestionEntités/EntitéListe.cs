using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEntités
{
    static class EntitéListe
    {
        private static List<Entité> Liste = new List<Entité>();

        static EntitéListe()
        {
            Liste.Add(new Entité(1,"Yugi Muto",0.50));
            Liste.Add(new Entité(2,"Joey Wheeler",1.75));
            Liste.Add(new Entité(3,"Tristan Taylor",2.50));
            Liste.Add(new Entité(4,"Téa Gardner",1.25));
            Liste.Add(new Entité(5,"Solomon Muto",1.00));

        }

        public static List<Entité> Afficher()
        {
            return Liste;
        }

        public static void Ajouter(Entité E)
        {
            Liste.Add(E);
        }

        public static void Modifier(int Code, Entité F)
        {
            foreach (Entité item in Liste)
            {
                if (item.Code == Code)
                {
                    item.Nom = F.Nom;
                    item.Valeur = F.Valeur;
                    break;
                }
            }
        }

        public static void Supprimer(int Code)
        {
            foreach (Entité item in Liste)
            {
                if (item.Code == Code)
                {
                    Liste.Remove(item);
                    break;
                }
            }
        }

        public static int Rechercher(int Code)
        {
            foreach (Entité item in Liste)
            {
                if (item.Code == Code)
                {
                    return Liste.IndexOf(item);
                }
            }
            return -1;
        }
    }
}
