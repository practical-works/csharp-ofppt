using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException()
            : base("L'âge non valide ,il doit être entre 18 et 26")
        { }
        

    }
}
