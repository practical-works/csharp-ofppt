using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                MessageBox.Show("Case cochée", "Choix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Case décochée", "Choix", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
