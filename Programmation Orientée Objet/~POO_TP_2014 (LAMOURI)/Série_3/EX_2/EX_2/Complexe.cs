using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
    class Complexe
    {
        private double re, im;
        private static int nbre = 0;

        public Complexe()
        {
            re = 0;
            im = 0;
            nbre++;
        }

        public Complexe(params double[] pa)
        {
            if(pa.Length==1)
            {
            this.re =pa[0];
            this.im = 0;
            nbre++;
            }
             if(pa.Length==2)
             {
                 this.re = pa[0];
                 this.im = pa[1];
                 nbre++;
             }

        }
        //public Complexe( double re , double im )
        //{
        //    this.re =re ;
        //    this.im = im;
        //    nbre++;
        //}
        public Complexe(Complexe c)
        {
            re = c.re;
            im = c.im;
            nbre++;
        }
        
        public double Re
        {
            get { return re; }
            set { re = value; }
        }
        public double Im
        {
            get { return im; }
            set { im = value; }
        }
        public static int  Nbre
        {
            get { return nbre; }  
        }
        public double Module()
        {
            return Math.Sqrt((re * re + im * im));
        }
        public double this[int index]
        {
            get
            {
                if (index == 0)
                    return re;

                 if (index == 1)
                    return im;
                if (index == 2)
                    return this.Module();
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index == 0)
                {
                    re = value;
                    return;
                }

                if (index == 1)
                {
                    im = value;
                    return;
                }               
            }

        }
        public static Complexe operator +(Complexe a, Complexe b)
        {
            Complexe c = new Complexe();
            c.re = a.re + b.re;
            c.im = a.im + b.im;
            return c;
        }
        public static Complexe operator +(Complexe a,double b)
        {
            Complexe c = new Complexe();
            c.re = a.re + b;
            c.im = a.im;
            return c;
        }
        public static Complexe operator *(Complexe a, double b)
        {
            Complexe c = new Complexe();
            c.re = a.re * b;
            c.im = a.im*b;
            return c;
        }
        public static Complexe operator-(Complexe a, Complexe b)
        {
            Complexe c = new Complexe();
            c = a + (b * (-1));
            
            return c;
        }
        public static bool operator ==(Complexe a,Complexe b)
        {
            bool c=false;
            if (a.re == b.re && a.im == b.im)
                c = true;
            return c;
        }
        public static bool operator !=(Complexe a,Complexe b)
        {
            bool c=false;
            if (a.re != b.re ||( a.im != b.im))
                c = true;
            return c;
        }     
      //Z1=x1+iy1 et Z2=x2+iy2 alors Z1*Z2=(x1x2-y1y2) + i(x1y2+x2y1)
        public static Complexe operator *(Complexe a,Complexe b)
        {
            Complexe c = new Complexe();
            c.re = (a.re *b.re)-(a.im *b.im);
            c.im = (a.re *b.im)-(a.im *b.re);
            return c;
        }
        public override string ToString()
        {
            return re + "+ " + im + "i";
        }

            

            
        }


            }
        

    

