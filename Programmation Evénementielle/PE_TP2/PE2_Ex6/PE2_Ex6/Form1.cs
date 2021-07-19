using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE2_Ex6
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_commander_Click(object sender, EventArgs e)
        {
            richTextBox_plats.Clear();
            foreach (CheckBox item in groupBox_menu.Controls)
            {
                if (item.Checked) richTextBox_plats.Text += item.Text + "\n";
            }
        }

        private void button_cocher_Click(object sender, EventArgs e)
        {
            foreach (CheckBox item in groupBox_menu.Controls)
            {
                item.Checked = true;
            }
        }

        private void button_décocher_Click(object sender, EventArgs e)
        {
            foreach (CheckBox item in groupBox_menu.Controls)
            {
                item.Checked = false;
            }
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
