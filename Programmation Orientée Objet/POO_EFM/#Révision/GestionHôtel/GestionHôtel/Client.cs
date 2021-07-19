using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionHôtel
{
    class Client : Personne
    {
        private int numero;

        public int Numero { get { return numero; } set { numero = value; } }

        public Client() : base()
        {

        }
        public Client(int Numero, string Nom, string Prenom, string Adresse)
            : base(Nom, Prenom, Adresse)
        {
            this.Numero = Numero;
        }

        public override string ToString()
        {
            return "N°" + Numero + "\n" + base.ToString();
        }
    }
}
