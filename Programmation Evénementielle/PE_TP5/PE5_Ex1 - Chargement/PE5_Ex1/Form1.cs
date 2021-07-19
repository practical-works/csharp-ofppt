using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE5_Ex1
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            label_pourcentage.Text = label_statut.Text = "";
            button_pause.Enabled = button_arreter.Enabled = false;
            timer_progression.Interval = 10;
            progressBar_progression.Step = 1;
        }

        private void button_demarrer_Click(object sender, EventArgs e)
        {
            timer_progression.Start();
            button_demarrer.Enabled = false;
            button_pause.Enabled = button_arreter.Enabled = true;
            label_statut.Text = "Chargement en cours ...";
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer_progression.Stop();
            button_pause.Enabled = false;
            button_demarrer.Enabled = true;
            label_statut.Text = "Chargement en pause.";
        }

        private void button_arreter_Click(object sender, EventArgs e)
        {
            timer_progression.Stop();
            button_arreter.Enabled = button_pause.Enabled = false;
            button_demarrer.Enabled = true;
            label_statut.Text = label_pourcentage.Text = "";
            progressBar_progression.Value = 0;
        }

        private void timer_progression_Tick(object sender, EventArgs e)
        {
            if (progressBar_progression.Value != progressBar_progression.Maximum)
            {
                progressBar_progression.PerformStep();
                label_pourcentage.Text = progressBar_progression.Value.ToString() + "%";
            }
            else
            {
                button_arreter.PerformClick();
                label_statut.Text = "Chargement terminé!";
            }
            
        }
    }
}
