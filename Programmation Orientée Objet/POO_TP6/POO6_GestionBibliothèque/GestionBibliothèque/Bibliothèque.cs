using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBibliothèque
{
    class Bibliothèque
    {
        private List<Ouvrage> Biblio = new List<Ouvrage>();

        public bool Ajouter(Ouvrage O) // Ajouter un ouvrage (Livre ou CD) à la bibliothèque.
        {
            if (Rechercher(O.Code) == -1)
            {
                Biblio.Add(O);
                return true;
            }
            return false;
        }

        public int Rechercher(int Code) // Rechercher un ouvrage par code. (afficher son type).
        {
            return Biblio.FindIndex(item => item.Code == Code);
        }
        public int RechercherLivre(int Code) // Rechercher un Livre par code.
        {
            return Biblio.FindIndex(item => item is Livre && item.Code == Code);
        }
        public int RechercherCD(int Code) // Rechercher un CD par code.
        {
            return Biblio.FindIndex(item => item is CD && item.Code == Code);
        }

        public int Rechercher(string Titre) // Rechercher un ouvrage par titre.
        {
            return Biblio.FindIndex(item => item.Titre.ToLower() == Titre.ToLower());
        }
        public int Rechercher(string Titre, Type TypeOuvrage) // Rechercher un ouvrage par titre et type.
        {
            return Biblio.FindIndex(item => item.GetType() == TypeOuvrage  && item.Titre.ToLower() == Titre.ToLower());
        }

        public bool Supprimer(int Code) // Supprimer un ouvrage.
        {
            if (Rechercher(Code) != -1)
            {
                Biblio.RemoveAt(Rechercher(Code));
                return true;
            }
            return false;
        }
        public void AfficherTout() // Afficher tous les ouvrages.
        {
            foreach (Ouvrage O in Biblio)
            {
                Console.WriteLine(O);
            }
        }
        public void AfficherParType() // Afficher tous les ouvrages classés par type.
        {
            Console.WriteLine("Livres:");
            foreach (Ouvrage O in Biblio)
            {
                if (O is Livre)
                {
                    Console.WriteLine(O);
                }
            }
            Console.WriteLine("CDs:");
            foreach (Ouvrage O in Biblio)
            {
                if (O is CD)
                {
                    Console.WriteLine(O);
                }
            }
        }
        public void AfficherParNbrEmprunt() // Afficher les ouvrages triés par ordre croissant de nombres d’emprunt.
        {
            List<Ouvrage> Biblio2 = Biblio;
            int i = Biblio2.Count, j;
            bool echange = true;
            Ouvrage tmp;
            while ( i>0 && echange ) 
            {   
		        echange = false;
                for (j=0; j<i-1; j++) 
                {   
			        if (Biblio2[j].NombreEmprunt < Biblio2[j+1].NombreEmprunt) 
                        {
                          tmp = Biblio2[j];
                          Biblio2[j] = Biblio2[j+1];
                          Biblio2[j+1] = tmp;
                          echange = true;
                        } 
		        }
            i--;
            }
            foreach (Ouvrage O in Biblio2)
            {
                Console.WriteLine(O);
            }
        }

        public bool Emprunter(Ouvrage O) // Emprunter un ouvrage.
        {
            if (O.Etat)
            {
                O.Emprunter();
                return true;
            }
            return false;
        }
        public bool Retourner(Ouvrage O) // Retourner un ouvrage.
        {
            if (!O.Etat)
            {
                O.Retourner();
                return true;
            }
            return false;
        }
    }
}
