using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_3
{
     class Film
    {
        protected string code,titre,date,genre,langue;
        protected static int c = 0;

        public Film()
        {
            code = "anonyme";
            titre = "anonyme";
            date = "anonyme";
            genre = "anonyme";
            langue = "anonyme";
            c++;
        }
        public Film(string code,string titre,string date,string genre,string langue)
        {
            this.code =code;
            this.titre = titre;
            this.date = date;
            this.genre = genre;
            this.langue = langue;
            c++;
        }
        public Film(Film f)
        {
            code = f.code;
            titre = f.titre;
            date = f.date;
            genre =f. genre;
            langue = f.langue;
            c++;
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        public string Date
        {
            get { return date ; }
            set { date = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string Langue
        {
            get { return langue; }
            set { langue = value; }
        }
        
        public static int C
        {
            get { return c; }     
        }
        public string ToString()
        {
            return "Le code : " + code + "\nLe titre : " + titre + "\nLa date de sortie : " + date + "\nLe genre : "
                + genre + "\nLa langue : " + langue ;
        }
        public bool Equals(object obj)
        {
            Film f = (Film)obj;
            return this.code == f.code;
        }

    }
}
