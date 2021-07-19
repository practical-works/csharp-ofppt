using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double d;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = "Le Montant en DH";
                label2.Text = "Le Montant en EURO";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label2.Text = "Le Montant en DH";
                label1.Text = "Le Montant en EURO";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton2.Checked == false && radioButton1.Checked == false)
                MessageBox.Show("Cochez une option svp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                if (textBox1.Text == "")
                    MessageBox.Show("champ vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (double.TryParse(textBox1.Text, out d) == false)
                    MessageBox.Show("champ non valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if(d<0)
                    MessageBox.Show("Entrez un nombre positif svp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               
                else
                {

                    if (radioButton1.Checked == true)
                    {
                        double c;
                        c = d / 10;
                        textBox2.Text = c.ToString();
                    }
                    if (radioButton2.Checked == true)
                    {
                        double c;
                        c = d * 10;
                        textBox2.Text = c.ToString();
                    }
                }




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = "";
        }
            



        }

        
    }


