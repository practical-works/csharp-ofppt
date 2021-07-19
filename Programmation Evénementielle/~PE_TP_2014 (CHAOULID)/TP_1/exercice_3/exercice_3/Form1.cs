using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exercice_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Green;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Blue;
        }
    }
}
