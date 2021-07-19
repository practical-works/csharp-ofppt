using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_1
{
    class Vecteur3D:Vecteur2D
    {
        protected double z;
       protected new static int c = 0;

        public Vecteur3D(): base()    
        {
            z = 0;
            c++;
        }
        public Vecteur3D(double x,double y,double z):base(x,y)
           
        {
            this.z=z;
            c++;
        }
        public Vecteur3D(Vecteur3D v): base(v.X,v.Y)
            
        {
            z = v.z;
            c++;
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public new static int C
        {
            get { return c; }
        }
        
        public new string ToString()
        {
            return base.ToString()+"  Z=" + z;
        }
        public new bool Equals(object obj)
        {
            Vecteur3D v=(Vecteur3D)obj;
            return this.x == v.x && this.y == v.y && this.z == v.z;
        }
        public new double Norme()
        {
            return Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));
        }

    }
}

