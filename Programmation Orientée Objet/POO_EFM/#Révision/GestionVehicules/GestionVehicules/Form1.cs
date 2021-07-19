using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionVehicules
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_QteCarburant.Enabled = textBox_compteurKm.Enabled = false;
        }

        public void MAJ()
        {
            List<string> S = new List<string>();
            foreach (Vehicule V in Garage.Liste)
            {
                S.Add(V.Marque.ToString());
            }
            comboBox_vehicule.Items.Clear();
            comboBox_vehicule.Items.AddRange(S.ToArray());
        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            foreach (Control C in groupBox_main.Controls)
            {
                if (C is TextBox)
                {
                    TextBox T = (TextBox)C;
                    T.Clear();
                }              
            }
            comboBox_vehicule.SelectedIndex = -1; comboBox_vehicule.Text = "";
            radioButton_diesel.Checked = radioButton_essence.Checked = false;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            string Marque = textBox_marque.Text.Trim();
            int Consommation, CapReservoir;
            string Carburant = "";
            if (radioButton_diesel.Checked)
	        {
		        Carburant = Vehicule.ListeCarburants[0];
	        } else if (radioButton_essence.Checked)
            {
                Carburant = Vehicule.ListeCarburants[1];
            }
            if (Marque == "" || Carburant == "" || !int.TryParse(textBox_consommation.Text, out Consommation) || 
                !int.TryParse(textBox_capReservoir.Text, out CapReservoir))
            {
                MessageBox.Show("Des données sont manquantes ou invalide!");
            }
            else
            {
                Vehicule V = new Vehicule(Marque, Consommation, Carburant, CapReservoir);
                if (!Garage.Ajouter(V))
                {
                    MessageBox.Show("Marque existe déjà!");
                }
                else
                {
                    //button_nouveau.PerformClick();
                    MAJ();
                }
            }
        }
    }
}
