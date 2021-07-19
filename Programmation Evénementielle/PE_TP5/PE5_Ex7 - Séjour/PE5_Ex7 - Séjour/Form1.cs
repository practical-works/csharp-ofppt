using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE5_Ex7___Séjour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez réservé " + numericUpDown1.Value + " places pour " + domainUpDown1.Text 
                + ".\nBon séjour !","Détails du séjour",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown1.Minimum;
            domainUpDown1.SelectedIndex = 0;
        }
    }
}
