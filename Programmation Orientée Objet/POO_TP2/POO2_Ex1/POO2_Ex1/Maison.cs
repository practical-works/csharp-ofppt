using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_Ex1
{
    class Maison : Batiment
    {
        private int nbpieces;

        public int NbPieces
        {
            get { return nbpieces; }
            set { nbpieces = value; }
        }

        public Maison() : base() 
        {
 
        }
        public Maison(string adresse, int nbpieces) : base(adresse)
        {
            this.nbpieces = nbpieces;
        }

        public override string ToString()
        {
            return base.ToString() + " ; Nombre de pièces: " + nbpieces + " pièces";
        }
    }
}
