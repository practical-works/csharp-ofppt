using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex6
{
    class Employé
    {
        private int matricule;
        private string nom, prénom;
        private DateTime datenaissance, dateembauche;
        private double salaire;
        
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        
        public DateTime DateEmbauche
        {
            get { return dateembauche; }
            set { dateembauche = value; }
        }
        
        public DateTime DateNaissance
        {
            get { return datenaissance; }
            set { datenaissance = value; }
        }
        
        public string Prénom
        {
            get { return prénom; }
            set { prénom = value; }
        }
        
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        
        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public Employé(int matricule = 0, string nom = "", string prénom = "",
                        DateTime dateembauche = new DateTime(), DateTime datenaissance = new DateTime())
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prénom = prénom;
            this.datenaissance = datenaissance;
            this.dateembauche = dateembauche;
        }

        public Employé()
        {
            matricule = 0;
            nom = "";
            prénom = "";
            datenaissance = new DateTime(1,1,1);
            dateembauche = new DateTime(1,1,1);
        }

        public int Age()
        {
            return DateTime.Today.Year - datenaissance.Year;
        }
        public int Anciennete()
        {
            return DateTime.Today.Year - dateembauche.Year;
        }
        public void AugmentationDuSalaire()
        {
            //Si Ancienneté < 5 ans, alors on ajoute 2%. - Si Ancienneté < 10 ans, alors on ajoute 5%. - Sinon, on ajoute 10%.
            if (Anciennete() < 5)
            {
                salaire += 0.02 * salaire;
            }
            else if (Anciennete() < 10)
            {
                salaire += 0.05 * salaire;
            } else
	        {
                salaire += 0.1 * salaire;
	        }
        }
        public void AfficherEmployé()
        {
            Console.WriteLine("\t\tMatricule: " + matricule);
            Console.WriteLine("\t\tNom Complet: " + nom.ToUpper() + " " + char.ToUpper(prénom[0]) + prénom.Substring(1).ToLower());
            Console.WriteLine("\t\tAge: " + Age());
            Console.WriteLine("\t\tAncienneté" + Anciennete());
            Console.WriteLine("\t\tSalaire :" + salaire);
        }

    }
}
