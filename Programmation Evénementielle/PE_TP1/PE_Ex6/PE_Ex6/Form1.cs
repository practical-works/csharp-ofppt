using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex6
{
    public partial class Form_Somme : Form
    {
        public Form_Somme()
        {
            InitializeComponent();
        }

        private void button_calcul_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;
            if (double.TryParse(text_num1.Text, out num1) && double.TryParse(text_num2.Text, out num2))
            {
                sum = num1 + num2;
                text_sum.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Données entrées invalides!");
            }

        }

        private void button_undo_Click(object sender, EventArgs e)
        {
            text_num1.Text = "";
            text_num2.Text = "";
            text_sum.Text = "";
            button_calcul.Enabled = false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void text_num1_TextChanged(object sender, EventArgs e)
        {
            button_calcul.Enabled = true;
        }

        private void text_num2_TextChanged(object sender, EventArgs e)
        {
            button_calcul.Enabled = true;
        }
    }
}
