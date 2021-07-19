using System;
using System.Drawing;
using System.Windows.Forms;

namespace FicheClient
{
    public partial class Form_saisie : Form
    {
        private int fill = 0;

        public Form_saisie()
        {
            InitializeComponent();
            dateTimePicker_naissance.MaxDate = DateTime.Today;
            textBox_nom.Select();
        }

        private bool StringContainsDigits(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true; // Il contient au moins un nombre digital
                }
            }
            return false;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_nom.Text.Trim() == "" || StringContainsDigits(textBox_nom.Text.Trim()))
                errorProvider1.SetError(textBox_nom, "Le nom ne doit pas contenir de chiffres.");
            
            if (textBox_prenom.Text.Trim() == "" || StringContainsDigits(textBox_prenom.Text.Trim()))
                errorProvider1.SetError(textBox_prenom, "Le prénom ne doit pas contenir de chiffres.");
            
            if (textBox_adresse.Text.Trim() == "")
                errorProvider1.SetError(textBox_adresse, "L'adresse ne doit pas être vide.");
            
            int codePostal;
            if (!int.TryParse(textBox_codePostal.Text, out codePostal) || textBox_codePostal.Text.Length != 5 || codePostal == 0)
                errorProvider1.SetError(textBox_codePostal, "Le code postal doit comporter 5 chiffres et non nul.");
            
            if (textBox_ville.Text.Trim() == "" || StringContainsDigits(textBox_ville.Text.Trim()))
                errorProvider1.SetError(textBox_ville, "La ville ne doit pas contenir de chiffre.");
            
            bool no_errors = true;
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    if (errorProvider1.GetError((TextBox)ctrl) != "")
                    {
                        no_errors = false;
                        ctrl.BackColor = Color.IndianRed;
                        toolStripStatusLabel1.Text = "Erreurs de saisie";
                    }
                }
            }

            if (no_errors)
            {
                Form_consultation CONSULTATION = new Form_consultation();
                CONSULTATION.label_nom.Text = textBox_prenom.Text.Trim() + " " + textBox_nom.Text.Trim();
                CONSULTATION.label_adresse1.Text = textBox_adresse.Text.Trim();
                CONSULTATION.label_adresse2.Text = textBox_codePostal.Text.Trim() + " " + textBox_ville.Text.Trim();
                button_effacer.PerformClick();
                textBox_nom.Select();
                CONSULTATION.Show();
            }
        }

        private void button_effacer_Click(object sender, EventArgs e)
        {
            textBox_nom.Text = textBox_prenom.Text = textBox_adresse.Text = textBox_codePostal.Text = textBox_ville.Text = "";
            dateTimePicker_naissance.Value = DateTime.Today;
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
            
        }

        private void control_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, "");
            TextBox T = (TextBox)sender;
            T.BackColor = SystemColors.Window;
        }

        private void control_Validated(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            if (T.Text == "")
            {
                fill--;
                toolStripStatusLabel1.Text = "En attente de saisie";
            }
            else if (fill >= 5)
            {
                toolStripStatusLabel1.Text = "Prêt";
            }
            else
            {
                fill++;
            }
        }
    }
}
