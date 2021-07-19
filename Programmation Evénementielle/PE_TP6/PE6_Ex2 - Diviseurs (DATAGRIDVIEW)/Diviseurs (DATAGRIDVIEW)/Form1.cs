using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diviseurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_afficherDiviseurs_Click(object sender, EventArgs e)
        {
            dataGridView_diviseurs.Rows.Clear();
            int nombre = (int)numericUpDown_nombre.Value;
            int nbr_div = 0;
            for (int i = 1; i <= nombre; i++)
            {
                if (nombre % i == 0)
                {
                    nbr_div++;
                    dataGridView_diviseurs.Rows.Add(i.ToString());
                }
            }
            textBox_nbrDiviseurs.Text = nbr_div.ToString();
        }

        private void button_effacerDiviseurs_Click(object sender, EventArgs e)
        {
            dataGridView_diviseurs.Rows.Clear();
            textBox_nbrDiviseurs.Text = "";
        }
    }
}
