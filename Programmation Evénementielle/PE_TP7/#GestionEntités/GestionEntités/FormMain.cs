using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionEntités
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Actualiser();
        }

        private void Actualiser()
        {
            bindingSource_entite.DataSource = null;
            bindingSource_entite.DataSource = EntitéListe.Afficher();
        }

        private void toolStripButton_ajouter_Click(object sender, EventArgs e)
        {
            FormSaisie form_saisie = new FormSaisie();
            form_saisie.edit_mode = false;
            form_saisie.ShowDialog();
            Actualiser();
            bindingSource_entite.MoveLast();
        }

        private void toolStripButton_modifier_Click(object sender, EventArgs e)
        {
            Entité E = (Entité)bindingSource_entite.Current;
            FormSaisie form_saisie = new FormSaisie();
            form_saisie.edit_mode = true;
            form_saisie.RemplirChamps(E);
            form_saisie.ShowDialog();
            Actualiser();
            bindingSource_entite.Position = bindingSource_entite.IndexOf(E);
        }

        private void toolStripButton_supprimer_Click(object sender, EventArgs e)
        {
            Entité E = (Entité)bindingSource_entite.Current;
            if (E != null)
            {
                EntitéListe.Supprimer(E.Code);
                Actualiser();
                bindingSource_entite.Position = bindingSource_entite.IndexOf(E);
            }
        }
    }
}
