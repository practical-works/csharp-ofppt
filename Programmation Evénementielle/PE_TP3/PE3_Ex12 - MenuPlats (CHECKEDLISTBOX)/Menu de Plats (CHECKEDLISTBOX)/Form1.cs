using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu_de_Plats__CHECKEDLISTBOX_
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_commander_Click(object sender, EventArgs e)
        {
            string[] choix_tab = new string[checkedListBox_menu.Items.Count];
            checkedListBox_menu.CheckedItems.CopyTo(choix_tab, 0);
            string choix = string.Empty;
            for (int i = 0; i < checkedListBox_menu.CheckedItems.Count; i++)
            {
                choix += "\t" + choix_tab[i] + "\n";
            }
            MessageBox.Show("Votre Commande:\n\n" + choix,"Commande",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
}
