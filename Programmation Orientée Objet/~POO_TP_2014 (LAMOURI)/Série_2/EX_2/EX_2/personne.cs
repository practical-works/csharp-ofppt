using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
     class  Personne
    {
        private int code,age;
        private string nom, prénom;
        private static int c = 0;

        public Personne()
        {
            code = 0;
            nom = "anonyme";
            prénom = "anonyme";
            age = 0;
            c++;
        }
        public Personne(int code,string nom,string prénom,int age)
        {
            this.code = code;
            this.nom = nom;
            this.prénom = prénom;
            this.age = age;
            c++;
        }
        public Personne(Personne p)
        {
            code = p.code;
            nom = p.nom;
            prénom = p.prénom;
            age = p.age;
            c++;
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
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
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public new static int C
        {
            get { return c; }
        }
        
        public new string ToString()
        {
            return "Le code : " + code + "\nLe nom : " + nom + "\nLe prénom : " + prénom + "\nL'age : " + age;
        }
        public new  bool Equals(object obj)
        {
            Personne p=(Personne)obj;
            return this.code == p.code;
        }


    }
}
