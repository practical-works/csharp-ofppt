using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jeu_de_Loterie
{
    public partial class Form_Game : Form
    {
        public Form_Game()
        {
            InitializeComponent();
            timer_T.Interval = 10;
            label_coups.Text = coups.ToString();
        }
        int nombre = 0, coups = 3;
        private void button_validerNombre_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_nombre.Text, out nombre))
            {
                if (nombre >= 1 && nombre <= 10)
                {
                    textBox_nombre.Enabled = false;
                    groupBox_jeu.Enabled = true;
                }
                else
                {
                    ToolTip nombre_incorrect = new ToolTip();
                    nombre_incorrect.ToolTipIcon = ToolTipIcon.Warning;
                    nombre_incorrect.Show("Entrez un nombre entre 1 et 10", textBox_nombre,2000);
                }
            }
            else
            {
                ToolTip nombre_incorrect = new ToolTip();
                nombre_incorrect.ToolTipIcon = ToolTipIcon.Warning;
                nombre_incorrect.Show("Entrez un nombre valide", textBox_nombre,2000);
            }

        }

        private void button_demarrer_Click(object sender, EventArgs e)
        {
            timer_T.Start();
            button_demarrer.Enabled = false;
            button_arreter.Enabled = true;
            coups--;
            label_coups.Text = coups.ToString();
        }

        private void button_arreter_Click(object sender, EventArgs e)
        {
            timer_T.Stop();
            button_arreter.Enabled = false;
            int nombre1 = int.Parse(label_nombre1.Text);
            int nombre2 = int.Parse(label_nombre2.Text);
            int nombre3 = int.Parse(label_nombre3.Text);
            if (nombre1 == nombre || nombre2 == nombre || nombre3 == nombre)
            {
                label_resultat.Text = "Gagné!";
                label_resultat.ForeColor = Color.Green;
            }
            else
            {
                label_resultat.Text = "Perdu!";
                label_resultat.ForeColor = Color.Red;
            }

            if (coups > 0)
            {
                button_demarrer.Enabled = true;
            }
            else
            {
                label_resultat.Text = "GAME OVER!";
                label_resultat.ForeColor = Color.Gray;
            }

            
        }

        private void button_recommencer_Click(object sender, EventArgs e)
        {
            textBox_nombre.Enabled = true;
            groupBox_jeu.Enabled = false;
            label_nombre1.Text = label_nombre2.Text = label_nombre3.Text = "0";
            label_resultat.Text = "";
            textBox_nombre.Focus(); textBox_nombre.SelectAll();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_T_Tick(object sender, EventArgs e)
        {
            Random nombre_aleatoire = new Random();
            label_nombre1.Text = nombre_aleatoire.Next(1, 10).ToString();
            label_nombre2.Text = nombre_aleatoire.Next(1, 10).ToString();
            label_nombre3.Text = nombre_aleatoire.Next(1, 10).ToString();
        }

        private void label_miseArgent_Click(object sender, EventArgs e)
        {

        }
    }
}
