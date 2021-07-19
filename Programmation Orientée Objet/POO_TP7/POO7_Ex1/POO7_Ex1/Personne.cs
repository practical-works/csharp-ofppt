using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO7_Ex1
{
    class Personne : IComparable
    {
        private string nom, prenom;
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }

        public Personne(string Nom, string Prenom)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
        }

        public override string ToString()
        {
            return Nom + " " + Prenom;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj == this)
            {
                return true;
            }
            else if (obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Personne P = (Personne)obj;
                if (P.Nom == this.Nom && P.Prenom == this.Prenom)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            Personne P = (Personne)obj;
            if (P.Nom.CompareTo(this.Nom) == 0)
            {
                return P.Prenom.CompareTo(this.Prenom);
            }
            else
            {
                return P.Nom.CompareTo(this.Nom);
            }
        }
    }
}
