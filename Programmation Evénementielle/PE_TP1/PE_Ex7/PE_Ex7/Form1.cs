using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex7
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            text_prix.Text = "";
            text_quantite.Text = "";
            text_tva.Text = "";
        }

        private void button_calculer_Click(object sender, EventArgs e)
        {
            double prix, tva, prix_total; int quantite;
            if (text_prix.Text=="" || text_quantite.Text=="" || text_tva.Text=="")
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de procéder au calcul.","Champs vides");

            }
            else
            {
                if (double.TryParse(text_prix.Text, out prix) && double.TryParse(text_tva.Text, out tva)
                    && int.TryParse(text_quantite.Text, out quantite))
                {
                    if (prix>0 && quantite>0 && tva>=0 && tva<=100)
                    {
                        prix_total = (prix * quantite) + ((tva / 100) * (prix * quantite));
                        label_prixTotal.Text = "Le prix total à payer est " + prix_total + " DH.";
                    }
                    else
                    {
                        MessageBox.Show("Le prix et la quantité doivent être positives, et la TVA doit être comprise entre 0 et 100%");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez entrer des données valides.");
                }
            }
        }
    }
}
