using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_2
{
    class InvalidNoteException : Exception
    {
        public InvalidNoteException() : base("La moyenne n'est pas valide,elle doit être entre 0 et 20") { }
                
    }
}
