using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE_Passage_2015
{
    [ Serializable ]
    class Donneur
    {
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string GroupeSanguin { get; set; }
        public string RHESUS { get; set; }

        public Donneur(string CIN, string Nom, string Prenom, string GroupeSanguin, string RHESUS)
        {
            this.CIN = CIN;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.GroupeSanguin = GroupeSanguin;
            this.RHESUS = RHESUS;
        }
    }
}
