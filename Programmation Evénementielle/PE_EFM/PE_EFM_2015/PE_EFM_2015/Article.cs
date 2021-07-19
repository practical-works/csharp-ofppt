using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE_EFM_2015
{
    class Article
    {
        private int code;
        private string designation;
        private double prix;
        private string categorie;
        private double remise;

        public int Code
	    {
		    get { return code;}
		    set { code = value;}
	    }
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        public string Categorie
        {
            get
            {
                return categorie;
            }
            set
            {
                bool ValeurCategorieExiste = false;
                foreach (string S in liste_categories)
                {
                    if (value == S)
                    {
                        ValeurCategorieExiste = true;
                        break;
                    }
                }
                if (ValeurCategorieExiste)
                {
                    categorie = value;
                }
                else
                {
                    throw new Exception("Catégorie invalide!");
                }
            }
        }
        public double Prix
	    {
		    get { return prix;}
		    set { prix = value;}
	    }
        public double Remise
        {
            get { return remise; }
            set { remise = value; }
        }

        private static string[] liste_categories = { "Informatique", "Bureautique" };
        public static string[] ListeCategories { get { return liste_categories; } }

        public Article() { }
        public Article(int Code, string Designation, double Prix, string Categorie, double Remise)
        {
            this.code = Code;
            this.designation = Designation;
            this.prix = Prix;
            this.Categorie = Categorie;
            this.remise = Remise;
        }
    }
}
