using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Réglage_de_transparence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString() + "%";
            if (checkBox1.Checked) Opacity = 1 - (double)trackBar1.Value/100;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) Opacity = 1;
            else Opacity = 1 - (double)trackBar1.Value / 100;
        }

    }
}
