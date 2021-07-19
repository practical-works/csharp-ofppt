using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE2_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculer_Click(object sender, EventArgs e)
        {
            double nombre1, nombre2, résultat = 0;
            if (double.TryParse(textBox_nombre1.Text, out nombre1) && double.TryParse(textBox_nombre2.Text, out nombre2))
            {
                if (radioButton_addition.Checked)
                {
                    label_signe.Text = "+";
                    résultat = nombre1 + nombre2;
                }
                else if (radioButton_soustraction.Checked)
                {
                    label_signe.Text = "-";
                    résultat = nombre1 - nombre2;
                }
                else if (radioButton_multiplication.Checked)
                {
                    label_signe.Text = "*";
                    résultat = nombre1 * nombre2;
                }
                else if (radioButton_division.Checked)
                {
                    label_signe.Text = "/";
                    if (nombre2 != 0)
                    {
                        résultat = nombre1 / nombre2;
                    }
                    else
                    {
                        MessageBox.Show("Division par zéro impossible!", "Erreur mathématique!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                textBox_résultat.Text = résultat.ToString();
            }
            else
            {
                MessageBox.Show("Données invalides!","Erreur!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            radioButton_addition.Checked = true;
            label_signe.Text = string.Empty;
            textBox_nombre1.Text = string.Empty;
            textBox_nombre2.Text = string.Empty;
            textBox_résultat.Text = string.Empty;
            textBox_nombre1.Focus();

        }

    }
}
