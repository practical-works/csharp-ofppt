namespace FicheClient
{
    partial class Form_saisie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_effacer = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.dateTimePicker_naissance = new System.Windows.Forms.DateTimePicker();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.textBox_codePostal = new System.Windows.Forms.TextBox();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Né le";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Code postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ville";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(192, 181);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(87, 26);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_effacer
            // 
            this.button_effacer.Location = new System.Drawing.Point(287, 181);
            this.button_effacer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_effacer.Name = "button_effacer";
            this.button_effacer.Size = new System.Drawing.Size(87, 26);
            this.button_effacer.TabIndex = 7;
            this.button_effacer.Text = "Effacer";
            this.button_effacer.UseVisualStyleBackColor = true;
            this.button_effacer.Click += new System.EventHandler(this.button_effacer_Click);
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(381, 181);
            this.button_quitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(87, 26);
            this.button_quitter.TabIndex = 8;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(117, 35);
            this.textBox_nom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(352, 24);
            this.textBox_nom.TabIndex = 0;
            this.textBox_nom.TextChanged += new System.EventHandler(this.control_TextChanged);
            this.textBox_nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.textBox_nom.Validated += new System.EventHandler(this.control_Validated);
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(117, 67);
            this.textBox_prenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(174, 24);
            this.textBox_prenom.TabIndex = 1;
            this.textBox_prenom.TextChanged += new System.EventHandler(this.control_TextChanged);
            this.textBox_prenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.textBox_prenom.Validated += new System.EventHandler(this.control_Validated);
            // 
            // dateTimePicker_naissance
            // 
            this.dateTimePicker_naissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_naissance.Location = new System.Drawing.Point(346, 67);
            this.dateTimePicker_naissance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_naissance.Name = "dateTimePicker_naissance";
            this.dateTimePicker_naissance.Size = new System.Drawing.Size(123, 24);
            this.dateTimePicker_naissance.TabIndex = 2;
            this.dateTimePicker_naissance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(117, 99);
            this.textBox_adresse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(352, 24);
            this.textBox_adresse.TabIndex = 3;
            this.textBox_adresse.TextChanged += new System.EventHandler(this.control_TextChanged);
            this.textBox_adresse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.textBox_adresse.Validated += new System.EventHandler(this.control_Validated);
            // 
            // textBox_codePostal
            // 
            this.textBox_codePostal.Location = new System.Drawing.Point(117, 131);
            this.textBox_codePostal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_codePostal.Name = "textBox_codePostal";
            this.textBox_codePostal.Size = new System.Drawing.Size(116, 24);
            this.textBox_codePostal.TabIndex = 4;
            this.textBox_codePostal.TextChanged += new System.EventHandler(this.control_TextChanged);
            this.textBox_codePostal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.textBox_codePostal.Validated += new System.EventHandler(this.control_Validated);
            // 
            // textBox_ville
            // 
            this.textBox_ville.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.textBox_ville.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_ville.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_ville.Location = new System.Drawing.Point(299, 132);
            this.textBox_ville.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(170, 24);
            this.textBox_ville.TabIndex = 5;
            this.textBox_ville.TextChanged += new System.EventHandler(this.control_TextChanged);
            this.textBox_ville.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            this.textBox_ville.Validated += new System.EventHandler(this.control_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 100;
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 221);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(504, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel1.Text = "En attente de saisie";
            // 
            // Form_saisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 243);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateTimePicker_naissance);
            this.Controls.Add(this.textBox_ville);
            this.Controls.Add(this.textBox_codePostal);
            this.Controls.Add(this.textBox_adresse);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_effacer);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_saisie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saisie";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_effacer;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.DateTimePicker dateTimePicker_naissance;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.TextBox textBox_codePostal;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

