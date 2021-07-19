using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Contrôler_une_barre__TRACKBAR_
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
