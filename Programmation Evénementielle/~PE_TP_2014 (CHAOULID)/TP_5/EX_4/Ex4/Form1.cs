using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            
            
                MessageBox.Show("Temps épuisé", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Champs vide");
            else if (textBox2.Text == "")
                MessageBox.Show("Code erroné");
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("bienvenue", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        
    }
}
