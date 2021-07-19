using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace EX_1
{
   
    static class Program
    {
        public static ArrayList T = new ArrayList();
       
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
