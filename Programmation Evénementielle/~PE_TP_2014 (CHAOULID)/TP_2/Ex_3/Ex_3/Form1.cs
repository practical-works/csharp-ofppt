using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_3
{
    public partial class Form1 : Form
    {int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        
      /*  private void Form1_Activated(object sender, EventArgs e)
        {
            c++;
        }*/
        
        private void button1_Click(object sender, EventArgs e)
        {
                  int n, i;
            

                if (textBox1.Text == "")
                {MessageBox.Show("entrez un code svp");c++;}

                else if (int.TryParse(textBox1.Text, out n) == false)
                { MessageBox.Show("!  le code n'est pas correcte,saisez des entiers svp "); c++; }

                else if (n < 0)
                { MessageBox.Show("!  le code n'est pas correcte  "); c++; }


                else
                {
                    i = 0;
                    do
                    {
                        n = n / 10;
                        i++;

                    }
                    while (n != 0);

                    if (i == 4)
                    { MessageBox.Show("le code est vrai"); c = 0; }
                    else
                    { MessageBox.Show("!  le code n'est pas correcte,saisez 4 entiers svp"); c++; }

                }
                if (c >= 3)
                {

                    MessageBox.Show("vous n'avez pas le droit de saisir un autre code","erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    button1.Enabled = false;

                }


               
            
            
            
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

       

        

       

        

        


        
    }
}
