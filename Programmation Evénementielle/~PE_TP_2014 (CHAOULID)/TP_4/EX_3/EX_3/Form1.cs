using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                textBox1.Text = (listBox1.Items.Count).ToString();
                textBox2.Text = (listBox1.SelectedIndex+1).ToString();
                textBox3.Text = listBox1.Text.ToString();
                        
        }
    }
}
