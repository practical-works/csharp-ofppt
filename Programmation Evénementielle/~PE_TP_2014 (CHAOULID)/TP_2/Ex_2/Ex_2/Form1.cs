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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (textBox1.Text == "")
                MessageBox.Show("entrez des caractéres svp","erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                int j, n; string m; char s;
                m = textBox1.Text;
               
                n=m.Length;
                for (j = n - 1; j >= 0; j--)
                {
                    textBox2.Text = textBox2.Text +m[j] ;
                }


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int j, n; string m;
            m = textBox1.Text;
            
            n = m.Length;
            for (j = n - 1; j >= 0; j--)
            {
                textBox2.Text = textBox2.Text + m[j];
            }
        }

        
    }
}
