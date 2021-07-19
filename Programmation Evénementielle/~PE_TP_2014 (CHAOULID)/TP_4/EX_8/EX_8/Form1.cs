using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "Bleu")
                this.BackColor = Color.Blue;
            
            else if(comboBox1.SelectedIndex==1)
                this.BackColor = Color.Red;

           else if (comboBox1.Text.ToString() == "Vert")
                this.BackColor = Color.Green;
            
             else if (comboBox1.SelectedIndex==3)
                this.BackColor = Color.Yellow;

        }
    }
}
