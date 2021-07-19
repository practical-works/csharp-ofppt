using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace EX_3
{
    class Annuaire : IEnumerable
    {
        public SortedList col ;

        public Annuaire()
        {
            col = new SortedList();
        }
        public void Ajouter(string nom, string prénom, string Tel)
        {
            Personne p = new Personne(nom, prénom);
            col.Add(p,Tel);
        }
        public void Vider()
        {
            col.Clear();
        }
        public int Nombre
        {
            get { return col.Count; }
        }
        public bool ContientClé(string nom,string prénom)
        {

            return col.ContainsKey(new Personne(nom, prénom));
        }
        public bool ContientValeur(string Tel)
        { 
            return col.ContainsValue(Tel);
        }
        public string this[Personne p]
        {
            get
            {
                return col[p].ToString();

            }
               
            set
            {
                col[p] = value;
            }
        }
        public void Supprimer(string nom, string prénom)
        {
            Personne p = new Personne(nom, prénom);
             col.Remove(p);
        }
        public IEnumerator GetEnumerator()
        {
            return col.Keys.GetEnumerator();
        }





    }
}
