using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            if (textBox1.Text == "")
                MessageBox.Show("saisez un nombre dans le Premier nombre svp","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else if (Double.TryParse(textBox1.Text, out a) == false)
                MessageBox.Show("entrez un nombre valid dans le Premier nombre","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                   
            else if (textBox2.Text == "")
                MessageBox.Show("saisez une opération svp ","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else if (textBox2.Text != "+" && textBox2.Text != "-" && textBox2.Text != "*" && textBox2.Text != "/" && textBox2.Text != "%" && textBox2.Text != "^")
                MessageBox.Show("saisez un opérateur valid svp","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else if (textBox3.Text == "")
                MessageBox.Show("entrez un nombre dans le Deuxième nombre","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else if (Double.TryParse(textBox3.Text, out b) == false)
                MessageBox.Show("entrez un nombre valid dans le Deuxième nombre","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else
            {
                if (textBox2.Text == "+")
                {
                    double s;
                    s = a + b;
                    label5.Text = s.ToString();
                }
                if (textBox2.Text == "-")
                {
                    double d;
                    d = a - b;
                    label5.Text = d.ToString();
                }
                if (textBox2.Text == "*")
                {
                    double p;
                    p = a * b;
                    label5.Text = p.ToString();
                }
                if (textBox2.Text == "/")
                {
                    double f;
                    if (textBox3.Text == "0")
                        MessageBox.Show("Erreur matématique","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    else if (textBox1.Text == "0")
                        label5.Text = "0";
                    else
                    {
                        f = a / b;
                        label5.Text = f.ToString();
                    }
                }
                if (textBox2.Text == "%")
                {
                    int x, y, m;
                    if (int.TryParse(textBox1.Text, out x) == false)
                        MessageBox.Show("entrez un entier dans le Premier nombre svp","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    else if (int.TryParse(textBox3.Text, out y) == false)
                        MessageBox.Show("entrez un entier dans le Deuxième nombre svp","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    else
                    {
                        m = x%y;
                        label5.Text = m.ToString();
                    }
                }
                if(textBox2.Text=="^")
                {
                    double v ;
                   v= Math.Pow(a,b);
                   label5.Text = v.ToString();

                    
                }
                        

                }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = "";
        }
        }
    }



