using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jeu_de_Couleurs__LISTBOX_
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_colorier_Click(object sender, EventArgs e)
        {
            if (listBox_couleurs.SelectedIndex == 0) BackColor = Color.Blue;
            if (listBox_couleurs.SelectedIndex == 1) BackColor = Color.Red;
            if (listBox_couleurs.SelectedIndex == 2) BackColor = Color.Green;
            if (listBox_couleurs.SelectedIndex == 3) BackColor = Color.Yellow;
        }

        private void checkBox_buttonActive_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Form.DefaultBackColor;
            listBox_couleurs.ClearSelected();
            if (checkBox_buttonActive.Checked)
            {
                button_colorier.Enabled = true;  
            }
            else
            {
                button_colorier.Enabled = false;
            }
        }

        private void listBox_couleurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_couleur.Text = listBox_couleurs.Text;
            if (!button_colorier.Enabled)
            {
                if (listBox_couleurs.SelectedIndex == 0) BackColor = Color.Blue;
                if (listBox_couleurs.SelectedIndex == 1) BackColor = Color.Red;
                if (listBox_couleurs.SelectedIndex == 2) BackColor = Color.Green;
                if (listBox_couleurs.SelectedIndex == 3) BackColor = Color.Yellow;
            }
        }


    }
}
