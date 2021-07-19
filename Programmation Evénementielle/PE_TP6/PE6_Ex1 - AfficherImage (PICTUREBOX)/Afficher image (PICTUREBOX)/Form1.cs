using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Afficher_image__PICTUREBOX_
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_main.Image = pictureBox1.Image;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_main.Image = Afficher_image__PICTUREBOX_.Properties.Resources.empty;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_main.Image = pictureBox2.Image;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_main.Image = pictureBox3.Image;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_main.Image = pictureBox4.Image;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_main.Image = pictureBox5.Image;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_main.Image = pictureBox7.Image;
        }

    }
}
