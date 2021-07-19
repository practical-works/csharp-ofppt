using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_5
{
    abstract class FormeGeometrique
    {
        private static int c = 0;

        public FormeGeometrique()
        {
            c++;
        }

        public static int C
        {
            get { return c; }
        }
        public abstract double Surface();

    }
}
