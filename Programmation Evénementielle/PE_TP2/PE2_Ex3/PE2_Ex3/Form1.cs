using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE2_Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_afficher_Click(object sender, EventArgs e)
        {
            string titre = string.Empty;
            if (!string.IsNullOrWhiteSpace(textBox_nom.Text))
            {
                if (radioButton_homme.Checked) titre = "Monsieur";
                if (radioButton_femme.Checked)
                {
                    if (radioButton_célibataire.Checked)
                    {
                        titre = "Mademoiselle";
                    }
                    else
                    {
                        titre = "Madame";
                    }
                }
                MessageBox.Show("Bienvenue " + titre + " " + textBox_nom.Text + ".");
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom!", "Attention!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
