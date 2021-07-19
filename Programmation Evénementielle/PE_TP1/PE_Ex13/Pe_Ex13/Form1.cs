using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pe_Ex13
{
    public partial class Form_mechant : Form
    {
        public Form_mechant()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_non_MouseHover(object sender, EventArgs e)
        {
            Random R = new Random();
            Point new_location; ;
            int x = Form_mechant.ActiveForm.Size.Width-100, y = Form_mechant.ActiveForm.Size.Height-100;
            do
            {
                new_location = new Point(x: R.Next(x), y: R.Next(y));
            } while (new_location == MousePosition);
                button_non.Location = new_location;
        }

        private void button_oui_Click(object sender, EventArgs e)
        {
            button_non.Location = MousePosition;
            pictureBox_cuteAnime.Size += new Size(-7, -5);
            
        }

        private void button_non_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
