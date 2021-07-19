using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionFichiers
{
    class Propriétaire
    {
        private int refProp;
        private string nomProp;

        public int Référence { get { return refProp; } set { refProp = value; } }
        public string Nom { get { return nomProp; } set { nomProp = value; } }

        public Propriétaire()
        {

        }
        public Propriétaire(int Référence, string Nom)
        {
            refProp = Référence;
            nomProp = Nom;
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
                Propriétaire P = (Propriétaire)obj;
                if (P.Référence == this.Référence)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override string ToString()
        {
            return "Référence: " + Référence + ", Nom: " + Nom;
        }
    }
}
