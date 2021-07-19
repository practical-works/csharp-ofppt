using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sérialisation
{
    class InvalidAgeException  : Exception 
    {
        public InvalidAgeException() : base("L'age invalid,il doit être un entier positif") { }

    }
}
