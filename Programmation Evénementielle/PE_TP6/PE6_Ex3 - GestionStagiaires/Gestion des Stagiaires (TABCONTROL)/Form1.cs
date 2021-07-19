using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GS
{
    public partial class Form_main : Form
    {
        private struct Stagiaire
        {
            public int numero;
            public string nom, prenom;
            public double moyenne;
        }
        private enum Critere { Numéro, Nom, Prénom, Moyenne };
        private List<Stagiaire> list_stagiaires = new List<Stagiaire>();

        public Form_main()
        {
            InitializeComponent();
            textBox_nom.Select();
            foreach (var item in Enum.GetValues(typeof(Critere)))
            {
                comboBox_critere.Items.Add(item);
            }
            comboBox_critere.SelectedIndex = 0;
        }

        private void AfficherStagiaire(Stagiaire stagiaire, TextBox textBox_stagiaire_liste)
        {
            textBox_stagiaire_liste.Text += string.Format("{0:Satagiaire 00000 :}", stagiaire.numero) + Environment.NewLine
                                         + "\tNom complet : " + stagiaire.nom + " " + stagiaire.prenom + Environment.NewLine
                                         + string.Format("{0:\tMoyenne : 0.00}", stagiaire.moyenne) + Environment.NewLine
                                         + "--------------------------------------------------------------";
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            int numero;
            string nom = textBox_nom.Text.Trim(), prenom = textBox_prenom.Text.Trim();
            double moyenne;
            if (int.TryParse(textBox_numero.Text.Trim(),out numero) && textBox_nom.Text.Trim() != ""
                && textBox_prenom.Text.Trim() != "" && double.TryParse(textBox_moyenne.Text.Trim(), out moyenne))
            {
                if (numero > 0 && moyenne >= 0 && moyenne <= 20)
                {
                    // Ajouter le stagiaire au tableau des stagiaires défini en mémoire
                    Stagiaire stagiaire = new Stagiaire(); // Créer un nouvau stagiaire
                    stagiaire.numero = numero;
                    stagiaire.nom = nom;
                    stagiaire.prenom = prenom;
                    stagiaire.moyenne = moyenne;
                    list_stagiaires.Add(stagiaire); // Ajout du nouveau stagiaire

                    // Afficher le nouveau stagiaire dans la liste d'affichage
                    AfficherStagiaire(stagiaire, textBox_liste);

                    // Mettre à jour les champs pour l'ajout du prochain stagiaire
                    textBox_numero.Text = (numero + 1).ToString();
                    textBox_nom.Text = textBox_prenom.Text = "...";
                    textBox_moyenne.Text = "0,00";
                    textBox_nom.Select();

                }
                else 
                {
                    MessageBox.Show("Des données sont incorrectes.", "Erreur",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Des données sont invalides ou des champs sont vides.", "Erreur",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            textBox_numero.Text = textBox_nom.Text = textBox_prenom.Text = textBox_moyenne.Text = "";
            textBox_numero.Focus();
        }

        private void button_initialiser_Click(object sender, EventArgs e)
        {
            textBox_liste.Clear();
            list_stagiaires.Clear();
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            Critere critere = (Critere)comboBox_critere.SelectedIndex;
            string mot_cle = textBox_motCle.Text.Trim();
            bool aucun_resultat = true;
            if (critere == Critere.Numéro)
            {
                int numero;
                if (int.TryParse(mot_cle, out numero))
                {
                    textBox_resultat.Clear();
                    foreach (Stagiaire item in list_stagiaires)
                    {
                        if (item.numero == numero)
                        {
                            aucun_resultat = false;
                            AfficherStagiaire(item, textBox_resultat);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez entrer un numéro correcte.", "Erreur",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (critere == Critere.Nom)
            {
                if (mot_cle != "")
                {
                    textBox_resultat.Clear();
                    foreach (Stagiaire item in list_stagiaires)
                    {
                        if (item.nom.Contains(mot_cle))
                        {
                            aucun_resultat = false;
                            AfficherStagiaire(item, textBox_resultat);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Champ vide.", "Erreur",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (critere == Critere.Prénom)
            {
                if (mot_cle != "")
                {
                    textBox_resultat.Clear();
                    foreach (Stagiaire item in list_stagiaires)
                    {
                        if (item.prenom.Contains(mot_cle))
                        {
                            aucun_resultat = false;
                            AfficherStagiaire(item, textBox_resultat);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Champ vide.", "Erreur",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (critere == Critere.Moyenne)
            {
                double moyenne;
                if (double.TryParse(mot_cle, out moyenne))
                {
                    textBox_resultat.Clear();
                    foreach (Stagiaire item in list_stagiaires)
                    {
                        if (Math.Truncate(item.moyenne) == Math.Truncate(moyenne)) //Parties entières
                        {
                            aucun_resultat = false;
                            AfficherStagiaire(item, textBox_resultat);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez entrer une note correcte.", "Erreur",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (aucun_resultat)
            {
                textBox_resultat.Text = "Aucun résultat trouvé.";
            }
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

    }
}
