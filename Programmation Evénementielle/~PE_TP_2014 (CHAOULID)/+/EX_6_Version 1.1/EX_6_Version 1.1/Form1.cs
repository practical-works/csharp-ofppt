using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_6_Version_1._1
{
    public partial class Form1 : Form
    {
        int n, x, y, z, i = 0, c = 0, d, t = 60; double a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("champs vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox1.Text, out n) == false)
                MessageBox.Show("champs non valid", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (n < 1 || n > 10)
                MessageBox.Show("Entrez un nombre entre 1 et 10 ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                textBox1.Enabled = false;
                groupBox1.Enabled = true;
                button1.Enabled = false;
                textBox1.Enabled = false;
            } 
               
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
            button6.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Enabled = false;
            timer2.Enabled = true;
            i = 0; c = 0; t = 60;
            linkLabel1.Text = "Vous avez 3 essais";
            groupBox1.Enabled = false;
            button2.Enabled = true;
            timer2.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "Il vous reste " + (2 - c).ToString() + " essais"; c++;
            timer1.Enabled = true;

            button3.Enabled = true;
            button2.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {int s = 0;
            button3.Enabled = false;
            timer1.Enabled = false;
            if (n == x || n == y || n == z)
            {
                
                if (n == x)
                    s++;
                if (n == y)
                    s++;
                if (n == z)
                    s++;
                if (s == 1)
                    d = 25;
                else if (s == 2)
                    d = 50;
                else if (s == 3)
                    d = 100;



                MessageBox.Show("Bravo vous avez ganger votre score est : " + d.ToString()+Environment.NewLine+"la somme que vous gagner est : "+(d*a).ToString()+" DH", "Félécitation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            
                MessageBox.Show("Pérdu ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            

            i++;
            if (t != 0)
            {
                if (i >= 3)
                {
                    timer2.Enabled = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";

                    MessageBox.Show("Game over", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    linkLabel1.Text = "";
                    linkLabel2.Text = "";



                    groupBox1.Enabled = false;

                }
            }
            button2.Enabled = true;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a;
            a = new Random();

            x = a.Next(0, 10); y = a.Next(0, 10); z = a.Next(0, 10);

            label2.Text = x.ToString();
            label3.Text = y.ToString();
            label4.Text = z.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            t--;
            linkLabel2.Text = "Le temps resté : " + t.ToString() + " s";
            
                
            if ( t == 0)
            {
                timer2.Enabled = false; timer1.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";

                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                MessageBox.Show("Game over", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                linkLabel1.Text = "";
                linkLabel2.Text = "";
       


                groupBox1.Enabled = false;

            }
            
         
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel2.Text = "Le temps resté : " + t.ToString() + " s";
            textBox2.Select();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "")
                MessageBox.Show("Champs vide Entrez une somme d'argent svp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (double.TryParse(textBox2.Text, out a) == false)
                MessageBox.Show("Champs non valide Entrez une somme d'argent", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (a <= 0)
                MessageBox.Show("Entrez une somme d'argent strictement positive ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                button1.Enabled = true;
                textBox1.Enabled = true;
                button6.Enabled = false;
                textBox2.Enabled = false;
            }
           
           

       
        }

        

        

        


    }
}
