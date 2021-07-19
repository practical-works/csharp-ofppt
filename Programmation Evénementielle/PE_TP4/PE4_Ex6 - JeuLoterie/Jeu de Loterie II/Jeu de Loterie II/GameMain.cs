using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JeuLoterie
{
    public partial class Form_Game : Form
    {
        //========================================================================================
        // ● Attributs
        //========================================================================================
        private List<Game> Partie = new List<Game>();
        private Game cette_partie = new Game();
        bool add_mode;
        int second = 180;
        //========================================================================================
        // ● Constructeurs
        //========================================================================================
        public Form_Game()
        {
            InitializeComponent();
            InitializePlayerList();
            timer_temps_partie.Interval = 1000;
            timer_jeu_machine.Interval = 10;
        }
        //========================================================================================
        // ● Méthodes
        //========================================================================================
        private void UpdateControls()
        {
            comboBox_joueur.SelectedIndex = 0;
            textBox_argent.Text = cette_partie.Wealth.ToString();
            numericUpDown_montant.Value = (decimal)cette_partie.Bet;
            numericUpDown_nombre.Value = (decimal)cette_partie.Number;
            textBox_coups.Text = cette_partie.Hits.ToString();
            textBox_won.Text = cette_partie.Wins.ToString();
            textBox_lost.Text = cette_partie.Losses.ToString();
            textBox_score.Text = cette_partie.Score.ToString();
            textBox_single.Text = cette_partie.Singles.ToString();
            textBox_double.Text = cette_partie.Doubles.ToString();
            textBox_triple.Text = cette_partie.Triples.ToString();
            textBox_resultat.Text = cette_partie.Result;
            textBox_temps.Text = cette_partie.Time.ToString();
        }
        private void InitializePlayerList()
        {
            for (int i = 0; i < 4; i++)
            {
                Game DefaultGame = new Game();
                Partie.Add(DefaultGame);
                comboBox_joueur.Items.Add(DefaultGame.Player);
            }
            comboBox_joueur.SelectedIndex = 0;
        }
        private void UpdatePlayerList()
        {
            comboBox_joueur.Items.Clear();
            foreach (Game item in Partie)
            {
                comboBox_joueur.Items.Add(item.Player);
            }
        }
        //========================================================================================
        // ● Méthodes d'événements
        //========================================================================================
        private void button_nouvellePartie_Click(object sender, EventArgs e)
        {
            panel_gauche.Enabled = panel_droit.Enabled = panel_machine.Enabled = true;
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            panel_edit.Visible = true;
            textBox_edit.Focus();
            add_mode = true;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            panel_edit.Visible = true;
            textBox_edit.Text = comboBox_joueur.SelectedItem.ToString();
            textBox_edit.Focus();
            add_mode = false;
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (add_mode) // Add Mode
            {
                if (textBox_edit.Text.Trim() != "")
                {
                    Game NewGame = new Game();
                    NewGame.Player = textBox_edit.Text.Trim();
                    Partie.Add(NewGame);
                    comboBox_joueur.Items.Add(NewGame.Player);
                    comboBox_joueur.SelectedIndex = comboBox_joueur.Items.Count - 1;
                    textBox_edit.Text = "";
                    panel_edit.Visible = false;
                }
                else
                {
                    panel_edit.Visible = false;
                }
            }
            else  // Modify Mode
            {
                if (textBox_edit.Text.Trim() != "")
                {
                    int tmp_index = comboBox_joueur.SelectedIndex;
                    Game ModifiedGame = Partie[tmp_index];
                    ModifiedGame.Player = textBox_edit.Text;
                    Partie.RemoveAt(tmp_index);
                    Partie.Insert(tmp_index, ModifiedGame);
                    UpdatePlayerList();
                    comboBox_joueur.SelectedIndex = tmp_index;
                    panel_edit.Visible = false;
                }
                else
                {
                    panel_edit.Visible = false;
                }
            }
        }

        private void button_jouer_Click(object sender, EventArgs e)
        {
            if (comboBox_joueur.SelectedIndex != -1)
            {
                groupBox_jouer.Enabled = true;
                timer_temps_partie.Start();
                cette_partie = Partie[comboBox_joueur.SelectedIndex];
                UpdateControls();
                numericUpDown_montant.Focus();
            }
        }

        private void timer_temps_partie_Tick(object sender, EventArgs e)
        {
            TimeSpan temps_partie = new TimeSpan(0, 0, second);
            textBox_temps.Text = temps_partie.ToString();
            second--;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer_jeu_machine.Start();
            cette_partie.Number = (int)numericUpDown_nombre.Value;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer_jeu_machine.Stop();

            int nombre1 = int.Parse(label_nombre1.Text);
            int nombre2 = int.Parse(label_nombre2.Text);
            int nombre3 = int.Parse(label_nombre3.Text);
            int occurence = 0;

            if (nombre1 == cette_partie.Number) occurence++;
            if (nombre2 == cette_partie.Number) occurence++;
            if (nombre3 == cette_partie.Number) occurence++;

            switch (occurence)
            {
                case 1: cette_partie.Hits++; cette_partie.Wins++; 
                        cette_partie.Score += occurence * 3; cette_partie.Singles++;
                        cette_partie.Result = "Gagné!"; 
                        break;
                case 2: cette_partie.Hits++; cette_partie.Wins++;
                        cette_partie.Score += occurence * 3; cette_partie.Doubles++;
                        cette_partie.Result = "Magnifique!";
                        break;
                case 3: cette_partie.Hits++; cette_partie.Wins++;
                        cette_partie.Score += occurence * 3; cette_partie.Triples++;
                        cette_partie.Result = "Légendaire!";
                        break;
                default: cette_partie.Hits--; cette_partie.Losses++;
                         if (cette_partie.Hits <= 0) cette_partie.Result = "FIN PARTIE";
                         else cette_partie.Result = "Raté";
                         break;
            }   
       
            UpdateControls();
        }

        private void timer_jeu_machine_Tick(object sender, EventArgs e)
        {
            Random nombre_aleatoire = new Random();
            label_nombre1.Text = nombre_aleatoire.Next(1, 10).ToString();
            label_nombre2.Text = nombre_aleatoire.Next(1, 10).ToString();
            label_nombre3.Text = nombre_aleatoire.Next(1, 10).ToString();
        }
        
    }
}
