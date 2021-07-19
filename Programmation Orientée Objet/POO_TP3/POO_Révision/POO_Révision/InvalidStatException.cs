using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Révision
{
    class InvalidStatException : Exception
    {
        public InvalidStatException() : base() { }

        public override string Message
        {
            get
            {
                return "This stat must be positif";
            }
        }
    }
}
