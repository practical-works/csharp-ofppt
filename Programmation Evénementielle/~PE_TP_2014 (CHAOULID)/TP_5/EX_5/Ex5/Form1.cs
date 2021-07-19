using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        int h = 0, m = 0, s = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string H, M, S;


            s++;
            if (s == 100)
            { s = 0; m++; }
            
           
            if (m == 60)
            {
                 m = 0; h++;
            }

            if (s < 10)
                S = "0";
            else
                S = "";
            if (m < 10)
                M = "0";
            else
                M = "";
            if (h < 10)
                H= "0";
            else
                H = "";
         label1.Text = H + h.ToString() + "    :    " + M + m.ToString() + "    :    " + S + s.ToString();

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;//  timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            h = 0; m = 0; s = 0;
            label1.Text = "00    :    00    :    00";
        }
    }
}
