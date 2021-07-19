using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE8_GestionTV
{
    [Serializable]
    class Emission
    {
        public int Numero { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public string Heure { get; set; }
        public int Duree { get; set; }
        public string Type { get; set; }

        private static string[] liste_types = { "Information", "Fiction", "Sport", "Documentaire" };
        public static string[] ListeTypes { get { return liste_types; } }

        public Emission() { }
        public Emission(int Numero, string Nom, DateTime Date, string Heure, int Duree, string Type)
        {
            this.Numero = Numero;
            this.Nom = Nom;
            this.Date = Date;
            this.Heure = Heure;
            this.Duree = Duree;
            this.Type = Type;
        }
    }
}
