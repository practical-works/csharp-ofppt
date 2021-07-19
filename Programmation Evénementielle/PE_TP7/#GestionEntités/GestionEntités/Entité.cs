using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEntités
{
    public class Entité
    {
        public int Code { get; set; }
        public string Nom { get; set; }
        public double Valeur { get; set; }

        public Entité() { }
        public Entité(int Code, string Nom, double Valeur)
        {
            this.Code = Code;
            this.Nom = Nom;
            this.Valeur = Valeur;
        }

        public override string ToString()
        {   
            return "#" + Code + " " + Nom + " (" + Valeur + ")"; 
            // Exemple: #17 Mohamed (20.75)
        }
    }
}
