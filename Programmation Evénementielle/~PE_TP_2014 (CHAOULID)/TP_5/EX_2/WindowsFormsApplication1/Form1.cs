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
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
                MessageBox.Show("Entrez votre nom et prénom svp");
            else if (textBox2.Text == "")
                MessageBox.Show("Entrez votre adresse svp");
            else if (maskedTextBox1.Text == "")
             MessageBox.Show("Entrez votre numéro de téléphone svp");
            else if (maskedTextBox1.MaskFull==false)
                MessageBox.Show(" votre numéro de téléphone non valid"); 
            else
            {
                DialogResult r=MessageBox.Show("Voulez vous ajouter ce client ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    c++;

                    listBox1.Items.Add(c.ToString() + ".");
                    listBox2.Items.Add((textBox1.Text + "," + monthCalendar1.TodayDate+ "," + textBox2.Text + "," + maskedTextBox1.Text));
                }
                else
                    MessageBox.Show("L'ajout ne se fait pas");

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            

        }

        

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listBox2.Text.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
      

        }

        

       

        
    }
}
