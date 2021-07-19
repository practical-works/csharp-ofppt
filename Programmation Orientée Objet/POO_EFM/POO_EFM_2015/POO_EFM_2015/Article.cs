using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_EFM_2015
{
    class Article
    {
        protected int code;
        protected string designation;
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        protected double prix;
        protected string categorie;
        protected static string[] liste_categories = { "Informatique", "Bureautique" };
        
        public static string[] ListeCategories { get { return liste_categories; } }
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
                    throw new CategorieInvalideException();
                }
            }
        }

        public Article() { }
        public Article(int Code, string Designation, double Prix, string Categorie)
        {
            this.code = Code;
            this.designation = Designation;
            this.prix = Prix;
            this.Categorie = Categorie;
        }

        public virtual double getPrix()
        {
            return this.prix;
        }
        public virtual void setPrix(double Prix)
        {
            this.prix = Prix;
        }

        public override string ToString()
        {
            return "Code: " + this.code + ", Désignation: " + this.designation +
                ", Prix: " + this.prix + ", Catégorie: " + this.categorie;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj == this)
            {
                return true;
            }
            else if (obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Article A = (Article)obj;
                if (A.code ==  this.code && A.designation == this.designation 
                    && A.prix == this.prix && A.categorie == this.categorie)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
