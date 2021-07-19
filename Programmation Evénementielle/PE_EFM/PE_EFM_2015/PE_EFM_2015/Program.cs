using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PE_EFM_2015
{
    static class Program
    {
        public static List<Article> Stock = new List<Article>();
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_GArticles());
        }
    }
}
