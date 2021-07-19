using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_3
{

   public struct stagiaire
    {
       public string nom{get;set;}
       public string prenom{get;set;}
       public int code{get;set;}
       public double moyenne{get;set;}

        
       public override string  ToString()
          {
 	          return ("Stagiaire :"+code+"           Le nom complet : "+nom+" "+prenom+"        La moyenne : "+moyenne);
          }

    }

        
        
        

        
    public partial class Form1 : Form
    {
        int i = 0;
        stagiaire[] s = new stagiaire[1000];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = ""; 
            textBox3.Text = ""; 
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {int c;double m;bool l=true;
            if (textBox1.Text == "")
                MessageBox.Show("Entrez le numéro svp","Erreur !!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            else if(int.TryParse(textBox1.Text,out c)==false || c<0)
                MessageBox.Show("Le numéro non valid", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            else if (textBox2.Text == "")
                MessageBox.Show("Entrez le nom svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else if (textBox3.Text == "")
                MessageBox.Show("Entrez le Prénom svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            else if (textBox4.Text == "")
                MessageBox.Show("Entrez la moyenne svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (double.TryParse(textBox4.Text, out m) == false || m < 0 || m > 20)
                MessageBox.Show("La moyenne n'est pas valide ", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j].code.ToString() == textBox1.Text)
                    {
                        l = true;
                        break;
                    }
                }

                if(l==false)
                    MessageBox.Show("Ce stagiaire existe déja", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else

                {
                    s[i].code = int.Parse(textBox1.Text);
                    s[i].nom = textBox2.Text;
                    s[i].prenom = textBox3.Text;
                    s[i].moyenne = double.Parse(textBox4.Text);
                    listBox1.Items.Add("Stagiare : " + textBox1.Text + "\n            Nom complet : " + textBox2.Text + " " + textBox3.Text + "                           Moyenne : " + textBox4.Text);
                    i++;

                    MessageBox.Show("Bien ajouté","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                }
            }


                      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Séléctionner un critère de recherche ", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (textBox5.Text == "")
                MessageBox.Show("Entrez le mot clé svp ", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j].code.ToString() == textBox1.Text)
                            listBox2.Items.Add(s[j].ToString());
                    }
                    
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j].nom == textBox2.Text)
                           listBox2.Items.Add(s[j].ToString());
                    }
                    
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j].prenom == textBox3.Text)
                            listBox2.Items.Add(s[j].ToString());
                    }
                    
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j].moyenne.ToString() == textBox4.Text)
                           listBox2.Items.Add(s[j].ToString());
                    }
                    
                }
            }



           
    
           
    

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.Items.ToString());
        }

        

       

        

       

        


        }

        
    }

