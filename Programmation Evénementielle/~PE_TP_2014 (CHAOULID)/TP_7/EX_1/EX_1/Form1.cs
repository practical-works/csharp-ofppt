using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox3.Image;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox4.Image;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox1.Image;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox2.Image;
        }

        

        
    }
}
