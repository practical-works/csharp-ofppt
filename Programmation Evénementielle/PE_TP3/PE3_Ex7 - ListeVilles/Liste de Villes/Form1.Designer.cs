namespace Liste_de_Villes
{
    partial class Form_main
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
            this.label_ville = new System.Windows.Forms.Label();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.listBox_villes = new System.Windows.Forms.ListBox();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_trier = new System.Windows.Forms.Button();
            this.button_vider = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ville
            // 
            this.label_ville.AutoSize = true;
            this.label_ville.Location = new System.Drawing.Point(11, 23);
            this.label_ville.Name = "label_ville";
            this.label_ville.Size = new System.Drawing.Size(37, 13);
            this.label_ville.TabIndex = 0;
            this.label_ville.Text = "Ville";
            // 
            // textBox_ville
            // 
            this.textBox_ville.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ville.BackColor = System.Drawing.Color.LightGray;
            this.textBox_ville.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ville.Location = new System.Drawing.Point(54, 21);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(198, 20);
            this.textBox_ville.TabIndex = 1;
            this.textBox_ville.TextChanged += new System.EventHandler(this.textBox_ville_TextChanged);
            // 
            // listBox_villes
            // 
            this.listBox_villes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_villes.BackColor = System.Drawing.Color.LightGray;
            this.listBox_villes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_villes.FormattingEnabled = true;
            this.listBox_villes.Items.AddRange(new object[] {
            "Rabat",
            "Ouarzazate",
            "Salé",
            "Safi",
            "Témara",
            "Meknès",
            "BenSlimane",
            "Errachidia",
            "Kénitra",
            "Efrane",
            "Khémisset",
            "Khénifra",
            "SidiKacem",
            "Oujda",
            "Casablanca",
            "Figuig",
            "Mohammédia",
            "Nador",
            "Azilal",
            "Laâyoune",
            "Bénimellal",
            "Boujdour",
            "Eljadida",
            "EsSemara",
            "Khouribga",
            "Dakhla",
            "Settat",
            "Agadir",
            "Fès",
            "Guelmim",
            "Sefrou",
            "TanTan",
            "AlHoceima",
            "Taroudannt",
            "Boulemane",
            "Tata",
            "Taounate",
            "Tiznit",
            "Taza",
            "Tanger",
            "Marrakech",
            "Chefchaouen",
            "Chichaoua",
            "Larache",
            "AlkelaadesSraghna",
            "Tétouan",
            "Essaouirra"});
            this.listBox_villes.Location = new System.Drawing.Point(54, 69);
            this.listBox_villes.Name = "listBox_villes";
            this.listBox_villes.Size = new System.Drawing.Size(198, 197);
            this.listBox_villes.TabIndex = 2;
            this.listBox_villes.SelectedIndexChanged += new System.EventHandler(this.listBox_villes_SelectedIndexChanged);
            // 
            // button_rechercher
            // 
            this.button_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rechercher.BackColor = System.Drawing.Color.Gainsboro;
            this.button_rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rechercher.Location = new System.Drawing.Point(269, 21);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(75, 23);
            this.button_rechercher.TabIndex = 3;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.UseVisualStyleBackColor = false;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ajouter.BackColor = System.Drawing.Color.Silver;
            this.button_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajouter.Location = new System.Drawing.Point(267, 68);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 3;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = false;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_supprimer.BackColor = System.Drawing.Color.Silver;
            this.button_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_supprimer.Location = new System.Drawing.Point(267, 97);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 3;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_trier
            // 
            this.button_trier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_trier.BackColor = System.Drawing.Color.Silver;
            this.button_trier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trier.Location = new System.Drawing.Point(267, 126);
            this.button_trier.Name = "button_trier";
            this.button_trier.Size = new System.Drawing.Size(75, 23);
            this.button_trier.TabIndex = 3;
            this.button_trier.Text = "Trier";
            this.button_trier.UseVisualStyleBackColor = false;
            this.button_trier.Click += new System.EventHandler(this.button_trier_Click);
            // 
            // button_vider
            // 
            this.button_vider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_vider.BackColor = System.Drawing.Color.Silver;
            this.button_vider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vider.Location = new System.Drawing.Point(269, 213);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(75, 23);
            this.button_vider.TabIndex = 3;
            this.button_vider.Text = "Vider";
            this.button_vider.UseVisualStyleBackColor = false;
            this.button_vider.Click += new System.EventHandler(this.button_vider_Click);
            // 
            // button_quitter
            // 
            this.button_quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_quitter.BackColor = System.Drawing.Color.Silver;
            this.button_quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quitter.Location = new System.Drawing.Point(268, 242);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(75, 23);
            this.button_quitter.TabIndex = 3;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = false;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // Form_main
            // 
            this.AcceptButton = this.button_rechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.button_quitter;
            this.ClientSize = new System.Drawing.Size(354, 287);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_vider);
            this.Controls.Add(this.button_trier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.button_rechercher);
            this.Controls.Add(this.listBox_villes);
            this.Controls.Add(this.textBox_ville);
            this.Controls.Add(this.label_ville);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(362, 314);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste de Villes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ville;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.ListBox listBox_villes;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_trier;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.Button button_quitter;
    }
}

