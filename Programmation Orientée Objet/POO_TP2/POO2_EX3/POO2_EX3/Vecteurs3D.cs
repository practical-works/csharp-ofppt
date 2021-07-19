using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2_EX3
{
    class Vecteur3D : Vecteur2D
    {
        private double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Vecteur3D() : base()
        {

        }
        public Vecteur3D(double x, double y, double z) : base(x,y)
        {
            this.z = z;
        }
        public Vecteur3D(Vecteur3D W) : base(W)
        {
            this.z = W.z;
        }

        public override string ToString()
        {
            return base.ToString() + " Z = " + z;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj == this)
            {
                return true;
            }
            else if (obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Vecteur3D W = (Vecteur3D)obj;
                if (this.x == W.x && this.y == W.y && this.z == W.z)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override double Norme()
        {
            return Math.Sqrt(X*X + y*y + z*z);
        }
    }
}
