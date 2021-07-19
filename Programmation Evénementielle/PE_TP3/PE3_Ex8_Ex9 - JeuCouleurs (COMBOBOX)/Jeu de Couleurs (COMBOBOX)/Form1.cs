using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jeu_de_Couleurs__COMBOBOX_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_buttonEnable_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_couleur.SelectedIndex = -1;
            BackColor = System.Drawing.SystemColors.Desktop;
            button_colorier.Enabled = (checkBox_buttonEnable.Checked) ? true : false;
        }

        private void button_colorier_Click(object sender, EventArgs e)
        {
            if (comboBox_couleur.SelectedIndex == 0) BackColor = Color.Blue;
            if (comboBox_couleur.SelectedIndex == 1) BackColor = Color.Red;
            if (comboBox_couleur.SelectedIndex == 2) BackColor = Color.Green;
            if (comboBox_couleur.SelectedIndex == 3) BackColor = Color.Yellow;
        }

        private void comboBox_couleur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!button_colorier.Enabled)
            {
                if (comboBox_couleur.SelectedIndex == 0) BackColor = Color.Blue;
                if (comboBox_couleur.SelectedIndex == 1) BackColor = Color.Red;
                if (comboBox_couleur.SelectedIndex == 2) BackColor = Color.Green;
                if (comboBox_couleur.SelectedIndex == 3) BackColor = Color.Yellow;
            }
            
        }
    }
}
