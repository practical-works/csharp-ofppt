using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE8_GestionTV.Consultations
{
    public partial class FormStats : Form
    {
        private static FormStats instance;

        public static FormStats Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormStats();
                }
                return instance;
            }
        }

        public FormStats()
        {
            InitializeComponent();
            comboBox_type.Select();
            textBox_totalTous.Text = TV.DureeTotal().ToString() + " minutes";
            // Remplir et Utiliser la fonctionnalité d'auto-suggestion de la ComboBox
            comboBox_type.Items.AddRange(Emission.ListeTypes);
            AutoCompleteStringCollection A = new AutoCompleteStringCollection();
            A.AddRange(Emission.ListeTypes);
            comboBox_type.AutoCompleteCustomSource = A;
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Type = Emission.ListeTypes[comboBox_type.SelectedIndex];
            textBox_totalType.Text = TV.DureeTotal(Type).ToString() + " minutes";
            textBox_pourcentage.Text = TV.DureePourcentage(Type).ToString() + "%";
        }

        private void FormStats_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
