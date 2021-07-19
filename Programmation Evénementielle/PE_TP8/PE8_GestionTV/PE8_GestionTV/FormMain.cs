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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormOpen(Form F)
        {
            F.Focus();
            F.MdiParent = this;
            F.Show();
        }

        private void ajoutDeProgrammesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(FormAjout.Instance);
        }

        private void emissionsParDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(Consultations.FormDate.Instance);
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpen(Consultations.FormStats.Instance);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TV.Sauvegarder())
            {
                MessageBox.Show("Liste sauvegardée avec succés.");
            }
            else
            {
                MessageBox.Show("Aucune modification à enregistrer.");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            TV.Charger();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TV.DonneesModifiees)
            {
                DialogResult SaveConfirm = MessageBox.Show("Voulez-vous enregistrer les modifications apportées ?", "Enregistrer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SaveConfirm == DialogResult.Yes)
                {
                    if (TV.Sauvegarder())
                    {
                        MessageBox.Show("Liste sauvegardée avec succés.");
                    }
                    else
                    {
                        MessageBox.Show("Un problème a empêché la sauvegarde !");
                    }
                }
            } 
        }
    }
}
