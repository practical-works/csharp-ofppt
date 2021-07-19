using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_3
{
    class Personne : IComparable
    {
       private string prénom, nom;
       public Personne(string nom, string prénom)
       {
           this.nom = nom;
           this.prénom = prénom;
       }
       public string Nom
       {
           get { return nom; }
           set { nom = value; }
       }
       public string Prénom
       {
           get { return prénom; }
           set { prénom = value; }
       }
       public override string ToString()
       {
           return "Le nom : " + nom + "   Le prénom : " + prénom;
       }
       public override bool Equals(object obj)
       {
           Personne p = obj as Personne;
           return nom == p.nom && prénom == p.prénom;
       }
       public int CompareTo(object obj)
       {
           Personne p = (Personne)obj;
           return nom.CompareTo(p.nom);
       }


    }
}
