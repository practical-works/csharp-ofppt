using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_EFM_2015
{
    class Achat
    {
        private int numero;
        private Article article_achete;
        private int quantite;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public Article ArticleAchete
        {
            get { return article_achete; }
            set { article_achete = value; }
        }
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
    }
}
