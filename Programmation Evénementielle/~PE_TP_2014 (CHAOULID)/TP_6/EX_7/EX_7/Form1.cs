using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (domainUpDown1.SelectedIndex == -1)
                MessageBox.Show("Choisissez une ville svp", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            else
            {
                string p;
                if (numericUpDown1.Value > 1)
                    p = "s";
                else
                    p = "";
                
                MessageBox.Show("Vous avez réservé " + numericUpDown1.Value + " place"+p+" pour " + domainUpDown1.SelectedItem,"",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
           
            
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        

       
       
    }
}
