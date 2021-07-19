using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE2_Ex4
{
    public partial class Form_Conversion : Form
    {
        public Form_Conversion()
        {
            InitializeComponent();
        }

        private void TextClear(int choix)
        {
            switch (choix)
            {
                case 0: textBox_change.Text = textBox_first.Text = textBox_second.Text = string.Empty; break;
                case 1: textBox_first.Text = textBox_second.Text = string.Empty; break;
                default: ArgumentException Exception = new ArgumentException();
                    MessageBox.Show(Exception.Message);
                    break;
            }
            
        }

        private void radioButton_dhTOeuro_CheckedChanged(object sender, EventArgs e)
        {
            label_first.Text = "Montant en DH :";
            label_second.Text = "Montant en EURO :";
            TextClear(1);
        }

        private void radioButton_euroTOdh_CheckedChanged(object sender, EventArgs e)
        {
            label_first.Text = "Montant en EURO :";
            label_second.Text = "Montant en DH :";
            TextClear(1);
            
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            double montant, montant_convert, change;
            if (double.TryParse(textBox_change.Text, out change) && double.TryParse(textBox_first.Text, out montant))
            {
                if (radioButton_dhTOeuro.Checked)
                {
                    montant_convert = montant * change;
                }
                else
                {
                    montant_convert = montant / change;
                }
                textBox_second.Text = montant_convert.ToString();
            }
            else
            {
                MessageBox.Show("Données invalides", "Erreur de saisie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            TextClear(0);
        }
    }
}
