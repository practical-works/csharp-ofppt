using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_vert_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button_bleu_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}
