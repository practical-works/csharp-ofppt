using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class FormMiseAJour : Form
    {
        public FormMiseAJour()
        {
            InitializeComponent();
            TextBox_reference.Select();
            Actualiser();
            //---------------POUR TEST-------------------
            TextBox_reference.Text = "3";
            TextBox_nom.Text = "Super DroixX 17";
            TextBox_prixVente.Text = "10000";
            TextBox_quantite.Text = "7";
            //---------------POUR TEST-------------------
        }

        public void Actualiser()
        {
            BindingSource_article.DataSource = null;
            BindingSource_article.DataSource = Stock.Get();
        }
        public void RemplirChamps(BindingSource binding_source)
        {
            Article SelectedArticle = (Article)binding_source.Current;
            if (SelectedArticle != null)
            {
                TextBox_reference.Text = SelectedArticle.Reference.ToString();
                TextBox_nom.Text = SelectedArticle.Nom;
                TextBox_prixVente.Text = SelectedArticle.PrixVente.ToString();
                TextBox_quantite.Text = SelectedArticle.Quantite.ToString();
            }
            else
            {
                button_nouveau.PerformClick();
            }
        }
       
        private void button_nouveau_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void button_rechercher_Click(object sender, EventArgs e)
        {
            int ReferenceCle;
            if (!int.TryParse(TextBox_reference.Text, out ReferenceCle))
            {
                MessageBox.Show("Le numéro de référence à rechercher est invalide ou vide.","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int IndexResultat = Stock.Rechercher(ReferenceCle);
                if (IndexResultat == -1)
                {
                    MessageBox.Show("L'article recherché est introuvable.","Rechercher",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    BindingSource_article.Position = IndexResultat;
                }
            }
        }
        private void button_RechercheAV_Click(object sender, EventArgs e)
        {
            FormRechercheAV RECHERCHE_ACANCEE = new FormRechercheAV();
            RECHERCHE_ACANCEE.ShowDialog();
            RemplirChamps(RECHERCHE_ACANCEE.BindingSource_recherche);
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            int Reference;
            string Nom = TextBox_nom.Text.Trim();
            double PrixVente;
            int Quantite;
            if ( !int.TryParse(TextBox_reference.Text, out Reference) || Nom == "" || 
                !double.TryParse(TextBox_prixVente.Text, out PrixVente) || 
                !int.TryParse(TextBox_quantite.Text, out Quantite) )
            {
                MessageBox.Show("Des champs semble contenir des données invalides ou vides.","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Article NouveauArticle = new Article(Reference, Nom, PrixVente, Quantite);
                if (Stock.Rechercher(Reference) != -1)
                {
                    DialogResult RemplacerArticle = MessageBox.Show("Un article de la même référence existe déjà.\nVoulez-vous le remplacer ?","Ajouter",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (RemplacerArticle == DialogResult.Yes)
                    {
                        Stock.Modifier(Reference, NouveauArticle);
                        button_nouveau.PerformClick();  // Vider les champs après l'ajout
                        Actualiser();                   // Mettre à jour l'affichage de la liste
                    }
                }
                else
                {
                    Stock.Ajouter(NouveauArticle);
                    button_nouveau.PerformClick();  // Vider les champs après l'ajout
                    Actualiser();                   // Mettre à jour l'affichage de la liste
                }
                BindingSource_article.Position = Stock.Rechercher(Reference);  // Sélectionner l'élément ajouté
                TextBox_reference.Select();     // Refocus sur le champ pour une nouvelle saisie
            }
        }
        private void button_modifier_Click(object sender, EventArgs e)
        {
            int Reference;
            string Nom = TextBox_nom.Text.Trim();
            double PrixVente;
            int Quantite;
            if (!int.TryParse(TextBox_reference.Text, out Reference) || Nom == "" ||
                !double.TryParse(TextBox_prixVente.Text, out PrixVente) ||
                !int.TryParse(TextBox_quantite.Text, out Quantite))
            {
                MessageBox.Show("Des champs semble contenir des données invalides ou vides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Article MiseAJourArticle = new Article(Reference, Nom, PrixVente, Quantite);
                if (Stock.Rechercher(Reference) == -1)
                {
                    DialogResult AjouterArticle = MessageBox.Show("L'article que vous désirez modifier n'existe pas.\nVoulez-vous l'ajouter ?", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (AjouterArticle == DialogResult.Yes)
                    {
                        Stock.Ajouter(MiseAJourArticle);
                        button_nouveau.PerformClick();  // Vider les champs après l'ajout
                        Actualiser();                   // Mettre à jour l'affichage de la liste
                    }
                }
                else
                {
                    Stock.Modifier(Reference, MiseAJourArticle);
                    button_nouveau.PerformClick();  // Vider les champs après l'ajout
                    Actualiser();                   // Mettre à jour l'affichage de la liste
                }
                BindingSource_article.Position = Stock.Rechercher(Reference);  // Sélectionner l'élément ajouté
                TextBox_reference.Select();     // Refocus sur le champ pour une nouvelle saisie
            }
        }
        private void button_supprimer_Click(object sender, EventArgs e)
        {
            int ReferenceSuppr;
            if (!int.TryParse(TextBox_reference.Text, out ReferenceSuppr))
            {
                MessageBox.Show("Le numéro de référence à supprimer est invalide ou vide.","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int IndexResultat = Stock.Rechercher(ReferenceSuppr);
                if (IndexResultat == -1)
                {
                    MessageBox.Show("L'article ciblé est introuvable.", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Stock.Supprimer(ReferenceSuppr);
                    Actualiser();
                    TextBox_reference.Select();
                }
            }
        }

        private void DataGridView_article_SelectionChanged(object sender, EventArgs e)
        {
            RemplirChamps(BindingSource_article);
        }
    }
}
