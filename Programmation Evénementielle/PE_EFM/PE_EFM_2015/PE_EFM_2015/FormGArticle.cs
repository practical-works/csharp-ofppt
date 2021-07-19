using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_EFM_2015
{
    public partial class Form_GArticles : Form
    {
        public Form_GArticles()
        {
            InitializeComponent();
            dgv_articles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Program.Stock.Add(new Article(1, "i7-980Ti", 17990, "Informatique",0));
            Program.Stock.Add(new Article(2, "BS-GM-KULT1", 19.80, Article.ListeCategories[0], 20));
        }

        private void Form_GArticles_Load(object sender, EventArgs e)
        {
            cb_categorie.Items.AddRange(Article.ListeCategories);
            txt_prix.Text = "0";
            txt_remise.Enabled = false;
            MAJ();
        }

        private void MAJ()
        {
            dgv_articles.DataSource = null;
            dgv_articles.DataSource = Program.Stock;
        }

        private int Rechercher(int Code)
        {
            foreach (Article A in Program.Stock)
            {
                if (A.Code == Code)
                {
                    return Program.Stock.IndexOf(A);
                }
            }
            return -1;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            int Code;
            double Prix, Remise = 0;
            string Designation = txt_designation.Text.Trim();
            if (!int.TryParse(txt_code.Text, out Code) || Code <= 0)
            {
                MessageBox.Show("Code invalide ou vide!");
                txt_code.Focus(); 
                txt_code.SelectAll();
            }
            else if (Designation == "")
            {
                MessageBox.Show("Désignation vide!");
                txt_designation.Focus();
                txt_designation.Select();
            } else if (cb_categorie.SelectedIndex == -1)
	        {
		        MessageBox.Show("Catégorie non sélectionnée!");
                cb_categorie.Focus();
                cb_categorie.Select();
	        } else if (!double.TryParse(txt_prix.Text, out Prix) || Prix < 0)
	        {
                MessageBox.Show("Prix invalide ou vide!");
                txt_prix.Focus();
                txt_prix.SelectAll();
            }
            else if (cb_solde.Checked && (!double.TryParse(txt_remise.Text, out Remise) || Remise <= 0))
            {
                MessageBox.Show("Remise invalide ou vide!");
                txt_remise.Focus();
                txt_remise.SelectAll();
            }
            else
            {
                string Categorie = cb_categorie.SelectedItem.ToString();
                int p = Rechercher(Code);
                if (p != -1)
                {
                    MessageBox.Show("Article existe déjà!");
                }
                else
                {
                    Program.Stock.Add(new Article(Code, Designation, Prix, Categorie, Remise));
                    MAJ();
                }
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            int Code;
            if (!int.TryParse(txt_code.Text, out Code))
            {
                MessageBox.Show("Code invalide ou vide!");
                txt_code.Focus();
                txt_code.SelectAll();
            }
            else
            {
                int p = Rechercher(Code);
                if (p == -1)
                {
                    MessageBox.Show("Article n'existe pas!");
                }
                else
                {
                    DialogResult D = MessageBox.Show("Voulez-vous vraiment supprimer l'article ?", "Avertissement", MessageBoxButtons.YesNo);
                    if (D == DialogResult.Yes)
                    {
                        Program.Stock.RemoveAt(p);
                        MAJ();
                    }                   
                }
            }
        }

        private void cb_solde_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_solde.Checked)
            {
                txt_remise.Enabled = true;
            }
            else
            {
                txt_remise.Enabled = false;
            }
        }

        private string ChampActuel(int ID)
        {
            return dgv_articles.CurrentRow.Cells[ID].Value.ToString();
        }

        private void dgv_articles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_articles.SelectedRows.Count != 0)
            {
                txt_code.Text = ChampActuel(0);
                txt_designation.Text = ChampActuel(1);
                cb_categorie.SelectedItem = ChampActuel(2);
                txt_prix.Text = ChampActuel(3);
                if (ChampActuel(4) == "0")
                {
                    cb_solde.Checked = false;
                    txt_remise.Text = "";
                }
                else
                {
                    cb_solde.Checked = true;
                    txt_remise.Text = ChampActuel(4);
                }
            }
            
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
