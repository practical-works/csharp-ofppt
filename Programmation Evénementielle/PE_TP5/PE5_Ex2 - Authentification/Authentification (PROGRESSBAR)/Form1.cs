using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer_time.Start();
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            if (progressBar_time.Value < progressBar_time.Maximum)
            {
                progressBar_time.PerformStep();
            }
            else
            {
                timer_time.Stop();
                MessageBox.Show("Temps épuisé!",Text,MessageBoxButtons.OK,MessageBoxIcon.Stop);
                Close();
            }
            
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "abb" && textBox_password.Text.Trim() == "abb")
            {
                timer_time.Stop();
                panel_main.Enabled = false;
                MessageBox.Show("\n\n\n\n \t\t\tBIENVENUE\t\t\t \n\n\n\n", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                MessageBox.Show("Mot de passe invalide!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
