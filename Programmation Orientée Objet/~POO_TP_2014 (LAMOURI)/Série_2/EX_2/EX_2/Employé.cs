using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
    class Employé:Personne
    {
        private string grade;
        private static int c = 0;

        public Employé()
            : base()
        {
            grade = "anonyme";
            c++;
        }
        public Employé(int code, string nom, string prénom, int age, string grade)
            : base(code, nom, prénom, age)
        {
            this.grade = grade;
            c++;
        }
        public Employé(Employé e)
            : base(e.Code, e.Nom, e.Prénom, e.Age)
        {
            e.grade = grade;
            c++;
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public new static int C
        {
            get { return c; }
        }

        public new string ToString()
        {
            return base.ToString() + "\nLe grade :" + grade;
        }
        public new bool Equals(object obj)
        {
            Employé e = (Employé)obj;
            return this.Code == e.Code;
        }


    }
}
