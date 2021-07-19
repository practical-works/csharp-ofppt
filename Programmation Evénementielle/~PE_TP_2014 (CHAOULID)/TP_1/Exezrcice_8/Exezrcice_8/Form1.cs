using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exezrcice_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("entrez des valeures svp");
            }
            else
            {
                if (double.TryParse(textBox1.Text, out a) == false || double.TryParse(textBox2.Text, out b) == false)
                {
                    MessageBox.Show("entrez des valeurs valides");
                }
                else
                {
                    if (a <= 0 || b <= 0)
                    {
                        MessageBox.Show("entrez des valeures strictement positives svp");
                    }
                    else
                    {
                        c = b / a;
                        textBox3.Text = c.ToString()+"\t€";
                    
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" ; 
            textBox2.Text = "" ;
            textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
