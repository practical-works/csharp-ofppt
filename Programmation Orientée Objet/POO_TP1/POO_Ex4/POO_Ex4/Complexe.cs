using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex4
{
    class Complexe
    {
        private double reel,imaginaire;

        public double Imaginaire
        {
            get { return imaginaire; }
            set { imaginaire = value; }
        }
        
        public double Reel
        {
            get { return reel; }
            set { reel = value; }
        }

        public Complexe(double re = 0, double im = 0)
        {
            reel = re;
            imaginaire = im;
        }

        public double getModule()
        {
            return Math.Sqrt(reel*reel + imaginaire*imaginaire);
        }
        public Complexe Plus(Complexe z)
        {
            Complexe somme = new Complexe();
            somme.reel = reel + z.reel;
            somme.imaginaire = imaginaire + z.imaginaire;
            return somme;
        }
        public Complexe Moins(Complexe z)
        {
            Complexe difference = new Complexe();
            difference.reel = reel - z.reel;
            difference.imaginaire = imaginaire - z.imaginaire;
            return difference;
        }
        public void Afficher()
        {
            Console.Write("{0}+{1}*i", reel,imaginaire);
        }

        public void SetComplexe()
        {
            Console.Write("Entrez la partie réelle: "); reel = double.Parse(Console.ReadLine());
            Console.Write("Entrez la partie imaginaire: "); imaginaire = double.Parse(Console.ReadLine());
            Console.Write("Expression du nombre complexe: ");
            Console.ForegroundColor = ConsoleColor.Green; Afficher(); Console.ResetColor();
        }
    }
}
