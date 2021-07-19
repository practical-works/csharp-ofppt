using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_5
{
    public partial class Form1 : Form
    {
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval =1001-trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            label2.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        
    }
}
