using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_1
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
            timer1.Start();
            progressBar1.Maximum =100;
            progressBar1.Minimum = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            label2.Text = progressBar1.Value.ToString() + " %";
            label1.Text="Chargement en cours";
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            
                label1.Text = "Chargement Términé";
                
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "Chargement stopé";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = progressBar1.Minimum;
            label2.Text = "0 % ";
            label1.Text = "Chargement arrêté";
            
        }

        
    }
}
