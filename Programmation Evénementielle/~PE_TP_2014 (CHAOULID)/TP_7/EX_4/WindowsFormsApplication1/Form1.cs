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
        bool A =false,B =false,C = false,D = false,E = false,F =false;
        int c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(A==true && B==true &&  C==true &&  D==true &&  E==true)
           
            {
                this.Hide();
                Consultation l = new Consultation();


                l.label5.Text = this.textBox1.Text + " " + this.textBox2.Text;
                l.label6.Text=this.textBox3.Text;
                l.label7.Text=this.textBox4.Text+" "+textBox5.Text;
                l.label4.Text = this.dateTimePicker1.Text;

                l.Show();

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
               dateTimePicker1.MaxDate = DateTime.Now;

            
                errorProvider1.SetError(label8, "entrez le nom svp");

            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool a = true;
            string s = textBox1.Text;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0' || s[i] == '1' || s[i] == '2' || s[i] == '3' || s[i] == '4' || s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9')
                {
                    a = false;
                    break;
                }
            }
            if (textBox1.Text == "")
                errorProvider1.SetError(label8, "entrez le nom svp");

            else if (a == false)
                errorProvider1.SetError(label8,"Le nom ne doit pas contient des chiffres");

            else 
            {   
                  a = true;
                  A = true;
                  errorProvider1.SetError(label8, "");     
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           bool b = true;
            string f = textBox2.Text;

            for (int i = 0; i < f.Length; i++)
            {
                if (f[i] == '0' || f[i] == '1' || f[i] == '2' || f[i] == '3' || f[i] == '4' || f[i] == '5' || f[i] == '6' || f[i] == '7' || f[i] == '8' || f[i] == '9')
                {
                    b = false;
                    break;
                }
            }
            if (textBox2.Text == "")
                errorProvider1.SetError(label7,"Entrez le prénom svp");

            else if (b == false)
                errorProvider1.SetError(label7, "Le prénom ne doit pas contient des chiffers");

            else
            {
                b = true;
                B = true;
                errorProvider1.SetError(label7,"");
                          
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox3.Text == "")
                errorProvider1.SetError(label9, "Entrez votre adresse svp");
            else
            {
                errorProvider1.SetError(label9, "");
                E = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                errorProvider1.SetError(label10,"Entrez votre Code Postal svp");

            else if (int.TryParse(textBox4.Text, out c) == false || textBox4.Text.Length != 5)
                errorProvider1.SetError(label10, "Le code postal doit comporter 5 chiffres");

            else
            {
                errorProvider1.SetError(label10, "");
                C = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
                errorProvider1.SetError(label11, "Entrez votre ville svp");

            else
            {
                errorProvider1.SetError(label11, "");
                D= true;
            }

        }

        

        
    }
   
}
