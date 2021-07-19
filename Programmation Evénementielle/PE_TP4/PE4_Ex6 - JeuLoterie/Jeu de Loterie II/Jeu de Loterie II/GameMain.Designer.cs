namespace JeuLoterie
{
    partial class Form_Game
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game));
            this.panel_bas = new System.Windows.Forms.Panel();
            this.groupBox_historique = new System.Windows.Forms.GroupBox();
            this.listBox_historique = new System.Windows.Forms.ListBox();
            this.groupBox_temps = new System.Windows.Forms.GroupBox();
            this.textBox_temps = new System.Windows.Forms.TextBox();
            this.button_quitter = new System.Windows.Forms.Button();
            this.button_nouvellePartie = new System.Windows.Forms.Button();
            this.groupBox_resultat = new System.Windows.Forms.GroupBox();
            this.textBox_resultat = new System.Windows.Forms.TextBox();
            this.panel_droit = new System.Windows.Forms.Panel();
            this.groupBox_score = new System.Windows.Forms.GroupBox();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.textBox_triple = new System.Windows.Forms.TextBox();
            this.textBox_single = new System.Windows.Forms.TextBox();
            this.textBox_double = new System.Windows.Forms.TextBox();
            this.label_triple = new System.Windows.Forms.Label();
            this.label_single = new System.Windows.Forms.Label();
            this.label_double = new System.Windows.Forms.Label();
            this.groupBox_coups = new System.Windows.Forms.GroupBox();
            this.textBox_coups = new System.Windows.Forms.TextBox();
            this.textBox_lost = new System.Windows.Forms.TextBox();
            this.textBox_won = new System.Windows.Forms.TextBox();
            this.label_lost = new System.Windows.Forms.Label();
            this.label_won = new System.Windows.Forms.Label();
            this.panel_gauche = new System.Windows.Forms.Panel();
            this.groupBox_argent = new System.Windows.Forms.GroupBox();
            this.textBox_argent = new System.Windows.Forms.TextBox();
            this.groupBox_jouer = new System.Windows.Forms.GroupBox();
            this.numericUpDown_montant = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nombre = new System.Windows.Forms.NumericUpDown();
            this.label_montant = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.groupBox_joueur = new System.Windows.Forms.GroupBox();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.button_edit = new System.Windows.Forms.Button();
            this.textBox_edit = new System.Windows.Forms.TextBox();
            this.comboBox_joueur = new System.Windows.Forms.ComboBox();
            this.button_jouer = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.panel_diffusion = new System.Windows.Forms.Panel();
            this.label_nombre3 = new System.Windows.Forms.Label();
            this.label_nombre1 = new System.Windows.Forms.Label();
            this.label_nombre2 = new System.Windows.Forms.Label();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.panel_machine = new System.Windows.Forms.Panel();
            this.timer_temps_partie = new System.Windows.Forms.Timer(this.components);
            this.timer_jeu_machine = new System.Windows.Forms.Timer(this.components);
            this.panel_bas.SuspendLayout();
            this.groupBox_historique.SuspendLayout();
            this.groupBox_temps.SuspendLayout();
            this.groupBox_resultat.SuspendLayout();
            this.panel_droit.SuspendLayout();
            this.groupBox_score.SuspendLayout();
            this.groupBox_coups.SuspendLayout();
            this.panel_gauche.SuspendLayout();
            this.groupBox_argent.SuspendLayout();
            this.groupBox_jouer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_montant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nombre)).BeginInit();
            this.groupBox_joueur.SuspendLayout();
            this.panel_edit.SuspendLayout();
            this.panel_diffusion.SuspendLayout();
            this.panel_machine.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bas
            // 
            this.panel_bas.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_bas.BackgroundImage = global::JeuLoterie.Properties.Resources.degrade;
            this.panel_bas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_bas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bas.Controls.Add(this.groupBox_historique);
            this.panel_bas.Controls.Add(this.groupBox_temps);
            this.panel_bas.Controls.Add(this.button_quitter);
            this.panel_bas.Controls.Add(this.button_nouvellePartie);
            this.panel_bas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bas.Location = new System.Drawing.Point(0, 399);
            this.panel_bas.Name = "panel_bas";
            this.panel_bas.Size = new System.Drawing.Size(799, 100);
            this.panel_bas.TabIndex = 0;
            // 
            // groupBox_historique
            // 
            this.groupBox_historique.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_historique.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_historique.Controls.Add(this.listBox_historique);
            this.groupBox_historique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_historique.Location = new System.Drawing.Point(217, 11);
            this.groupBox_historique.Name = "groupBox_historique";
            this.groupBox_historique.Size = new System.Drawing.Size(363, 76);
            this.groupBox_historique.TabIndex = 9;
            this.groupBox_historique.TabStop = false;
            this.groupBox_historique.Text = "Historique";
            // 
            // listBox_historique
            // 
            this.listBox_historique.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_historique.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox_historique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_historique.FormattingEnabled = true;
            this.listBox_historique.Location = new System.Drawing.Point(11, 22);
            this.listBox_historique.Name = "listBox_historique";
            this.listBox_historique.Size = new System.Drawing.Size(341, 41);
            this.listBox_historique.TabIndex = 9;
            // 
            // groupBox_temps
            // 
            this.groupBox_temps.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_temps.Controls.Add(this.textBox_temps);
            this.groupBox_temps.Enabled = false;
            this.groupBox_temps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_temps.Location = new System.Drawing.Point(11, 11);
            this.groupBox_temps.Name = "groupBox_temps";
            this.groupBox_temps.Size = new System.Drawing.Size(200, 77);
            this.groupBox_temps.TabIndex = 8;
            this.groupBox_temps.TabStop = false;
            this.groupBox_temps.Text = "Temps";
            // 
            // textBox_temps
            // 
            this.textBox_temps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_temps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_temps.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_temps.Location = new System.Drawing.Point(17, 20);
            this.textBox_temps.Name = "textBox_temps";
            this.textBox_temps.ReadOnly = true;
            this.textBox_temps.Size = new System.Drawing.Size(167, 43);
            this.textBox_temps.TabIndex = 8;
            this.textBox_temps.Text = "00:00:00";
            this.textBox_temps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_quitter
            // 
            this.button_quitter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_quitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_quitter.BackgroundImage")));
            this.button_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_quitter.Location = new System.Drawing.Point(586, 65);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(200, 23);
            this.button_quitter.TabIndex = 1;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // button_nouvellePartie
            // 
            this.button_nouvellePartie.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_nouvellePartie.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_nouvellePartie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_nouvellePartie.BackgroundImage")));
            this.button_nouvellePartie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_nouvellePartie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_nouvellePartie.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nouvellePartie.Location = new System.Drawing.Point(586, 11);
            this.button_nouvellePartie.Name = "button_nouvellePartie";
            this.button_nouvellePartie.Size = new System.Drawing.Size(200, 48);
            this.button_nouvellePartie.TabIndex = 0;
            this.button_nouvellePartie.Text = "Nouvelle partie";
            this.button_nouvellePartie.UseVisualStyleBackColor = false;
            this.button_nouvellePartie.Click += new System.EventHandler(this.button_nouvellePartie_Click);
            // 
            // groupBox_resultat
            // 
            this.groupBox_resultat.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_resultat.Controls.Add(this.textBox_resultat);
            this.groupBox_resultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_resultat.Location = new System.Drawing.Point(10, 260);
            this.groupBox_resultat.Name = "groupBox_resultat";
            this.groupBox_resultat.Size = new System.Drawing.Size(200, 77);
            this.groupBox_resultat.TabIndex = 8;
            this.groupBox_resultat.TabStop = false;
            this.groupBox_resultat.Text = "Résultat";
            // 
            // textBox_resultat
            // 
            this.textBox_resultat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_resultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_resultat.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_resultat.Location = new System.Drawing.Point(16, 21);
            this.textBox_resultat.Name = "textBox_resultat";
            this.textBox_resultat.ReadOnly = true;
            this.textBox_resultat.Size = new System.Drawing.Size(169, 43);
            this.textBox_resultat.TabIndex = 8;
            this.textBox_resultat.Text = "Aucun";
            this.textBox_resultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_droit
            // 
            this.panel_droit.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_droit.BackgroundImage = global::JeuLoterie.Properties.Resources.degrade;
            this.panel_droit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_droit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_droit.Controls.Add(this.groupBox_resultat);
            this.panel_droit.Controls.Add(this.groupBox_score);
            this.panel_droit.Controls.Add(this.groupBox_coups);
            this.panel_droit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_droit.Enabled = false;
            this.panel_droit.Location = new System.Drawing.Point(576, 0);
            this.panel_droit.Name = "panel_droit";
            this.panel_droit.Size = new System.Drawing.Size(223, 399);
            this.panel_droit.TabIndex = 1;
            // 
            // groupBox_score
            // 
            this.groupBox_score.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_score.Controls.Add(this.textBox_score);
            this.groupBox_score.Controls.Add(this.textBox_triple);
            this.groupBox_score.Controls.Add(this.textBox_single);
            this.groupBox_score.Controls.Add(this.textBox_double);
            this.groupBox_score.Controls.Add(this.label_triple);
            this.groupBox_score.Controls.Add(this.label_single);
            this.groupBox_score.Controls.Add(this.label_double);
            this.groupBox_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_score.Location = new System.Drawing.Point(10, 134);
            this.groupBox_score.Name = "groupBox_score";
            this.groupBox_score.Size = new System.Drawing.Size(200, 120);
            this.groupBox_score.TabIndex = 8;
            this.groupBox_score.TabStop = false;
            this.groupBox_score.Text = "Score";
            // 
            // textBox_score
            // 
            this.textBox_score.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_score.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_score.Location = new System.Drawing.Point(17, 20);
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.ReadOnly = true;
            this.textBox_score.Size = new System.Drawing.Size(167, 43);
            this.textBox_score.TabIndex = 8;
            this.textBox_score.Text = "0";
            this.textBox_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_triple
            // 
            this.textBox_triple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox_triple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_triple.ForeColor = System.Drawing.Color.Black;
            this.textBox_triple.Location = new System.Drawing.Point(133, 90);
            this.textBox_triple.Name = "textBox_triple";
            this.textBox_triple.ReadOnly = true;
            this.textBox_triple.Size = new System.Drawing.Size(55, 20);
            this.textBox_triple.TabIndex = 7;
            this.textBox_triple.Text = "0";
            this.textBox_triple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_single
            // 
            this.textBox_single.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_single.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_single.ForeColor = System.Drawing.Color.Black;
            this.textBox_single.Location = new System.Drawing.Point(13, 90);
            this.textBox_single.Name = "textBox_single";
            this.textBox_single.ReadOnly = true;
            this.textBox_single.Size = new System.Drawing.Size(55, 20);
            this.textBox_single.TabIndex = 6;
            this.textBox_single.Text = "0";
            this.textBox_single.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_double
            // 
            this.textBox_double.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox_double.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_double.ForeColor = System.Drawing.Color.Black;
            this.textBox_double.Location = new System.Drawing.Point(73, 90);
            this.textBox_double.Name = "textBox_double";
            this.textBox_double.ReadOnly = true;
            this.textBox_double.Size = new System.Drawing.Size(55, 20);
            this.textBox_double.TabIndex = 6;
            this.textBox_double.Text = "0";
            this.textBox_double.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_triple
            // 
            this.label_triple.AutoSize = true;
            this.label_triple.ForeColor = System.Drawing.Color.Purple;
            this.label_triple.Location = new System.Drawing.Point(130, 74);
            this.label_triple.Name = "label_triple";
            this.label_triple.Size = new System.Drawing.Size(45, 13);
            this.label_triple.TabIndex = 5;
            this.label_triple.Text = "Triplés :";
            // 
            // label_single
            // 
            this.label_single.AutoSize = true;
            this.label_single.ForeColor = System.Drawing.Color.Teal;
            this.label_single.Location = new System.Drawing.Point(10, 74);
            this.label_single.Name = "label_single";
            this.label_single.Size = new System.Drawing.Size(52, 13);
            this.label_single.TabIndex = 4;
            this.label_single.Text = "Uniques :";
            // 
            // label_double
            // 
            this.label_double.AutoSize = true;
            this.label_double.ForeColor = System.Drawing.Color.Navy;
            this.label_double.Location = new System.Drawing.Point(70, 74);
            this.label_double.Name = "label_double";
            this.label_double.Size = new System.Drawing.Size(52, 13);
            this.label_double.TabIndex = 4;
            this.label_double.Text = "Doublés :";
            // 
            // groupBox_coups
            // 
            this.groupBox_coups.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_coups.Controls.Add(this.textBox_coups);
            this.groupBox_coups.Controls.Add(this.textBox_lost);
            this.groupBox_coups.Controls.Add(this.textBox_won);
            this.groupBox_coups.Controls.Add(this.label_lost);
            this.groupBox_coups.Controls.Add(this.label_won);
            this.groupBox_coups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_coups.Location = new System.Drawing.Point(10, 8);
            this.groupBox_coups.Name = "groupBox_coups";
            this.groupBox_coups.Size = new System.Drawing.Size(200, 120);
            this.groupBox_coups.TabIndex = 8;
            this.groupBox_coups.TabStop = false;
            this.groupBox_coups.Text = "Coups";
            // 
            // textBox_coups
            // 
            this.textBox_coups.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_coups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_coups.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_coups.Location = new System.Drawing.Point(17, 20);
            this.textBox_coups.Name = "textBox_coups";
            this.textBox_coups.ReadOnly = true;
            this.textBox_coups.Size = new System.Drawing.Size(167, 43);
            this.textBox_coups.TabIndex = 8;
            this.textBox_coups.Text = "0";
            this.textBox_coups.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_lost
            // 
            this.textBox_lost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox_lost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_lost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox_lost.Location = new System.Drawing.Point(129, 90);
            this.textBox_lost.Name = "textBox_lost";
            this.textBox_lost.ReadOnly = true;
            this.textBox_lost.Size = new System.Drawing.Size(55, 20);
            this.textBox_lost.TabIndex = 7;
            this.textBox_lost.Text = "0";
            this.textBox_lost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_won
            // 
            this.textBox_won.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_won.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_won.ForeColor = System.Drawing.Color.Green;
            this.textBox_won.Location = new System.Drawing.Point(68, 90);
            this.textBox_won.Name = "textBox_won";
            this.textBox_won.ReadOnly = true;
            this.textBox_won.Size = new System.Drawing.Size(55, 20);
            this.textBox_won.TabIndex = 6;
            this.textBox_won.Text = "0";
            this.textBox_won.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_lost
            // 
            this.label_lost.AutoSize = true;
            this.label_lost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_lost.Location = new System.Drawing.Point(126, 74);
            this.label_lost.Name = "label_lost";
            this.label_lost.Size = new System.Drawing.Size(42, 13);
            this.label_lost.TabIndex = 5;
            this.label_lost.Text = "Ratés :";
            // 
            // label_won
            // 
            this.label_won.AutoSize = true;
            this.label_won.ForeColor = System.Drawing.Color.Green;
            this.label_won.Location = new System.Drawing.Point(65, 74);
            this.label_won.Name = "label_won";
            this.label_won.Size = new System.Drawing.Size(50, 13);
            this.label_won.TabIndex = 4;
            this.label_won.Text = "Gagnés :";
            // 
            // panel_gauche
            // 
            this.panel_gauche.BackColor = System.Drawing.Color.LightGray;
            this.panel_gauche.BackgroundImage = global::JeuLoterie.Properties.Resources.degrade;
            this.panel_gauche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_gauche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_gauche.Controls.Add(this.groupBox_argent);
            this.panel_gauche.Controls.Add(this.groupBox_jouer);
            this.panel_gauche.Controls.Add(this.groupBox_joueur);
            this.panel_gauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_gauche.Enabled = false;
            this.panel_gauche.Location = new System.Drawing.Point(0, 0);
            this.panel_gauche.Name = "panel_gauche";
            this.panel_gauche.Size = new System.Drawing.Size(223, 399);
            this.panel_gauche.TabIndex = 2;
            // 
            // groupBox_argent
            // 
            this.groupBox_argent.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_argent.Controls.Add(this.textBox_argent);
            this.groupBox_argent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_argent.Location = new System.Drawing.Point(10, 124);
            this.groupBox_argent.Name = "groupBox_argent";
            this.groupBox_argent.Size = new System.Drawing.Size(200, 73);
            this.groupBox_argent.TabIndex = 8;
            this.groupBox_argent.TabStop = false;
            this.groupBox_argent.Text = "Argent";
            // 
            // textBox_argent
            // 
            this.textBox_argent.BackColor = System.Drawing.Color.Khaki;
            this.textBox_argent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_argent.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_argent.Location = new System.Drawing.Point(17, 20);
            this.textBox_argent.Name = "textBox_argent";
            this.textBox_argent.ReadOnly = true;
            this.textBox_argent.Size = new System.Drawing.Size(167, 43);
            this.textBox_argent.TabIndex = 8;
            this.textBox_argent.Text = "0";
            this.textBox_argent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_jouer
            // 
            this.groupBox_jouer.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_jouer.Controls.Add(this.numericUpDown_montant);
            this.groupBox_jouer.Controls.Add(this.numericUpDown_nombre);
            this.groupBox_jouer.Controls.Add(this.label_montant);
            this.groupBox_jouer.Controls.Add(this.label_nombre);
            this.groupBox_jouer.Enabled = false;
            this.groupBox_jouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_jouer.Location = new System.Drawing.Point(11, 203);
            this.groupBox_jouer.Name = "groupBox_jouer";
            this.groupBox_jouer.Size = new System.Drawing.Size(200, 181);
            this.groupBox_jouer.TabIndex = 10;
            this.groupBox_jouer.TabStop = false;
            this.groupBox_jouer.Text = "Jouer";
            // 
            // numericUpDown_montant
            // 
            this.numericUpDown_montant.BackColor = System.Drawing.Color.PeachPuff;
            this.numericUpDown_montant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_montant.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_montant.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_montant.Location = new System.Drawing.Point(16, 33);
            this.numericUpDown_montant.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_montant.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_montant.Name = "numericUpDown_montant";
            this.numericUpDown_montant.Size = new System.Drawing.Size(172, 43);
            this.numericUpDown_montant.TabIndex = 1;
            this.numericUpDown_montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_montant.ThousandsSeparator = true;
            this.numericUpDown_montant.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_nombre
            // 
            this.numericUpDown_nombre.BackColor = System.Drawing.Color.Bisque;
            this.numericUpDown_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_nombre.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_nombre.Location = new System.Drawing.Point(58, 103);
            this.numericUpDown_nombre.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_nombre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nombre.Name = "numericUpDown_nombre";
            this.numericUpDown_nombre.Size = new System.Drawing.Size(84, 65);
            this.numericUpDown_nombre.TabIndex = 3;
            this.numericUpDown_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_nombre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_montant
            // 
            this.label_montant.AutoSize = true;
            this.label_montant.Location = new System.Drawing.Point(13, 16);
            this.label_montant.Name = "label_montant";
            this.label_montant.Size = new System.Drawing.Size(90, 13);
            this.label_montant.TabIndex = 0;
            this.label_montant.Text = "Montant du pari :";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(38, 87);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(125, 13);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "Nombre (entre 1 et 10) :";
            // 
            // groupBox_joueur
            // 
            this.groupBox_joueur.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_joueur.BackgroundImage = global::JeuLoterie.Properties.Resources.degrade;
            this.groupBox_joueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox_joueur.Controls.Add(this.panel_edit);
            this.groupBox_joueur.Controls.Add(this.comboBox_joueur);
            this.groupBox_joueur.Controls.Add(this.button_jouer);
            this.groupBox_joueur.Controls.Add(this.button_ajouter);
            this.groupBox_joueur.Controls.Add(this.button_modifier);
            this.groupBox_joueur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_joueur.Location = new System.Drawing.Point(10, 8);
            this.groupBox_joueur.Name = "groupBox_joueur";
            this.groupBox_joueur.Size = new System.Drawing.Size(200, 110);
            this.groupBox_joueur.TabIndex = 9;
            this.groupBox_joueur.TabStop = false;
            this.groupBox_joueur.Text = "Joueur";
            // 
            // panel_edit
            // 
            this.panel_edit.BackColor = System.Drawing.Color.Transparent;
            this.panel_edit.Controls.Add(this.button_edit);
            this.panel_edit.Controls.Add(this.textBox_edit);
            this.panel_edit.Location = new System.Drawing.Point(22, 15);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(157, 29);
            this.panel_edit.TabIndex = 8;
            this.panel_edit.Visible = false;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Silver;
            this.button_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_edit.BackgroundImage")));
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_edit.Location = new System.Drawing.Point(116, 4);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(35, 21);
            this.button_edit.TabIndex = 6;
            this.button_edit.Text = "OK";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_edit
            // 
            this.textBox_edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_edit.CausesValidation = false;
            this.textBox_edit.Location = new System.Drawing.Point(5, 5);
            this.textBox_edit.Name = "textBox_edit";
            this.textBox_edit.Size = new System.Drawing.Size(110, 20);
            this.textBox_edit.TabIndex = 7;
            // 
            // comboBox_joueur
            // 
            this.comboBox_joueur.BackColor = System.Drawing.Color.Silver;
            this.comboBox_joueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_joueur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_joueur.FormattingEnabled = true;
            this.comboBox_joueur.Location = new System.Drawing.Point(27, 19);
            this.comboBox_joueur.Name = "comboBox_joueur";
            this.comboBox_joueur.Size = new System.Drawing.Size(146, 21);
            this.comboBox_joueur.TabIndex = 5;
            // 
            // button_jouer
            // 
            this.button_jouer.BackColor = System.Drawing.Color.LightSalmon;
            this.button_jouer.BackgroundImage = global::JeuLoterie.Properties.Resources.degrade;
            this.button_jouer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_jouer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_jouer.Location = new System.Drawing.Point(27, 74);
            this.button_jouer.Name = "button_jouer";
            this.button_jouer.Size = new System.Drawing.Size(146, 23);
            this.button_jouer.TabIndex = 6;
            this.button_jouer.Text = "Jouer";
            this.button_jouer.UseVisualStyleBackColor = false;
            this.button_jouer.Click += new System.EventHandler(this.button_jouer_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.BackColor = System.Drawing.Color.Silver;
            this.button_ajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ajouter.BackgroundImage")));
            this.button_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ajouter.Location = new System.Drawing.Point(27, 46);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(70, 23);
            this.button_ajouter.TabIndex = 6;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = false;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.BackColor = System.Drawing.Color.Silver;
            this.button_modifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_modifier.BackgroundImage")));
            this.button_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_modifier.Location = new System.Drawing.Point(103, 46);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(70, 23);
            this.button_modifier.TabIndex = 6;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // panel_diffusion
            // 
            this.panel_diffusion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_diffusion.BackgroundImage = global::JeuLoterie.Properties.Resources.green_background;
            this.panel_diffusion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_diffusion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_diffusion.Controls.Add(this.label_nombre3);
            this.panel_diffusion.Controls.Add(this.label_nombre1);
            this.panel_diffusion.Controls.Add(this.label_nombre2);
            this.panel_diffusion.Location = new System.Drawing.Point(7, 15);
            this.panel_diffusion.Name = "panel_diffusion";
            this.panel_diffusion.Size = new System.Drawing.Size(298, 133);
            this.panel_diffusion.TabIndex = 7;
            // 
            // label_nombre3
            // 
            this.label_nombre3.AutoSize = true;
            this.label_nombre3.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_nombre3.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre3.ForeColor = System.Drawing.Color.White;
            this.label_nombre3.Location = new System.Drawing.Point(211, 27);
            this.label_nombre3.Name = "label_nombre3";
            this.label_nombre3.Size = new System.Drawing.Size(68, 77);
            this.label_nombre3.TabIndex = 3;
            this.label_nombre3.Text = "0";
            this.label_nombre3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_nombre1
            // 
            this.label_nombre1.AutoSize = true;
            this.label_nombre1.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_nombre1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre1.ForeColor = System.Drawing.Color.White;
            this.label_nombre1.Location = new System.Drawing.Point(17, 27);
            this.label_nombre1.Name = "label_nombre1";
            this.label_nombre1.Size = new System.Drawing.Size(68, 77);
            this.label_nombre1.TabIndex = 3;
            this.label_nombre1.Text = "0";
            this.label_nombre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_nombre2
            // 
            this.label_nombre2.AutoSize = true;
            this.label_nombre2.BackColor = System.Drawing.Color.Transparent;
            this.label_nombre2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_nombre2.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre2.ForeColor = System.Drawing.Color.White;
            this.label_nombre2.Location = new System.Drawing.Point(114, 27);
            this.label_nombre2.Name = "label_nombre2";
            this.label_nombre2.Size = new System.Drawing.Size(68, 77);
            this.label_nombre2.TabIndex = 3;
            this.label_nombre2.Text = "0";
            this.label_nombre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_stop
            // 
            this.button_stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_stop.BackColor = System.Drawing.Color.Silver;
            this.button_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_stop.BackgroundImage")));
            this.button_stop.Enabled = false;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stop.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop.ForeColor = System.Drawing.Color.White;
            this.button_stop.Location = new System.Drawing.Point(159, 264);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(88, 75);
            this.button_stop.TabIndex = 6;
            this.button_stop.Text = "■";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start
            // 
            this.button_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_start.BackColor = System.Drawing.Color.Silver;
            this.button_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_start.BackgroundImage")));
            this.button_start.Enabled = false;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.Color.White;
            this.button_start.Location = new System.Drawing.Point(65, 264);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(88, 75);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "▶";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // panel_machine
            // 
            this.panel_machine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_machine.BackColor = System.Drawing.Color.Transparent;
            this.panel_machine.Controls.Add(this.button_stop);
            this.panel_machine.Controls.Add(this.button_start);
            this.panel_machine.Controls.Add(this.panel_diffusion);
            this.panel_machine.Enabled = false;
            this.panel_machine.Location = new System.Drawing.Point(243, 25);
            this.panel_machine.Name = "panel_machine";
            this.panel_machine.Size = new System.Drawing.Size(313, 347);
            this.panel_machine.TabIndex = 8;
            // 
            // timer_temps_partie
            // 
            this.timer_temps_partie.Tick += new System.EventHandler(this.timer_temps_partie_Tick);
            // 
            // timer_jeu_machine
            // 
            this.timer_jeu_machine.Tick += new System.EventHandler(this.timer_jeu_machine_Tick);
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::JeuLoterie.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 499);
            this.Controls.Add(this.panel_droit);
            this.Controls.Add(this.panel_gauche);
            this.Controls.Add(this.panel_bas);
            this.Controls.Add(this.panel_machine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu de Loterie II";
            this.panel_bas.ResumeLayout(false);
            this.groupBox_historique.ResumeLayout(false);
            this.groupBox_temps.ResumeLayout(false);
            this.groupBox_temps.PerformLayout();
            this.groupBox_resultat.ResumeLayout(false);
            this.groupBox_resultat.PerformLayout();
            this.panel_droit.ResumeLayout(false);
            this.groupBox_score.ResumeLayout(false);
            this.groupBox_score.PerformLayout();
            this.groupBox_coups.ResumeLayout(false);
            this.groupBox_coups.PerformLayout();
            this.panel_gauche.ResumeLayout(false);
            this.groupBox_argent.ResumeLayout(false);
            this.groupBox_argent.PerformLayout();
            this.groupBox_jouer.ResumeLayout(false);
            this.groupBox_jouer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_montant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nombre)).EndInit();
            this.groupBox_joueur.ResumeLayout(false);
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.panel_diffusion.ResumeLayout(false);
            this.panel_diffusion.PerformLayout();
            this.panel_machine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bas;
        private System.Windows.Forms.Panel panel_droit;
        private System.Windows.Forms.Panel panel_gauche;
        private System.Windows.Forms.ComboBox comboBox_joueur;
        private System.Windows.Forms.NumericUpDown numericUpDown_nombre;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.NumericUpDown numericUpDown_montant;
        private System.Windows.Forms.Label label_montant;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Button button_nouvellePartie;
        private System.Windows.Forms.TextBox textBox_lost;
        private System.Windows.Forms.TextBox textBox_won;
        private System.Windows.Forms.Label label_lost;
        private System.Windows.Forms.Label label_won;
        private System.Windows.Forms.GroupBox groupBox_coups;
        private System.Windows.Forms.TextBox textBox_coups;
        private System.Windows.Forms.GroupBox groupBox_joueur;
        private System.Windows.Forms.Button button_jouer;
        private System.Windows.Forms.GroupBox groupBox_jouer;
        private System.Windows.Forms.GroupBox groupBox_score;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.TextBox textBox_triple;
        private System.Windows.Forms.TextBox textBox_double;
        private System.Windows.Forms.Label label_triple;
        private System.Windows.Forms.Label label_double;
        private System.Windows.Forms.TextBox textBox_single;
        private System.Windows.Forms.Label label_single;
        private System.Windows.Forms.GroupBox groupBox_argent;
        private System.Windows.Forms.TextBox textBox_argent;
        private System.Windows.Forms.GroupBox groupBox_temps;
        private System.Windows.Forms.TextBox textBox_temps;
        private System.Windows.Forms.GroupBox groupBox_resultat;
        private System.Windows.Forms.TextBox textBox_resultat;
        private System.Windows.Forms.GroupBox groupBox_historique;
        private System.Windows.Forms.ListBox listBox_historique;
        private System.Windows.Forms.Label label_nombre1;
        private System.Windows.Forms.Label label_nombre2;
        private System.Windows.Forms.Label label_nombre3;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel panel_diffusion;
        private System.Windows.Forms.Panel panel_machine;
        private System.Windows.Forms.TextBox textBox_edit;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Timer timer_temps_partie;
        private System.Windows.Forms.Timer timer_jeu_machine;
    }
}

