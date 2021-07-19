using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO3_Ex5
{
    class InvalidAgeException : Exception
    {
        public override string Message
        {
            get
            {
                return "L'âge doit être entre 18 et 26";
            }
        }
    }
}
