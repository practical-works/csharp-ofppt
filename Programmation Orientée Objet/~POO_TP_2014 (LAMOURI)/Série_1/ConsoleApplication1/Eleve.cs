using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Eleve
    {
        int i;
        private string nom, prénom;
        double[] note;
        


        public Eleve()
        {
            this.nom = "sans nom";
            this.prénom = "sans prénom";
            note = new double[3];
            for (i = 0; i <= 2; i++)
            {
                this.note[i] = 0;
            }
        }
        public Eleve(string nom, string prénom, double[] note)
        {
            this.nom = nom;
            this.prénom = prénom;
            this.note =new double[3];
            for (i = 0; i <= 2; i++)
            {
                this.note[i] =note[i];
            }
            
        }
        public Eleve(Eleve e)
        {
            this.nom = e.nom;
            this.prénom = e.prénom;
            this.note = new double[3];
            for (i = 0; i <= 2; i++)
            {
                this.note[i] = e.note[i];
            }
            
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prénom
        {
            get { return prénom; }
            set { prénom = value; }
        }
        public double[]Note
        {
            get { return note; }
            set { note = value; }
        }
        public double Moyenne()
        {
            double s = 0, m;
            for (i = 0; i < 3; i++)
            {
                s = s + note[i];
            }
            m = s / 3;
            return m;
        }


    }
}
