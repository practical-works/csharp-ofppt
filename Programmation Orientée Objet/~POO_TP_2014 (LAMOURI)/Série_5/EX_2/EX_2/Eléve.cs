using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
    class Eléve
    {
        string nom;
        int âge;
        double moyenne;

       public Eléve()
        {
            nom = "sans nom"; âge = 0; moyenne = 0;
        }
      public  Eléve(string nom,int âge,double moyenne)
        {
            
            this.nom = nom; Age = âge; Moyenne = moyenne;
            
        }
       public Eléve(Eléve e)
        {
            nom = e.nom; âge = e.âge; moyenne = e.moyenne;
        }
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        public int Age
        {
            get
            {
                return âge;
            }
            set
            {
                
                if (value < 18 || value > 26)
                    throw new InvalidAgeException();
                else
                    âge = value;
                
                
            }
        }
        public double Moyenne
        {
            get
            {
                return moyenne;
            }
            set
            {
               
                if (value < 0 || value > 20)
                    throw new InvalidNoteException();
               else
                    moyenne = value;
                
            }
        }
        public override string ToString()
        {
            return "Le nom : " + nom + "  L'âge : " + âge + "  La moyenne : " + moyenne;
        }
        public override bool Equals(object obj)
        {
            Eléve e = obj as Eléve;
            return nom == e.nom && âge == e.âge && moyenne == e.moyenne;
        }
    }
}
