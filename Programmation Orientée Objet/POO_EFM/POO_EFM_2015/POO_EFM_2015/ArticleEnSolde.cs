using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_EFM_2015
{
    class ArticleEnSolde : Article
    {
        private double remise;
        public double Remise
        {
            get { return remise; }
            set { remise = value; }
        }

        public ArticleEnSolde() : base() { }
        public ArticleEnSolde(int Code, string Designation, double Prix, string Categorie, double Remise) 
            : base(Code, Designation, Prix, Categorie)
        {
            this.remise = Remise;
        }

        public override double getPrix()
        {
            return this.prix + (this.remise/100) * this.prix;
        }
    }
}
