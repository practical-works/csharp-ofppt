using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vitesse_de_compteur
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        private int interval;

        public Form1()
        {
            InitializeComponent();
            //=========================================
            interval = timer1.Interval = 1000; // 1 seconde
            trackBar_speed.Minimum = 1;
            trackBar_speed.Maximum = 1000;
            //=========================================
            label_interval.Text = (timer1.Interval / 1000.000).ToString() + " Tick / Seconde";
            //=========================================
            timer1.Start();
            //=========================================
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label_counter.Text = counter.ToString();
        }

        private void trackBar_speed_Scroll(object sender, EventArgs e)
        {
            if (trackBar_speed.Value != trackBar_speed.Maximum)
            {
                timer1.Interval = interval;
                timer1.Interval -= timer1.Interval * trackBar_speed.Value / trackBar_speed.Maximum;
            }
            else
            {
                timer1.Interval = 1;
            }
            

            //=========================================
            label_interval.Text = (timer1.Interval / 1000.000).ToString() + " Tick / Seconde";
        }
    }
}
