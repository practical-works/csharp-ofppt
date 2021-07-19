using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace GestionHôtel
{
    class Hotel
    {
        string nom;
        string adresse;
        string ville;
        Personnel dirigeant;
        ArrayList chambres;

        string Nom { get { return nom; } set { nom = value; } }
        string Adresse { get { return adresse; } set { adresse = value; } }
        string Ville { get { return ville; } set { ville = value; } }
        Personnel Dirigeant { get { return dirigeant; } set { dirigeant = value; } }
        ArrayList Chambres { get { return chambres; } set { chambres = value; } }

        public Hotel()
        {
            this.Dirigeant = new Personnel();
            this.chambres = new ArrayList();
        }
        public Hotel(string Nom, string Adresse, string Ville, Personnel Dirigeant, ArrayList Chambres)
        {
            this.Nom = Nom;
            this.Adresse = Adresse;
            this.Ville = Ville;

            this.Dirigeant = new Personnel();
            this.Dirigeant.Matricule = Dirigeant.Matricule;
            this.Dirigeant.Nom = Dirigeant.Nom;
            this.Dirigeant.Prenom = Dirigeant.Prenom;
            this.Dirigeant.Fonction = Dirigeant.Fonction;
            this.Dirigeant.Adresse = Dirigeant.Adresse;

            this.Chambres = new ArrayList();
            this.Chambres.AddRange(Chambres);
        }

        public override string ToString()
        {
            return "Hotêl: " + Nom + ", Adresse: " + Adresse + ", " + Ville + "\n"
                + "Dirigeant: " + Dirigeant.ToString() + "\n"
                + "Nombre Chambres: " + Chambres.Count;
        }
        public bool AjouterChambre(Chambre C)
        {
            int p = RechercherChambre(C.Numero);
            if (p == -1)
            {
                Chambres.Add(C);
                return true;
            }
            return false;
        }
        public bool SupprimerChambre(int Numero)
        {
            int p = RechercherChambre(Numero);
            if (p != -1)
            {
                Chambres.RemoveAt(p);
                return true;
            }
            return false;
        }
        public int RechercherChambre(int Numero)
        {
            foreach (Chambre C in Chambres)
            {
                if (C.Numero == Numero)
                {
                    return Chambres.IndexOf(C);
                }
            }
            return -1;
        }
        public int NombreChambre()
        {
            return Chambres.Count;
        }
        public List<string> AfficherListesChambres()
        {
            List<string> S = new List<string>();
            foreach (Chambre C in Chambres)
            {
                S.Add(S.ToString());
            }
            return S;
        }
        public string AfficherDirigeant()
        {
            return Dirigeant.ToString();
        }
        public void EffacerDirigeant()
        {
            Dirigeant = null;
            Dirigeant = new Personnel();
        }
        public List<Chambre> AfficherChambresIndividuelles()
        {
            List<Chambre> ChambresIndividuelles = new List<Chambre>();
            foreach (Chambre C in Chambres)
            {
                if (C.Type == Chambre.ListeTypes[0])
                {
                    ChambresIndividuelles.Add(C);
                }
            }
            return ChambresIndividuelles;
        }
        public List<Chambre> AfficherChambresDouble()
        {
            List<Chambre> ChambresDouble = new List<Chambre>();
            foreach (Chambre C in Chambres)
            {
                if (C.Type == Chambre.ListeTypes[1])
                {
                    ChambresDouble.Add(C);
                }
            }
            return ChambresDouble;
        }
        public List<Chambre> AfficherChambresLuxes()
        {
            List<Chambre> ChambresLuxes = new List<Chambre>();
            foreach (Chambre C in Chambres)
            {
                if (C.Categorie == Chambre.ListeCategories[1])
                {
                    ChambresLuxes.Add(C);
                }
            }
            return ChambresLuxes;
        }
        public List<Chambre> AfficherChambresConforts()
        {
            List<Chambre> ChambresConforts = new List<Chambre>();
            foreach (Chambre C in Chambres)
            {
                if (C.Categorie == Chambre.ListeCategories[0])
                {
                    ChambresConforts.Add(C);
                }
            }
            return ChambresConforts;
        }
        public double PrixMax()
        {
            Chambre C0 = (Chambre)Chambres[0];
            double PrixMax = C0.Prix;
            foreach (Chambre C in Chambres)
            {
                if (C.Prix >= PrixMax)
                {
                    PrixMax = C.Prix;
                }
            }
            return PrixMax;
        }
        public double PrixMin()
        {
            Chambre C0 = (Chambre)Chambres[0];
            double PrixMin = C0.Prix;
            foreach (Chambre C in Chambres)
            {
                if (C.Prix <= PrixMin)
                {
                    PrixMin = C.Prix;
                }
            }
            return PrixMin;
        }
        public List<Chambre> AfficherChambresPrixMax()
        {
            List<Chambre> ChambresPrixMax = new List<Chambre>();
            foreach (Chambre C in Chambres)
            {
                if (C.Prix == PrixMax())
                {
                    ChambresPrixMax.Add(C);
                }
            }
            return ChambresPrixMax;
        }
        public List<Chambre> AfficherChambresPrixMin()
        {
            List<Chambre> ChambresPrixMin = new List<Chambre>();
            foreach (Chambre C in Chambres)
            {
                if (C.Prix == PrixMin())
                {
                    ChambresPrixMin.Add(C);
                }
            }
            return ChambresPrixMin;
        }
        public List<Chambre> AfficherChambresPrixMinLuxe()
        {
            List<Chambre> ChambresPrixMinLuxe = new List<Chambre>();
            foreach (Chambre C in AfficherChambresLuxes())
            {
                if (C.Prix == PrixMin())
                {
                    ChambresPrixMinLuxe.Add(C);
                }
            }
            return ChambresPrixMinLuxe;
        }
        public List<Chambre> AfficherChambresPrixMinDouble()
        {
            List<Chambre> ChambresPrixMinDouble = new List<Chambre>();
            foreach (Chambre C in AfficherChambresDouble())
            {
                if (C.Prix == PrixMin())
                {
                    ChambresPrixMinDouble.Add(C);
                }
            }
            return ChambresPrixMinDouble;
        }
    }
}
