using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_P.Works
{
    public partial class Form_achat : Form
    {
        public Form_achat()
        {
            InitializeComponent();
        }

        private void checkBox_screen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_screen.Checked)
            {
                groupBox_screen.Enabled = true; 
            }
            else
            {
                groupBox_screen.Enabled = false;
            }
        }

        private void button_prix_Click(object sender, EventArgs e)
        {
            double prix = 0;
            // Processeur
            if (radioButton_pantium.Checked) prix += 800;
            if (radioButton_centrino.Checked) prix += 1200;
            if (radioButton_coreDuo.Checked) prix += 1500;
            // Mémoire
            if (radioButton_1goRAM.Checked) prix += 400;
            if (radioButton_2goRAM.Checked) prix += 800;
            if (radioButton_3goRAM.Checked) prix += 1000;
            // Options
            if (checkBox_mouse.Checked) prix += 60;
            if (checkBox_keyboard.Checked) prix += 80;
            if (checkBox_headset.Checked) prix += 80;
            if (checkBox_printer.Checked) prix += 700;
            // Ecran
            if (groupBox_screen.Enabled)
            { 
                if (radioButton_LCDscreen.Checked) prix += 1500;
                if (radioButton_CRTscreen.Checked) prix += 500;
            }
           
            textBox_prix.Text = prix.ToString();

        }

    }
}
