using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionHôtel
{
    class Chambre
    {                        
        private int numero;
        private string type;
        private double prix;
        private string categorie;
        private static string[] liste_types = { "Individuelle", "Double" };
        private static string[] liste_categories = { "Confort", "Luxe" };

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }        
        public string Type
        {
            get { return type; }
            set { type = value; }
        }        
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }        
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        public static string[] ListeTypes { get { return liste_types; } }
        public static string[] ListeCategories { get { return liste_categories; } }

        public Chambre()
        {

        }
        public Chambre(int Numero, string Type, double Prix, string Categorie)
        {
            this.Numero = Numero;
            this.Type = Type;
            this.Prix = Prix;
            this.Categorie = Categorie;
        }

        public override string ToString()
        {
            return "Chambre N°" + Numero + ", Type: " + Type + ", Prix: " + Prix + ", Catégorie: " + Categorie;
        }
    }
}
