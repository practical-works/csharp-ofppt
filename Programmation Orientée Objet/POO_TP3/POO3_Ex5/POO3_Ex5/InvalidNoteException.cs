using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO3_Ex5
{
    class InvalidNoteException : Exception
    {
        public override string Message
        {
            get
            {
                return "La note doit être entre 0 et 20";
            }
        }
    }
}
