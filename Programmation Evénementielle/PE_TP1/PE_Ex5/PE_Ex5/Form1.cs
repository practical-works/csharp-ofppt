using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_green_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            button_green.Enabled = false;
            button_blue.Enabled = true;
            button_default.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_default.Enabled = false;
        }

        private void button_blue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            button_blue.Enabled = false;
            button_green.Enabled = true;
            button_default.Enabled = true;
        }

        private void button_default_Click(object sender, EventArgs e)
        {
            BackColor = DefaultBackColor;
            button_default.Enabled = false;
            button_blue.Enabled = true;
            button_green.Enabled = true;
            
        }

    }
}
