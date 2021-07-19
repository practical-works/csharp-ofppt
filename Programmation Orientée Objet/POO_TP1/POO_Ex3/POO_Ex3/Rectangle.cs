using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex3
{
    class Rectangle
    {
        private double longueur, largeur;

        public double Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }
        
        public double Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public Rectangle(double longueur=0, double largeur=0)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public void AfficherRectangle()
        {
            string carre_ou_non = (EstCarre() == true) ? "Il s'agit d'un carré !" : "Il ne s'agit pas d'un carré.";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\tLongueur : " + longueur +
                              "\n\tLargeur : " + largeur +
                              "\n\tPérimètre : " + Perimetre() +
                              "\n\tAire : " + Aire() + "\n\t" +
                              carre_ou_non);
            Console.ResetColor();
        }

        private bool EstCarre()
        {
            if (longueur == largeur)
	        {
		        return true;
	        } else
	        {
                return false;
	        }
        }

        private double Aire()
        {
            return longueur * largeur;
        }

        private double Perimetre()
        {
            return 2 * (longueur + largeur);
        }


    }
}
