using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chronomètre
{
    public partial class Form_chrono : Form
    {
        public Form_chrono()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            button_pause.Enabled = button_arreter.Enabled = false;
        }

        int seconds = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            TimeSpan chrono = new TimeSpan(0, 0, seconds);
            label_time.Text = chrono.ToString();
        }

        private void button_demarrer_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button_demarrer.Enabled = false;
            button_pause.Enabled = button_arreter.Enabled = true;
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button_pause.Enabled = false;
            button_demarrer.Enabled = button_arreter.Enabled = true;
        }

        private void button_arreter_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            seconds = 0;
            TimeSpan chrono = new TimeSpan(0, 0, 0);
            label_time.Text = chrono.ToString();
            button_arreter.Enabled = button_pause.Enabled = false;
            button_demarrer.Enabled = true;
        }

        private void button_capturer_Click(object sender, EventArgs e)
        {
            listBox_captures.Items.Add(label_time.Text);
            listBox_captures.SetSelected(listBox_captures.Items.Count - 1, true);
        }
    }
}
