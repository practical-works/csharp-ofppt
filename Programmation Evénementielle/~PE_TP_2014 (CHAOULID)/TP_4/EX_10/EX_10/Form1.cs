using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_10
{
    public partial class Form1 : Form
    {
        double c, cl, r, t = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex =0;
            comboBox1.SelectedIndex =0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            listBox1.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out c) == false)
                MessageBox.Show("Saisir le prix de base svp", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                if (listBox1.SelectedIndex == 0)
                    cl = c + (c * 0.2);
                else if (listBox1.SelectedIndex == 1)
                    cl = c;

                if (comboBox1.SelectedIndex == -1)
                    MessageBox.Show("Préciser la réduction svp", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (comboBox1.SelectedIndex == 0)
                        r = 0;
                    else if (comboBox1.SelectedIndex == 1)
                        r = 0.40;
                    else if (comboBox1.SelectedIndex == 2)
                        r = 0.30;
                    else if (comboBox1.SelectedIndex == 3)
                        r = 0.50;

                    double p = cl - (cl * r);
                    textBox2.Text = (cl - (cl * r)).ToString();
                    textBox3.Text = t.ToString();
                    textBox4.Text = (p + (p * t / 100)).ToString();
                }
            }


        }

      
    }
}
