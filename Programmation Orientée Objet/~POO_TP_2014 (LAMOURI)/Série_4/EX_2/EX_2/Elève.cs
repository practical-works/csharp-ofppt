using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
    class Elève : IComparable

    {
        private string nom;
        private double age;
        private double[] note;

        public Elève(string nom, double age, double[] note)
        {
              this.note = new double[3];

            this.nom = nom;
            this.age = age;
            for (int i = 0; i < 3; i++)
                this.note[i] = note[i];
          
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public double Age
        {
            get { return age; }
            set { age = value; }
        }
        public double[] Note
        {
            get { return note; }
            set { note = value; }
        }
        public double Moyenne()
        {
            double m = 0;
            for (int i = 0; i < 3; i++)
                m = m + note[i] / 3;
            return m;
        }
        public override string ToString()
        {
            return "Le nom : " + nom + "  L'age : " + age + "  \nLa note 1 : " + note[0] + "  La note 2 : " + note[1] + "  La note 3 : " + note[2]+"  La moyenne : "+Moyenne();
        }
        public override bool Equals(object obj)
        {
            Elève e = obj as Elève;
            return nom == e.nom;
        }
        public int CompareTo(object obj)
        {
            Elève e = obj as Elève;
            return -Moyenne().CompareTo(e.Moyenne());//e.Moyenne().CompareTo(Moyenne())
        }



    }
}
