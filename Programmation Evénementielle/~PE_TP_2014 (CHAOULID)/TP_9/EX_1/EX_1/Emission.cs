using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_1
{
    
  [Serializable()]class Emission
    {
        int numEmission;
        string nom;
        DateTime dateEmission;
        string heure, duree;
        string typeEmission;
       [NonSerialized] public static bool C = false;

        public Emission(int numEmission, string nom, DateTime dateEmission, string heure, string duree, string typeEmission)
        {
            this.numEmission = numEmission;
            this.nom = nom;
            this.dateEmission = dateEmission;
            this.heure = heure;
            this.duree = duree;
            this.typeEmission = typeEmission;
        }

        public int NumEmission
        {
            get { return numEmission; }
            set { numEmission = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public DateTime DateEmission
        {
            get { return dateEmission; }
            set { dateEmission = value; }
        }
        public string Heure
        {
            get { return heure; }
            set { heure = value; }
        }
        public string Duree
        {
            get { return duree; }
            set { duree = value; }
        }
        public string TypeEmission
        {
            get { return typeEmission; }
            set { typeEmission = value; }
        }
    }
}
