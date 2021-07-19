using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Commande
    {
        private int code, nombreArticle;
        private Article a = new Article();
         public Commande()
        {
            this.code = 0;
            this.nombreArticle = 0;
            this.a.Référence = "sans référence";
            this.a.Intitulé = "sans intitulé";
            this.a.PrixUnitaire = 0;
        }
        public Commande(int code,int nombreArticle,Article a)
        {
            this.code = code;
            this.nombreArticle = nombreArticle;
            this.a.Référence = a.Référence;
            this.a.Intitulé = a.Intitulé;
            this.a.PrixUnitaire =a.PrixUnitaire;
            
        }
        public Commande(Commande c)
        {
            this.code = c.code;
            this.nombreArticle = c.nombreArticle;
            this.a.Référence =c.a.Référence ;
            this.a.Intitulé = c.a.Intitulé;
            this.a.PrixUnitaire = c.a.PrixUnitaire;

        }
        public int  Code
        {
            get { return code; }
            set { code = value; }
        }
        public int NombreArticle
        {
            get { return nombreArticle; }
            set { nombreArticle = value; }
        }
        public Article A

        {
            get { return a; }
            set { a = value; }
        }
        public double Mantant(int nombreArticle, double prixUnitaire)
        {
            double m;
            m = nombreArticle * prixUnitaire;
            return m;
        }
    }
}
