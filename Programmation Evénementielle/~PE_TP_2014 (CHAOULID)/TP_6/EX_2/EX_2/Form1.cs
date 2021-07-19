using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_2
{
    public partial class Form1 : Form
    {
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Champs vid");
            else if (textBox1.Text != "stagiaire")
                MessageBox.Show("Login erroné");
            else if (textBox2.Text != "123456")
                MessageBox.Show("mot de passe erroné");
            else
            {
                timer1.Stop();
                MessageBox.Show("Bienvenue");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {

                timer1.Stop(); MessageBox.Show("Temps épuisé"); this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

        }
    }
}
