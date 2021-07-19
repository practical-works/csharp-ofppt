using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionEntités
{
    public partial class FormSaisie : Form
    {
        public bool edit_mode;

        public FormSaisie()
        {
            InitializeComponent();
        }

        public void RemplirChamps(Entité E)
        {
            textBox_code.Text = E.Code.ToString();
            textBox_nom.Text = E.Nom;
            textBox_valeur.Text = E.Valeur.ToString();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (edit_mode)
            {
                int code = int.Parse(textBox_code.Text);
                string nom = textBox_nom.Text.Trim();
                double valeur;
                if (nom == "")
                {
                    MessageBox.Show("Le nom est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_nom.Select();
                }
                else if (!double.TryParse(textBox_valeur.Text, out valeur))
                {
                    MessageBox.Show("La valeur est invalide ou vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_valeur.Select();
                }
                else
                {
                    Entité F = new Entité(code, nom, valeur);
                    EntitéListe.Modifier(code, F);
                    Close();
                }
            }
            else
            {
                int code;
                string nom = textBox_nom.Text.Trim();
                double valeur;
                if (!int.TryParse(textBox_code.Text, out code))
                {
                    MessageBox.Show("Le code est invalide ou vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_code.Select();
                }
                else if (EntitéListe.Rechercher(code) != -1)
                {
                    MessageBox.Show("Le code existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_code.Select();
                }
                else if (nom == "")
                {
                    MessageBox.Show("Le nom est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_nom.Select();
                }
                else if (!double.TryParse(textBox_valeur.Text, out valeur))
                {
                    MessageBox.Show("La valeur est invalide ou vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_valeur.Select();
                }
                else
                {
                    Entité E = new Entité(code, nom, valeur);
                    EntitéListe.Ajouter(E);
                    Close();
                }
            }
        }

        private void FormSaisie_Load(object sender, EventArgs e)
        {
            if (edit_mode) { textBox_code.ReadOnly = true; textBox_nom.Select(); }
            else { textBox_code.ReadOnly = false; textBox_code.Select(); }
        }
    }
}
