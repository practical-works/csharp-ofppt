using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EX_4
{
    class Service : IEnumerable
    {
        Dictionary<string, Salarié> col;

        public Service()
        {
            col = new Dictionary<string, Salarié>();
        }

        public void Ajouter(string matricule, string nom, int annéeRecrutement, double salaire)
        {
            Salarié s = new Salarié(nom, annéeRecrutement, salaire);
            col.Add(matricule, s);
        }
        public void Vider()
        {
            col.Clear();
        }
        public int Nombre
        {
            get { return col.Count; }
        }
        public bool ContientClé(string matricule)
        {
            return col.ContainsKey(matricule);
        }
        public Salarié this[string matricule]
        {
            get
            {
                return col[matricule];
            }
            set
            {
                col[matricule] = value;
            }

        }
        public void Supprimer(string matricule)
        {
            col.Remove(matricule);
        }
        public IEnumerator GetEnumerator()
        {
            return col.Keys.GetEnumerator();
        }
    }
}

