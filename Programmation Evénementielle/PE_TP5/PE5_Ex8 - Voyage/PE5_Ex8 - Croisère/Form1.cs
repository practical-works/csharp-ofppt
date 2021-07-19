using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Voyage
{
    public partial class Form_voyage : Form
    {
        private TimeSpan jours_voyage;
        private decimal places_libres;

        public Form_voyage()
        {
            InitializeComponent();
            dateTimePicker_depart.Value = dateTimePicker_depart.MinDate = dateTimePicker_arrivee.MinDate = DateTime.Today;
            dateTimePicker_arrivee.Value = DateTime.Today.AddDays(1);
            numericUpDown_places.Minimum = 1;
            button_OK.Enabled = false;
        }

        private void textBox_intitule_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Voyage : " + textBox_intitule.Text.Trim();
            button_OK.Enabled = (textBox_intitule.Text.Trim() != "") ? true : false;
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string recap  = "Départ : " + dateTimePicker_depart.Value.ToShortDateString() + "\n"
                          + "Arrivée : " + dateTimePicker_arrivee.Value.ToShortDateString() + "\n"
                          + "Durée : " + jours_voyage.Days + " jour(s)\n"
                          + "Places : " + numericUpDown_places.Value + "\n"
                          + "Inscrits : " + numericUpDown_inscrits.Value + "\n"
                          + "Libres : " + places_libres + "\n";
            DialogResult Enregistrer = MessageBox.Show(recap + "\nVoulez-vous enregistrer ?",this.Text,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Enregistrer == DialogResult.Yes)
            {
                dateTimePicker_depart.Value = DateTime.Today;
                dateTimePicker_arrivee.Value = DateTime.Today.AddDays(1);
                jours_voyage = TimeSpan.Zero;
                numericUpDown_inscrits.Value = numericUpDown_inscrits.Minimum;
                numericUpDown_places.Value = numericUpDown_places.Minimum;
                places_libres = 0;
                textBox_intitule.Text = "";
                textBox_intitule.Focus();
            }
        }

        private void dateTimePicker_depart_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_depart.Value.Date <= dateTimePicker_arrivee.Value.Date)
            {
                jours_voyage = dateTimePicker_arrivee.Value - dateTimePicker_depart.Value;
            } 
            else
	        {
                jours_voyage = TimeSpan.Zero;
                ToolTip msg = new ToolTip(); msg.ToolTipIcon = ToolTipIcon.Info; msg.ToolTipTitle = "Attention!";
                msg.Show("La date d'arrivée doit être postérieure à la date de départ.", dateTimePicker_arrivee,5000);
                dateTimePicker_arrivee.Value = dateTimePicker_depart.Value.Date.AddDays(1);
	        }
            label_jours.Text = jours_voyage.Days.ToString() + " jour(s)";
        }

        private void numericUpDown_places_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_inscrits.Value <= numericUpDown_places.Value)
            {
                places_libres = numericUpDown_places.Value - numericUpDown_inscrits.Value;
                label_libres.Text = "Libres : " + places_libres.ToString();
            }
            else
            {
                places_libres = 0;
                ToolTip msg = new ToolTip(); msg.ToolTipIcon = ToolTipIcon.Info; msg.ToolTipTitle = "Attention!";
                msg.Show("Le nombre de places réservées ne doit pas excéder le nombre de places disponibles.",numericUpDown_places,5000);
                numericUpDown_inscrits.Value--;
                numericUpDown_inscrits.Focus();
            }
            
        }

    }
}
