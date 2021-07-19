using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Prix_d_une_Configuration
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            label_value_tva.Text = "20 %";
        }
        SoundPlayer button_sound = new SoundPlayer(Prix_d_une_Configuration.Properties.Resources.Got_It);
        SoundPlayer menu_sound = new SoundPlayer(Prix_d_une_Configuration.Properties.Resources.Slap);
        private void button_calculer_Click(object sender, EventArgs e)
        {
            button_sound.Play();
            double total_HT=0, TVA=20, total_TTC=0;
            switch (comboBox_process.SelectedIndex)
            {
                case 0: total_HT += 100; break; //p1
                case 1: total_HT += 200; break; //p2
                case 2: total_HT += 400; break; //p3
                case 3: total_HT += 800; break; //p4
                case 4: total_HT += 1600; break; //CD
                case 5: total_HT += 3200; break; //C2D
                case 6: total_HT += 4000; break; //i3
                case 7: total_HT += 8000; break; //i5
                case 8: total_HT += 16000; break; //i7
                default: total_HT += 0; break;
            }
            switch (comboBox_memory.SelectedIndex)
            {
                case 0: total_HT += 50; break; //256
                case 1: total_HT += 100; break; //512
                case 2: total_HT += 400; break; //1
                case 3: total_HT += 800; break; //2
                case 4: total_HT += 1600; break; //4
                case 5: total_HT += 3200; break; //8
                case 6: total_HT += 6400; break; //16
                case 7: total_HT += 12800; break; //32
                default: total_HT += 0; break;
            }
            switch (comboBox_graphicCard.SelectedIndex)
            {
                case 0: total_HT += 150; break; //128
                case 1: total_HT += 300; break; //256
                case 2: total_HT += 600; break; //512
                case 3: total_HT += 1200; break; //1
                case 4: total_HT += 2400; break; //2
                case 5: total_HT += 4800; break; //4
                case 6: total_HT += 5000; break; //8
                case 7: total_HT += 10000; break; //16
                default: total_HT += 0; break;
            }
            if (checkBox1.Checked) total_HT += 1500 ;
            if (checkBox2.Checked) total_HT += 30;
            if (checkBox3.Checked) total_HT += 50;
            if (checkBox4.Checked) total_HT += 50;
            if (checkBox5.Checked) total_HT += 800;
            if (checkBox6.Checked) total_HT += 500;

            total_TTC = total_HT + (total_HT * (TVA / 100));

            label_value_totalHT.Text = total_HT.ToString() + " DH";
            label_value_tva.Text = TVA.ToString() + " %";
            label_value_totalTTC.Text = total_TTC.ToString() + " DH";
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            button_sound.Play();
            comboBox_process.SelectedIndex = comboBox_memory.SelectedIndex = comboBox_graphicCard.SelectedIndex = -1;
            foreach (CheckBox C in groupBox_devices.Controls)
            {
                C.Checked = false;
            }
            label_value_totalHT.Text = label_value_totalTTC.Text = "0 DH";

        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            button_sound.Play();
            DialogResult Exit_Confirm = new DialogResult();
            Exit_Confirm = MessageBox.Show("Voulez-vous quitter l'application ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Exit_Confirm == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void comboBox_process_SelectedIndexChanged(object sender, EventArgs e)
        {
            menu_sound.Play();
        }

        private void comboBox_memory_SelectedIndexChanged(object sender, EventArgs e)
        {
            menu_sound.Play();
        }

        private void comboBox_graphicCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            menu_sound.Play();
        }

        private void groupBox_devices_Enter(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            menu_sound.Play();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            menu_sound.Play();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            menu_sound.Play();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            menu_sound.Play();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            menu_sound.Play();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            menu_sound.Play();
        }
    }
}
