using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_2
{   
    public partial class Form1 : Form
    {
        double a, b, r;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(radioButton5.Checked==false)
           {
            if (textBox1.Text == "" || textBox2.Text == "" )
                MessageBox.Show("Champ vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (double.TryParse(textBox1.Text, out a) == false || double.TryParse(textBox2.Text, out b) == false)
                MessageBox.Show("entrez des nombres svp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if ((radioButton1.Checked == false) && (radioButton2.Checked == false) && (radioButton3.Checked == false) && (radioButton4.Checked == false) && (radioButton5.Checked == false))
                MessageBox.Show("Cochez une opération svp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (radioButton1.Checked == true)
                {
                    
                    r = a + b;
                    textBox3.Text = r.ToString();
                }
                if (radioButton2.Checked == true)
                {
                    
                    r = a - b;
                    textBox3.Text = r.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    
                    r = a * b;
                    textBox3.Text = r.ToString();
                }
                if (radioButton4.Checked == true)
                {
                    if (textBox2.Text == "0")
                        MessageBox.Show("Erreur mathématique", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        
                        r = a / b;
                        textBox3.Text = r.ToString();
                    }
                }



            }
            }
            if (radioButton5.Checked == true)
            {
                
                if (textBox1.Text == "")
                    MessageBox.Show("Champ vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (double.TryParse(textBox1.Text, out a) == false)
                    MessageBox.Show("entrez un nombre valid svp");

                else
                {

                    
                    if (a < 0)
                        MessageBox.Show("Saisez un nombre positif", "Erreur mathématique", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {

                        
                        r = Math.Sqrt(a);
                        textBox3.Text = r.ToString();
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
            foreach (RadioButton r in this.groupBox1.Controls)
            { r.Checked = false; }
            textBox1.Select();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                textBox2.ReadOnly = true;
                label4.Text = "√";
            }
            else
                textBox2.ReadOnly = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "+";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "-";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "*";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "/";
        }

        

    }
}
