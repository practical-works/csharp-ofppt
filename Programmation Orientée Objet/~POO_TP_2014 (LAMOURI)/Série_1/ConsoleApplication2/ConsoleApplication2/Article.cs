using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Article
    {
        private string référence, intitulé;
        private double prixUnitaire;

        public Article()
        {
            this.référence = "sans référence";
            this.intitulé = "sans intitulé";
            this.prixUnitaire = 0;
        }
        public Article(string référence,string intitulé,double prixUnitaire)
        {
            this.référence = référence;
            this.intitulé = intitulé;
            this.prixUnitaire = prixUnitaire;
        }
        public Article(Article a)
        {
            this.référence = a.référence;
            this.intitulé = a.intitulé;
            this.prixUnitaire = a.prixUnitaire;
        }
        public string Référence
        {
            get { return référence; }
            set { référence = value; }
        }
        public string Intitulé
        {
            get { return intitulé; }
            set { intitulé = value; }
        }
        public double PrixUnitaire
        {        
            get { return prixUnitaire ; }
            set { prixUnitaire = value; }
        }
        


    }
}
