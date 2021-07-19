using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex8
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            AcceptButton = button_convertir;
 
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            text_ValeurChange.Text = "10,8890481";
        }

        private void button_convertir_Click(object sender, EventArgs e)
        {
            double ValeurChange, montantDH, montantEURO;
            if (double.TryParse(text_ValeurChange.Text, out ValeurChange) && 
                double.TryParse(text_montantDH.Text, out montantDH))
            {
                ValeurChange = Math.Abs(ValeurChange); montantDH = Math.Abs(montantDH);
                text_ValeurChange.Text = ValeurChange.ToString(); text_montantDH.Text = montantDH.ToString();
                montantEURO = ValeurChange * montantDH;
                text_montantEURO.Text = montantEURO.ToString();

            }
            else
            {
                MessageBox.Show("Données invalides.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            text_ValeurChange.Text = "";
            text_montantDH.Text = "";
            text_montantEURO.Text = "";
        }

        private void text_montantDH_TextChanged(object sender, EventArgs e)
        {
            if (text_ValeurChange.Text == "" || text_montantDH.Text == "")
            {
                button_convertir.Enabled = false;
            }
            else
            {
                button_convertir.Enabled = true;
            }
        }

        private void text_ValeurChange_TextChanged(object sender, EventArgs e)
        {
            if (text_ValeurChange.Text == "" || text_montantDH.Text == "")
            {
                button_convertir.Enabled = false;
            }
            else
            {
                button_convertir.Enabled = true;
            }
        }

        private void text_montantEURO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            text_ValeurChange.Text = "10,8890481";
        }
    }
}
