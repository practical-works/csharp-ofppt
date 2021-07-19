using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ajouter_un_client
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(textBox_nom.Text) && !string.IsNullOrWhiteSpace(textBox_adresse.Text) 
                && maskedTextBox_telephone.MaskFull)     
            {
                string nomPrenom, dateInscription, adresse, telephone;
                nomPrenom = textBox_nom.Text.Trim();
                dateInscription = monthCalendar1.SelectionStart.Date.ToShortDateString();
                adresse = textBox_adresse.Text.Trim();
                telephone = maskedTextBox_telephone.Text.Trim();
                string client = nomPrenom + "," + dateInscription + "," + adresse + "," + telephone;

                DialogResult confirmerClient;
                confirmerClient = MessageBox.Show("Ajouter le client ?", "Nouveau client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmerClient == DialogResult.Yes)
                {
                    listBox_clients.Items.Add(client);
                    listBox_num.Items.Add(listBox_num.Items.Count + 1 + ".");
                }
            }
            else
            {
                MessageBox.Show("Des champs sont encore vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            textBox_nom.Text = string.Empty;
            monthCalendar1.SelectionStart = monthCalendar1.SelectionEnd = DateTime.Today;
            textBox_adresse.Text = string.Empty;
            maskedTextBox_telephone.Text = string.Empty;

        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            if (listBox_clients.Items.Count != 0)
            {
                DialogResult confirmerVidage;
                confirmerVidage = MessageBox.Show("Vider la liste des clients ?", "Vidage de liste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmerVidage == DialogResult.Yes)
                {
                    listBox_clients.Items.Clear();
                    listBox_num.Items.Clear();
                }
            }    
        }

        private void listBox_clients_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listBox_clients.Text,"Informations du client",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void listBox_num_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
