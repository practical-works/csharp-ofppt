using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE2_Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string loisirs = string.Empty;

            //if (checkBox_sport.Checked) loisirs += " Sport ";
            //if (checkBox_lecture.Checked) loisirs += " Lecture ";
            //if (checkBox_voyage.Checked) loisirs += " Voyage ";
            //if (checkBox_internet.Checked) loisirs += " Internet ";

            foreach (CheckBox item in groupBox_loisirs.Controls)
            {
                if (item.Checked) loisirs += item.Text + " ";
            }

            MessageBox.Show("Vos loisirs sont : " + loisirs,"Loisirs");
        }
    }
}
