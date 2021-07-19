using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jeux_Random
{
    public partial class Form1 : Form
    {
        int i = 0, a, b, c, m; string d; 
       
       
        public Form1()
        {   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 button2.Enabled = false;
                 if (textBox3.Text == "")
                    MessageBox.Show("Champs vide");

                else if (int.TryParse(textBox3.Text, out c) == false)
                    MessageBox.Show("Champs non valide");
                 
                 else if (c < a || c > b)
                     MessageBox.Show("Vous devez entrez un nombre compris entre " + textBox1.Text + " et " + textBox2.Text);

                else
                {
                    textBox3.Enabled = true;
            
                    if (i == 0)
                        d = "100";
                    else if (i == 1)
                        d = "75";
                    else if (i == 2)
                        d = "50";


                    if (c == m)
                    {
                        MessageBox.Show("Félicitation vous avez gagner \n\n votre score est : " + d);
                        i = 0;
                        button2.Enabled = true;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = ""; textBox3.Enabled = false;
                        button1.Enabled = false;
                    }    
                    else if (c > m)
                      { MessageBox.Show("Le nombre que vous y entrez est plus grand"); i++;}
                    else if (m > c)
                      { MessageBox.Show("Le nombre que vous y entrez est plus petit"); i++; }            

            if(i==3)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true; 
                textBox3.ReadOnly = true;
                button1.Enabled = false;
                MessageBox.Show("Game Over");
                button2.Enabled = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = ""; textBox3.Enabled = false;
                button1.Enabled = true;
            }
           }

        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            button1.Enabled = true;
            i = 0;
            
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            button1.Enabled = true;

            
                if (textBox1.Text == "")
                    MessageBox.Show("Champs vide");

                else if (int.TryParse(textBox1.Text, out a) == false)
                    MessageBox.Show("Champs non valide");

                else if (textBox2.Text == "")
                    MessageBox.Show("Champs vide");

                else if (int.TryParse(textBox2.Text, out b) == false)
                    MessageBox.Show("Champs non valide");

                

                else if (a > b)
                    MessageBox.Show("Le MIN doit étre inférieur à le MAX");

                
                else
                {
                    Random r = new Random();
                    m = r.Next(a, b);
                }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox3.Enabled = false;
        }

        

        
           


       

                    

        
    }
}
