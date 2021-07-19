using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE8_GestionTV
{
    public partial class FormAjout : Form
    {
        private static FormAjout instance;

        public static FormAjout Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new FormAjout();
                }
                return instance; 
            }
        }
        
        public FormAjout()
        {
            InitializeComponent();
            // Contrôler le choix de la date
            dateDateTimePicker.MinDate = DateTime.Today;
            // Remplir le ComboBox avec la liste existante
            typeComboBox.Items.AddRange(Emission.ListeTypes);
            // Utiliser la fonctionnalité d'auto-suggestion de la ComboBox
            AutoCompleteStringCollection A = new AutoCompleteStringCollection();
            A.AddRange(Emission.ListeTypes);
            typeComboBox.AutoCompleteCustomSource = A;
            // Afficher la liste au début
            Afficher();
        }

        public void Afficher()
        {
            emissionBindingSource.DataSource = null;
            emissionBindingSource.DataSource = TV.Emissions;
        }

        private void FormAjout_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        public void MessageErreur(string Message)
        {
            MessageBox.Show(Message,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private bool SaisieCorrecte(out Emission E)
        {
            int Numero;
            string Nom = nomTextBox.Text.Trim();
            string Type = ""; if(typeComboBox.SelectedIndex != -1) Type = typeComboBox.SelectedItem.ToString();
            DateTime Date = dateDateTimePicker.Value, H;
            string Heure = heureMaskedTextBox.Text;
            int Duree = (int)dureeNumericUpDown.Value;
            if (!int.TryParse(numeroTextBox.Text.Trim(), out Numero) || Numero < 0)
            {
                MessageErreur("Entrez un numéro d'émission valide !");
                E = new Emission();
                return false;
            }
            else if (Nom == "")
            {
                MessageErreur("Entrez un nom d'émission !");
                E = new Emission();
                return false;
            }
            else if (Type == "")
            {
                MessageErreur("Choisissez un type d'émission !");
                E = new Emission();
                return false;
            }
            else if (Date == null)
            {
                MessageErreur("Choisissez une date d'émisssion !");
                E = new Emission();
                return false;
            }
            else if (!DateTime.TryParse(Heure, out H))
            {
                MessageErreur("Entrez une heure d'émission valide !");
                E = new Emission();
                return false;
            }
            else if (Duree == 0)
            {
                MessageErreur("Entrez une durée d'émission !");
                E = new Emission();
                return false;
            }
            E = new Emission(Numero, Nom, Date, Heure, Duree, Type);
            return true;
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            Emission E = new Emission();
            if (SaisieCorrecte(out E))
            {
                if (TV.Ajouter(E)) Afficher();
                else MessageErreur("Une émission avec le même numéro existe déjà dans la liste !");
            }
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            Emission E = new Emission();
            if (SaisieCorrecte(out E))
            {
                int Numero = int.Parse(numeroTextBox.Text.Trim());
                if (TV.Modifier(Numero, E)) Afficher();
                else MessageErreur("Aucune émission avec ce numéro n'existe  dans la liste !");
            }
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            int Numero;
            if (int.TryParse(numeroTextBox.Text, out Numero))
            {
                if (TV.Supprimer(Numero)) Afficher();
                else MessageErreur("Aucune émission avec ce numéro n'existe  dans la liste !");
            }
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            int Numero;
            if (int.TryParse(numeroTextBox.Text, out Numero))
            {
                int id = TV.Rechercher(Numero);
                if (id != -1) emissionBindingSource.Position = id;
                else MessageErreur("Aucune émission avec correspondante  dans la liste !");
            }
        }

        private void emissionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int id = emissionBindingSource.Position;
            if (id != -1)
            {
                numeroTextBox.Text = TV.Emissions[id].Numero.ToString();
                nomTextBox.Text = TV.Emissions[id].Nom;
                typeComboBox.Text = TV.Emissions[id].Type;
                dateDateTimePicker.Value = TV.Emissions[id].Date;
                heureMaskedTextBox.Text = TV.Emissions[id].Heure;
                dureeNumericUpDown.Value = TV.Emissions[id].Duree;
            }
            
        }

    }
}
