using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Liste_de_Villes
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            textBox_ville.Focus();
            button_rechercher.Enabled = false;
            button_ajouter.Enabled = false;
            button_supprimer.Enabled = false;

        }

        private void textBox_ville_TextChanged(object sender, EventArgs e)
        {
            button_rechercher.Enabled = (textBox_ville.Text.Trim() != "") ? true : false;
            button_ajouter.Enabled = (textBox_ville.Text.Trim() != "") ? true : false;
            button_supprimer.Enabled = (textBox_ville.Text.Trim() != "") ? true : false;
            if (textBox_ville.Modified) listBox_villes.ClearSelected();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            bool AlreadyExist = false;
            if (listBox_villes.Items.Contains(textBox_ville.Text))
            {
                    AlreadyExist = true;
                    listBox_villes.SelectedItem = textBox_ville.Text;
            }
            if (!AlreadyExist)
            {
                if (!string.IsNullOrWhiteSpace(textBox_ville.Text))
                {
                    listBox_villes.Items.Add(textBox_ville.Text.Trim());
                    textBox_ville.Text = "";
                    textBox_ville.Focus();
                }
            }
            else
            {
                MessageBox.Show("La ville que vous désirez ajouter existe déjà dans la liste.","Remarque",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            if (listBox_villes.Items.Contains(textBox_ville.Text))
            {
                listBox_villes.Items.Remove(textBox_ville.Text);
            }
            else
            {
                MessageBox.Show("La ville que vous désirez supprimer n'existe pas dans la liste.", "Remarque", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button_trier_Click(object sender, EventArgs e)
        {
            listBox_villes.Sorted = true;
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            listBox_villes.Items.Clear();
            button_trier.Enabled = false;
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            if (listBox_villes.Items.Contains(textBox_ville.Text))
            {
                listBox_villes.SelectedItem = textBox_ville.Text;
            }
            else
            {
                MessageBox.Show("La ville que vous recherchez est introuvable.", "Remarque", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void listBox_villes_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_trier.Enabled = (listBox_villes.Items.Count != 0) ? true : false;
            if (listBox_villes.SelectedIndex != -1) textBox_ville.Text = (string)listBox_villes.SelectedItem;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            listBox_villes.SelectedItem = textBox_ville.Text;
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msg_quitter = MessageBox.Show("Voulez-vous quitter le programme ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg_quitter == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}
