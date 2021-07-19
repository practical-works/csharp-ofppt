using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu_Commande
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_commander_Click(object sender, EventArgs e)
        {
            string commande = string.Empty;
            for (int i = 0; i < listBoxe_menu.SelectedItems.Count; i++)
            {
                commande += listBoxe_menu.SelectedItems[i] + "\n";
            }
            if (listBoxe_menu.SelectedItems.Count != 0)
            {
                MessageBox.Show("Votre Commande:\n\n" + commande,"Contenu de la commande");
            }
            else
            {
                MessageBox.Show("Vous n'avez rien choisi pour commander!","Commande vide",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
