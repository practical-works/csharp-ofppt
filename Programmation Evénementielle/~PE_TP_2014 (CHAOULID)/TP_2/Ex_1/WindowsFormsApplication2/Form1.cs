using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, k, i, c=0;
            if (textBox1.Text == "")
                MessageBox.Show("entrez une valeure svp ");
            else if (int.TryParse(textBox1.Text, out n) == false)
                MessageBox.Show("entrez un nombre entier svp");
            else if (n < 0)
                MessageBox.Show("entrez un entier positif svp");


            else
            {
                {
                    if (n >= 0 && n < 10)

                        c = 0;

                    if (n >= 10)

                        c = 1;

                    for (i = 1; i < 10; i++)
                    {
                        if (n % i == 0)
                        {
                            c++;
                        }
                    }
                    if (c <= 2)
                    {
                        label2.Text = ("le nombre " + n.ToString() + " est premier");
                    }

                    else
                    {
                        label2.Text = ("le nombre " + n.ToString() + " n'est pas premier");
                    }

                }
            }
        }
    }
}
