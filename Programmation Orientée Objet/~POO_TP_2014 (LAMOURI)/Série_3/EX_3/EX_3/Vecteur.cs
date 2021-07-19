using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_3
{
    class Vecteur
    {
        private double[] cord;
        private static int nbre = 0;
        public Vecteur(params double[] cord)
        {
            this.cord = new double[cord.Length];
            for (int i = 0; i < cord.Length; i++)
                this.cord[i] = cord[i];
            
            nbre++;
        }
        public Vecteur(Vecteur v)
        {
            cord =new double[v.cord.Length];
            for (int i = 0; i < cord.Length; i++)
                cord[i] = v.cord[i];
            nbre++;
        }
        public double Norme()
        {
            double n = 0;
            for (int i = 0; i < cord.Length; i++)
            {
                n = n + (Math.Pow(cord[i], 2));
            }
            return Math.Sqrt(n);
        }
        public double this[int index]
        {

            get
            {
                if(index >= cord.Length)
                throw new IndexOutOfRangeException();
                else
                    return cord[index];
            }

                
                
            
            set
            {
                
                if(index >= cord.Length)
                throw new IndexOutOfRangeException();
                else
                      cord[index]=value;
            }
        }
        public static Vecteur operator +(Vecteur a, Vecteur b)
        { 
            
            if (a.cord.Length == b.cord.Length)
            {
                Vecteur c = new Vecteur();
                for (int i = 0; i < a.cord.Length; i++)
                {
                    c.cord[i] = a.cord[i] + b.cord[i];

                }
                return c;
            }
            else
                return null;
        }
        public static Vecteur operator*(Vecteur a,double b)
        {
                     
                Vecteur c = new Vecteur();
                for (int i = 0; i < a.cord.Length; i++)
                {
                    c[i] = a[i] * b;

                }
                return c;
            
        }
        public static Vecteur operator-(Vecteur a, Vecteur b)
        {
                         
              return  (a + (b * (-1)));
                
        }
           
        
        public static bool operator==(Vecteur a,Vecteur b)
        {
            
            if (a.cord.Length == b.cord.Length)
            {
                int i;
                for ( i = 0; i < a.cord.Length; i++)
                {
                    if (a[i] != b[i])
                     return false;
                }
             }  
            
            else
                return false;
              return true;        
        }
       
       public static bool operator !=(Vecteur a, Vecteur b)
        {
            bool c = a==b;

            if (c == true)
                c = false;

            else
                c = true;
            
            return c;


        }
        public static double operator *(Vecteur a, Vecteur b)
        {
           double c=0;
            if (a.cord.Length == b.cord.Length)
            {
                
                for (int i = 0; i < a.cord.Length; i++)
                {
                    c+=a[i] *b[i];

                }
                
            }
           return c;
        }

        public override string ToString()
        {
            string s = "(";
            for (int i = 0; i < cord.Length; i++)
            {
                s = s + cord[i].ToString();
                if (i != cord.Length - 1)
                    s = s + ",";
            }
            return s + ")";
        }

        }
             
             


 }

