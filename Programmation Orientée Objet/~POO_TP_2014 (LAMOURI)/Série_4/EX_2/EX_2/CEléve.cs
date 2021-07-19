using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EX_2
{
    class CEléve : IEnumerable
    {
        public List<Elève> col ;

        public CEléve()
        {
            col = new List<Elève>();
        }
        public void Add(string nom,double age, double[] note)
        {
            col.Add(new Elève(nom, age, note));
        }
        public void Clear()
        {
            col.Clear();
        }
        public int Count
        {
            get { return col.Count; }
        }
        public Elève this[int index]
        {
            get{return col[index];}
            set { col[index] = value; }
        }
        public int IndexOf(Elève e)
        {
            return col.IndexOf(e);
        }
        public void Delete(int index)
        {
            col.RemoveAt(index);
        }
        public void Sort()
        {
            col.Sort();
        }
        public IEnumerator GetEnumerator()
        {
            return col.GetEnumerator();
        }

             




    }
}
