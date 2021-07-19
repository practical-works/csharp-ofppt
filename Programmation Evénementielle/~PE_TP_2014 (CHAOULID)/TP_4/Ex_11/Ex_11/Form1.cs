using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_11
{
    public partial class Form1 : Form
    {
        int p = 0, m = 0, g = 0, t, a, b, c, d, h, j;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                p = 800;
            else if (comboBox1.SelectedIndex == 1)
                p = 1200;
            else if (comboBox1.SelectedIndex == 2)
                p = 1200;
            
            if (comboBox2.SelectedIndex == 0)
                m = 200;
            else if (comboBox2.SelectedIndex == 1)
                m= 400;
            else if (comboBox2.SelectedIndex == 2)
                m = 800;

            if (comboBox3.SelectedIndex == 0)
                g = 800;
            else if (comboBox3.SelectedIndex == 1)
                g = 1200;
            else if (comboBox3.SelectedIndex == 2)
                g = 1200;

            if (checkBox1.Checked == true)
                a = 1500;
            else
                a = 0;

            if (checkBox2.Checked == true)
                b = 30;
            else
                b = 0;

            if (checkBox3.Checked == true)
                c = 50;
            else
                c = 0;

            if (checkBox4.Checked == true)
                d = 50;
            else
                d = 0;

            if (checkBox5.Checked == true)
                h = 800;
            else
                h = 0;
            
            if (checkBox6.Checked == true)
                j= 500;
            else
                j = 0;

            t=p+m+g+a+b+c+d+h+j;
            label13.Text = t.ToString();
            label14 .Text= "10 %";
            label15.Text = (t + t * 0.1).ToString();


               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            
        }

        
    }
}
