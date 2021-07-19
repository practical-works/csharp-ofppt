using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex9
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            AcceptButton = button_vérifier;
            
        }

        private void button_vérifier_Click(object sender, EventArgs e)
        {
            int nombre;
            bool est_premier = true;
            if (int.TryParse(text_nombre.Text,out nombre))
            {
                if (nombre>=0)
                {
                    if (nombre != 0 && nombre != 1) { 
                        for (int i = 2; i < nombre; i++)
                        {
                            if (nombre % i == 0)
                            {
                                est_premier = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        est_premier = false;
                    }
                    
                    if (est_premier)
                    {
                        label_résultat.ForeColor = Color.Green;
                        label_résultat.Text = "Le nombre " + nombre + " est PREMIER.";
                    }
                    else
                    {
                        label_résultat.ForeColor = Color.Red;
                        label_résultat.Text = "Le nombre " + nombre + " N'EST PAS premier.";

                    }
                }
                else
                {
                    MessageBox.Show("L'entier doit être positif.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Entrez un nombre valide.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
