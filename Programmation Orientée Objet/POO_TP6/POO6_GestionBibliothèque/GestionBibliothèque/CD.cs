using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBibliothèque
{
    class CD : Ouvrage
    {
        private string artiste;
        private int nbr_pistes;

        public string Artiste { get { return artiste; } }
        public int NombrePistes { get { return nbr_pistes; } }

        public CD() : base()
        {

        }
        public CD(string Titre, string Artiste, int NombrePistes) : base(Titre)
        {
            artiste = Artiste;
            nbr_pistes = NombrePistes;
        }

        public override void Emprunter()
        {
            nbr_emprunt++;
            etat = false;
            Console.WriteLine("le CD " + titre + " a été emprunté avec succès");
        }
        public override void Retourner()
        {
            etat = true;
            Console.WriteLine("le CD " + titre + " a été retourné avec succès");
        }

        public override string ToString()
        {
            return base.ToString() + "\nArtiste: " + artiste + ", Nombre de pistes: " + nbr_pistes + ".";
        }
    }
}
