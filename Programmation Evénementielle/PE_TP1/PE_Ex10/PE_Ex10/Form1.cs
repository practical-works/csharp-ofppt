using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex10
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            textBox_code.MaxLength = 4;
            
            
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
        int essai = 1;
        private void button_OK_Click(object sender, EventArgs e)
        {
            int pass=1234, code;
            if (int.TryParse(textBox_code.Text,out code) && code>0)
            {

                if (code == pass)
                {
                    label1.Text = "  CODE CORRECTE!";
                    textBox_code.Visible = false;
                    button_OK.Visible = false;
                    button_Annuler.Text = "(=^_^=)";
                }
                else
                {
                    MessageBox.Show("Code incorrect! (Essai: " + essai + "/3)", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_code.Text = "";
                    essai++;
                    if (essai > 3)
                    {
                        MessageBox.Show("Tentatives d'essais épuisées. Accés bloqué!","Fin d'essais", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        button_OK.Enabled = false;
                        label1.Text = "BLOQUEE! (x_x)";
                        button_Annuler.Text = "(=__=)";
                    }
                }
            }
            else
            {
                MessageBox.Show("Code invalide! Entrez des nombres uniquement.","Erreur!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_code.Text = "";
            }
        }

        private void textBox_code_TextChanged(object sender, EventArgs e)
        {
            if (textBox_code.TextLength == 4 && essai<=3)
            {
                button_OK.Enabled = true;
            }
            else
            {
                button_OK.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
