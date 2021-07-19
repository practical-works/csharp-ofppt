using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PE8_GestionTV
{
    static class TV
    {
        private static List<Emission> Liste = new List<Emission>();
        public static List<Emission> Emissions { get { return Liste; } }
        private static bool donnes_modifiees = false;
        public static bool DonneesModifiees { get { return donnes_modifiees; } }
        private static string chemin_fichier = "Emissions.tv";

        static TV()
        {
            Liste.Add(new Emission(1, "Emission1", DateTime.Today, "12:00", 10, Emission.ListeTypes[0]));
            Liste.Add(new Emission(2, "Emission2", DateTime.Today, "17:47", 120, Emission.ListeTypes[1]));
            Liste.Add(new Emission(3, "Emission3", DateTime.Today.AddDays(2), "11:55", 25, Emission.ListeTypes[2]));
            Liste.Add(new Emission(4, "Emission4", DateTime.Today.AddDays(1), "05:00", 45, Emission.ListeTypes[3]));
            Liste.Add(new Emission(5, "Emission5", DateTime.Today.AddDays(2), "07:15", 60, Emission.ListeTypes[0]));
        }

        # region Filtre (Méthodes de filtrage de la liste)
        public static List<Emission> ListeDateGet(DateTime Date)
        {
            List<Emission> ListeDate = new List<Emission>();
            foreach (Emission E in Liste)
            {
                if (E.Date.Date == Date.Date)
                {
                    ListeDate.Add(E);
                }
            }
            return ListeDate;
        }
        # endregion 

        # region Gestion (Méthodes de manipulation de la liste)

        public static int Rechercher(int Numero)
        {
            return Liste.FindIndex(E => E.Numero == Numero);
        }
        public static bool Ajouter(Emission E)
        {
            if (Rechercher(E.Numero) == -1)
            {
                Liste.Add(E);
                donnes_modifiees = true;
                return true;
            }
            return false;
        }
        public static bool Modifier(int Numero, Emission E)
        {
            int id = Rechercher(Numero);
            if (id != -1)
            {
                Liste[id].Nom = E.Nom;
                Liste[id].Date = E.Date;
                Liste[id].Heure = E.Heure;
                Liste[id].Duree = E.Duree;
                Liste[id].Type = E.Type;
                donnes_modifiees = true;
                return true;
            }
            return false;
        }
        public static bool Supprimer(int Numero)
        {
            int id = Rechercher(Numero);
            if (id != -1)
            {
                Liste.RemoveAt(id);
                donnes_modifiees = true;
                return true;
            }
            return false;
        }

        # endregion

        # region Statistiques (Méthodes de calcul)

        public static int DureeTotal()
        {
            int duree = 0;
            foreach (Emission E in Liste)
            {
                duree += E.Duree;
            }
            return duree;
        }
        public static int DureeTotal(string Type)
        {
            int duree = 0;
            foreach (Emission E in Liste)
            {
                if (E.Type == Type) duree += E.Duree;
            }
            return duree;
        }
        public static double DureePourcentage(string Type)
        {
            if (DureeTotal() != 0)
            {
                return Math.Round(100 * ((double)DureeTotal(Type) / DureeTotal()), 2); // ( % )
            }
            else
            {
                return 0;
            }   
        }

        # endregion

        # region Sérialisation (Méthodes de gestion du fichier de la liste)

        public static bool Sauvegarder()
        {
            try
            {
                if (DonneesModifiees)
                {
                    Stream S = File.OpenWrite(chemin_fichier);
                    BinaryFormatter B = new BinaryFormatter();
                    B.Serialize(S, Liste);
                    S.Close();
                    return true;
                }
                return false;
            }
            catch (Exception FileAccessDenied)
            {
                FileAccessDenied = new Exception("Le fichier refuse de s'enregistrer !");
                System.Windows.Forms.MessageBox.Show(FileAccessDenied.Message);
                return false;
            }
            
        }
        public static bool Charger()
        {
            if (File.Exists(chemin_fichier))
            {
                Stream S = File.OpenRead(chemin_fichier);               
                if (S != null)
                {
                    BinaryFormatter B = new BinaryFormatter();
                    Liste = (List<Emission>)B.Deserialize(S);
                    S.Close();
                    return true;
                }
            }
            return false;
        }

        # endregion
    }
}
