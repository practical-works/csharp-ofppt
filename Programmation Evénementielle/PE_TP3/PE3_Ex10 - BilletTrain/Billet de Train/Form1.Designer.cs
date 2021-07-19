namespace Billet_de_Train
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.pictureBox_train = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_quitter = new System.Windows.Forms.Button();
            this.button_reinitialiser = new System.Windows.Forms.Button();
            this.button_calculer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_money = new System.Windows.Forms.PictureBox();
            this.comboBox_reduction = new System.Windows.Forms.ComboBox();
            this.label_reduction = new System.Windows.Forms.Label();
            this.listBox_typebillet = new System.Windows.Forms.ListBox();
            this.label_typebillet = new System.Windows.Forms.Label();
            this.textBox_prixbase = new System.Windows.Forms.TextBox();
            this.label_prixbase = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_prixTTC = new System.Windows.Forms.TextBox();
            this.textBox_TVA = new System.Windows.Forms.TextBox();
            this.textBox_prixHT = new System.Windows.Forms.TextBox();
            this.label_prixTTC = new System.Windows.Forms.Label();
            this.label_prixTVA = new System.Windows.Forms.Label();
            this.label_prixHT = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_train)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_train
            // 
            this.pictureBox_train.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_train.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_train.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_train.Image = global::Billet_de_Train.Properties.Resources.train_animation;
            this.pictureBox_train.Location = new System.Drawing.Point(-9, -25);
            this.pictureBox_train.Name = "pictureBox_train";
            this.pictureBox_train.Size = new System.Drawing.Size(500, 322);
            this.pictureBox_train.TabIndex = 1;
            this.pictureBox_train.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_quitter);
            this.panel3.Controls.Add(this.button_reinitialiser);
            this.panel3.Controls.Add(this.button_calculer);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(349, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 100);
            this.panel3.TabIndex = 2;
            // 
            // button_quitter
            // 
            this.button_quitter.BackColor = System.Drawing.Color.Plum;
            this.button_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quitter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_quitter.Location = new System.Drawing.Point(23, 66);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(75, 23);
            this.button_quitter.TabIndex = 2;
            this.button_quitter.Text = "Quitter";
            this.toolTip1.SetToolTip(this.button_quitter, "Fermer l\'application");
            this.button_quitter.UseVisualStyleBackColor = false;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // button_reinitialiser
            // 
            this.button_reinitialiser.BackColor = System.Drawing.Color.Plum;
            this.button_reinitialiser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_reinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reinitialiser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_reinitialiser.Location = new System.Drawing.Point(23, 38);
            this.button_reinitialiser.Name = "button_reinitialiser";
            this.button_reinitialiser.Size = new System.Drawing.Size(75, 23);
            this.button_reinitialiser.TabIndex = 1;
            this.button_reinitialiser.Text = "Réinitialiser";
            this.toolTip1.SetToolTip(this.button_reinitialiser, "Vider tout les champs");
            this.button_reinitialiser.UseVisualStyleBackColor = false;
            this.button_reinitialiser.Click += new System.EventHandler(this.button_reinitialiser_Click);
            // 
            // button_calculer
            // 
            this.button_calculer.BackColor = System.Drawing.Color.Plum;
            this.button_calculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_calculer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_calculer.Location = new System.Drawing.Point(23, 10);
            this.button_calculer.Name = "button_calculer";
            this.button_calculer.Size = new System.Drawing.Size(75, 23);
            this.button_calculer.TabIndex = 0;
            this.button_calculer.Text = "Calculer";
            this.toolTip1.SetToolTip(this.button_calculer, "Calculer les prix du billet");
            this.button_calculer.UseVisualStyleBackColor = false;
            this.button_calculer.Click += new System.EventHandler(this.button_calculer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox_money);
            this.panel1.Controls.Add(this.comboBox_reduction);
            this.panel1.Controls.Add(this.label_reduction);
            this.panel1.Controls.Add(this.listBox_typebillet);
            this.panel1.Controls.Add(this.label_typebillet);
            this.panel1.Controls.Add(this.textBox_prixbase);
            this.panel1.Controls.Add(this.label_prixbase);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 114);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_money
            // 
            this.pictureBox_money.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_money.Image = global::Billet_de_Train.Properties.Resources.money;
            this.pictureBox_money.Location = new System.Drawing.Point(167, 7);
            this.pictureBox_money.Name = "pictureBox_money";
            this.pictureBox_money.Size = new System.Drawing.Size(32, 28);
            this.pictureBox_money.TabIndex = 3;
            this.pictureBox_money.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox_money, "Le montant est supposé exprimé dans la device considérée.\r\n(Dollar, Euro, Dirham," +
                    " ...etc)");
            // 
            // comboBox_reduction
            // 
            this.comboBox_reduction.BackColor = System.Drawing.Color.Thistle;
            this.comboBox_reduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_reduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_reduction.FormattingEnabled = true;
            this.comboBox_reduction.Items.AddRange(new object[] {
            "Pas de Réduction",
            "Carte Jeune",
            "Carte Adulte",
            "Carte Famille"});
            this.comboBox_reduction.Location = new System.Drawing.Point(97, 77);
            this.comboBox_reduction.Name = "comboBox_reduction";
            this.comboBox_reduction.Size = new System.Drawing.Size(102, 21);
            this.comboBox_reduction.TabIndex = 5;
            this.toolTip1.SetToolTip(this.comboBox_reduction, resources.GetString("comboBox_reduction.ToolTip"));
            // 
            // label_reduction
            // 
            this.label_reduction.AutoSize = true;
            this.label_reduction.Location = new System.Drawing.Point(18, 80);
            this.label_reduction.Name = "label_reduction";
            this.label_reduction.Size = new System.Drawing.Size(62, 13);
            this.label_reduction.TabIndex = 4;
            this.label_reduction.Text = "Réduction :";
            // 
            // listBox_typebillet
            // 
            this.listBox_typebillet.BackColor = System.Drawing.Color.Thistle;
            this.listBox_typebillet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_typebillet.FormattingEnabled = true;
            this.listBox_typebillet.Items.AddRange(new object[] {
            "Première Classe",
            "Deuxième Classe"});
            this.listBox_typebillet.Location = new System.Drawing.Point(98, 41);
            this.listBox_typebillet.Name = "listBox_typebillet";
            this.listBox_typebillet.Size = new System.Drawing.Size(101, 28);
            this.listBox_typebillet.TabIndex = 3;
            this.toolTip1.SetToolTip(this.listBox_typebillet, "Le prix de la première classe est égal au prix de base + 20% de celui-ci. \r\nLe pr" +
                    "ix de la deuxième classe est égal au prix de base. ");
            // 
            // label_typebillet
            // 
            this.label_typebillet.AutoSize = true;
            this.label_typebillet.Location = new System.Drawing.Point(18, 45);
            this.label_typebillet.Name = "label_typebillet";
            this.label_typebillet.Size = new System.Drawing.Size(78, 13);
            this.label_typebillet.TabIndex = 2;
            this.label_typebillet.Text = "Type du Billet :";
            // 
            // textBox_prixbase
            // 
            this.textBox_prixbase.BackColor = System.Drawing.Color.Thistle;
            this.textBox_prixbase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_prixbase.Location = new System.Drawing.Point(98, 15);
            this.textBox_prixbase.Name = "textBox_prixbase";
            this.textBox_prixbase.Size = new System.Drawing.Size(63, 20);
            this.textBox_prixbase.TabIndex = 1;
            this.textBox_prixbase.Text = "0";
            this.toolTip1.SetToolTip(this.textBox_prixbase, "Prix original du billet");
            // 
            // label_prixbase
            // 
            this.label_prixbase.AutoSize = true;
            this.label_prixbase.Location = new System.Drawing.Point(18, 18);
            this.label_prixbase.Name = "label_prixbase";
            this.label_prixbase.Size = new System.Drawing.Size(73, 13);
            this.label_prixbase.TabIndex = 0;
            this.label_prixbase.Text = "Prix de Base :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_prixTTC);
            this.panel2.Controls.Add(this.textBox_TVA);
            this.panel2.Controls.Add(this.textBox_prixHT);
            this.panel2.Controls.Add(this.label_prixTTC);
            this.panel2.Controls.Add(this.label_prixTVA);
            this.panel2.Controls.Add(this.label_prixHT);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 100);
            this.panel2.TabIndex = 1;
            // 
            // textBox_prixTTC
            // 
            this.textBox_prixTTC.BackColor = System.Drawing.Color.Thistle;
            this.textBox_prixTTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_prixTTC.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_prixTTC.Location = new System.Drawing.Point(75, 65);
            this.textBox_prixTTC.Name = "textBox_prixTTC";
            this.textBox_prixTTC.ReadOnly = true;
            this.textBox_prixTTC.Size = new System.Drawing.Size(54, 20);
            this.textBox_prixTTC.TabIndex = 5;
            this.textBox_prixTTC.Text = "0";
            // 
            // textBox_TVA
            // 
            this.textBox_TVA.BackColor = System.Drawing.Color.Thistle;
            this.textBox_TVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TVA.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_TVA.Location = new System.Drawing.Point(75, 39);
            this.textBox_TVA.Name = "textBox_TVA";
            this.textBox_TVA.ReadOnly = true;
            this.textBox_TVA.Size = new System.Drawing.Size(54, 20);
            this.textBox_TVA.TabIndex = 4;
            this.textBox_TVA.Text = "0";
            // 
            // textBox_prixHT
            // 
            this.textBox_prixHT.BackColor = System.Drawing.Color.Thistle;
            this.textBox_prixHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_prixHT.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_prixHT.Location = new System.Drawing.Point(75, 13);
            this.textBox_prixHT.Name = "textBox_prixHT";
            this.textBox_prixHT.ReadOnly = true;
            this.textBox_prixHT.Size = new System.Drawing.Size(54, 20);
            this.textBox_prixHT.TabIndex = 3;
            this.textBox_prixHT.Text = "0";
            // 
            // label_prixTTC
            // 
            this.label_prixTTC.AutoSize = true;
            this.label_prixTTC.Location = new System.Drawing.Point(19, 68);
            this.label_prixTTC.Name = "label_prixTTC";
            this.label_prixTTC.Size = new System.Drawing.Size(54, 13);
            this.label_prixTTC.TabIndex = 2;
            this.label_prixTTC.Text = "Prix TTC :";
            // 
            // label_prixTVA
            // 
            this.label_prixTVA.AutoSize = true;
            this.label_prixTVA.Location = new System.Drawing.Point(19, 42);
            this.label_prixTVA.Name = "label_prixTVA";
            this.label_prixTVA.Size = new System.Drawing.Size(33, 13);
            this.label_prixTVA.TabIndex = 1;
            this.label_prixTVA.Text = "TVA :";
            // 
            // label_prixHT
            // 
            this.label_prixHT.AutoSize = true;
            this.label_prixHT.Location = new System.Drawing.Point(19, 16);
            this.label_prixHT.Name = "label_prixHT";
            this.label_prixHT.Size = new System.Drawing.Size(48, 13);
            this.label_prixHT.TabIndex = 0;
            this.label_prixHT.Text = "Prix HT :";
            // 
            // Form_main
            // 
            this.AcceptButton = this.button_calculer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Billet_de_Train.Properties.Resources.purple;
            this.CancelButton = this.button_reinitialiser;
            this.ClientSize = new System.Drawing.Size(483, 273);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_train);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billet de Train";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_train)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_money)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_train;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Button button_reinitialiser;
        private System.Windows.Forms.Button button_calculer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_reduction;
        private System.Windows.Forms.Label label_reduction;
        private System.Windows.Forms.ListBox listBox_typebillet;
        private System.Windows.Forms.Label label_typebillet;
        private System.Windows.Forms.TextBox textBox_prixbase;
        private System.Windows.Forms.Label label_prixbase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_prixTTC;
        private System.Windows.Forms.TextBox textBox_TVA;
        private System.Windows.Forms.TextBox textBox_prixHT;
        private System.Windows.Forms.Label label_prixTTC;
        private System.Windows.Forms.Label label_prixTVA;
        private System.Windows.Forms.Label label_prixHT;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox_money;
    }
}

