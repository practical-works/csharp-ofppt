using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_EFM_2015
{
    class CategorieInvalideException : Exception
    {
        public override string Message
        {
            get
            {
                return "La catégorie entrée n'appartient pas à la liste des catégories définies.";
            }
        }
    }
}
