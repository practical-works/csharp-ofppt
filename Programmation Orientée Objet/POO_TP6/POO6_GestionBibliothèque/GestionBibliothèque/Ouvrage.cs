using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBibliothèque
{
    abstract class Ouvrage
    {
        private int code;
        protected string titre;
        protected bool etat = true;
        protected int nbr_emprunt = 0;
        private static int nbr_ouvrages = 0;

        public int Code { get { return code; } }
        public string Titre { get { return titre; } }
        public bool Etat { get { return etat; } }
        public int NombreEmprunt { get { return nbr_emprunt; } }
        public static int NombreOuvrages { get { return nbr_ouvrages; } }

        public Ouvrage()
        {
            nbr_ouvrages++;
            code = nbr_ouvrages;
        }
        public Ouvrage(string Titre)
        {
            nbr_ouvrages++;
            code = nbr_ouvrages;
            titre = Titre;
        }

        public abstract void Emprunter();
        public abstract void Retourner();

        public override string ToString()
        {
            return "[N°" + code + "] Titre: " + titre + ", Etat: " + etat + ", Emprunté " + nbr_emprunt + " fois.";
        } 
    }
}
