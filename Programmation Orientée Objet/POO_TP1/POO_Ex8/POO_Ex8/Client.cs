using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Ex8
{
    class Client
    {
        // Attributs
        private string cin, nom, prénom;
        private int téléphone;

        // Accesseurs
        public int Téléphone
        {
            get { return téléphone; }
            set { téléphone = value; }
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
        
        public string CIN
        {
            get { return cin; }
            set { cin = value; }
        }
        
        // Constructeurs
        public Client(string cin="", string nom="", string prénom="", int téléphone=0)
        {
            this.cin = cin;
            this.nom = nom;
            this.prénom = prénom;
            this.téléphone = téléphone;
        }

        public Client(string cin, string nom, string prénom)
        {
            this.cin = cin;
            this.nom = nom;
            this.prénom = prénom;
        }

        // Méthodes
        public void Afficher()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\tCIN: " + cin);
            Console.WriteLine("\t\tNom: " + nom);
            Console.WriteLine("\t\tPrénom: " + prénom);
            Console.WriteLine("\t\tTéléphone: " + téléphone);
            Console.ResetColor();
        }

    }
}
