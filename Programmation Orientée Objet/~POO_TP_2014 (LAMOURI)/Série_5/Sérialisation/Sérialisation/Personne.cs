using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sérialisation
{
    [Serializable()]
    class Personne
    {
        private string nom, prénom;
       [NonSerialized()] private int age;

        public Personne()
        {
            nom = "Arhda ardatoran";
            prénom = "Karti mkabbatha";
            age = 1;
            
        }
        public Personne(string nom, string prénom, int age)
        {
            this.nom = nom;
            this.prénom = prénom;
            Age = age;
            
        }
        public Personne(Personne p)
        {
            nom = p.nom;
            prénom = p.prénom;
            age = p.age;
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
        public string Prénom
        {
            get
            {
                return prénom;
            }
            set
            {
                prénom = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                    throw new InvalidAgeException();
                age = value;
                
            }
        }
        public override string ToString()
        {
            return "Le nom : " + nom + "  Le prénom : " + prénom + "  L'age : " + age;
        }
        public override bool Equals(object obj)
        {
            Personne p = obj as Personne;
            return nom == p.nom && prénom == p.prénom && age == p.age;
        }




    }
}
