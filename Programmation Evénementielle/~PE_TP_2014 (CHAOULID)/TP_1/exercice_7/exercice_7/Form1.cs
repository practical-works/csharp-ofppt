using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exercice_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double p, t; int q;
            double.TryParse(textBox1.Text, out p);
            int.TryParse(textBox2.Text, out q);
            double.TryParse(textBox3.Text, out t);
            
            
            if (double.TryParse(textBox1.Text, out p) == false || int.TryParse(textBox2.Text, out q) == false || double.TryParse(textBox3.Text, out t) == false)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("entrez des valeures svp");
                }
                else
                { 
                MessageBox.Show("entrez des valeures valides svp");
                }
            }

            if (p < 0 || q < 0)
            {
                MessageBox.Show("entrez un nombre postif dans le Prix Unitaire et la Quantité");
            }
            if (t < 0 || t > 100)
            {
                MessageBox.Show("la TVA doit étre entre 0 est 100");

            }
            else
            {
                if (!(double.TryParse(textBox1.Text, out p) == false || int.TryParse(textBox2.Text, out q) == false || double.TryParse(textBox3.Text, out t) == false))
                {
                    double r;
                    r = (p * q) + ((p * q) * (t / 100));
                    label4.Text = "Le prix total de la commande est : " + r.ToString();
                }
            }

            
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
    }
}
