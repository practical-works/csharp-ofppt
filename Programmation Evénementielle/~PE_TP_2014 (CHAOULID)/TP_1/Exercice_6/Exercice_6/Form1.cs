using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercice_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, s;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("entrez des nombres svp");
            }
            else
            {
                if ((double.TryParse(textBox1.Text, out a) == false) || (double.TryParse(textBox2.Text, out b) == false))
                {
                    MessageBox.Show("entrez des nombres valides svp");

                }
                else
                {

                    double.TryParse(textBox1.Text, out a);
                    double.TryParse(textBox2.Text, out b);
                    s = a + b;
                    textBox3.Text = s.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }
    }
}
