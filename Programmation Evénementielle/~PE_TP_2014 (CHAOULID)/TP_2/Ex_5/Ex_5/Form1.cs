using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;    


namespace Ex_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n; int i;
            if (textBox1.Text == "")
                MessageBox.Show("entrez un nombre svp");
            else if (double.TryParse(textBox1.Text, out n) == false)
                MessageBox.Show("entrez un nombre valid svp");
            else
            {
                  
                for (i = 1;i <=11;i++)
                {
                    textBox2.Text = textBox2.Text + (n * i).ToString() + Environment.NewLine;
                    
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
