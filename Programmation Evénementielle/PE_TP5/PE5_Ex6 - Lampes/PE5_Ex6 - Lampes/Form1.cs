using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lampes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = false;
            panel1.BackColor = Color.Silver;
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked) radioButton2.Checked = true;
            else if (radioButton2.Checked) radioButton3.Checked = true;
            else if (radioButton3.Checked) radioButton1.Checked = true;
            else radioButton1.Checked = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != trackBar1.Maximum)
            {
                timer1.Interval = 1000 - trackBar1.Value * 100;
            }
            else
            {
                timer1.Interval = 1;
            }
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) panel1.BackColor = Color.Green;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) panel1.BackColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) panel1.BackColor = Color.Red;
        }
    }
}
