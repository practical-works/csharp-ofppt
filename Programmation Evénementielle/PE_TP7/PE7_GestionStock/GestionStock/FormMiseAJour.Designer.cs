namespace GestionStock
{
    partial class FormMiseAJour
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
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prixVenteLabel;
            System.Windows.Forms.Label quantiteLabel;
            System.Windows.Forms.Label referenceLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_rechercheAV = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.TextBox_nom = new System.Windows.Forms.TextBox();
            this.TextBox_prixVente = new System.Windows.Forms.TextBox();
            this.TextBox_quantite = new System.Windows.Forms.TextBox();
            this.TextBox_reference = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView_article = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource_article = new System.Windows.Forms.BindingSource(this.components);
            nomLabel = new System.Windows.Forms.Label();
            prixVenteLabel = new System.Windows.Forms.Label();
            quantiteLabel = new System.Windows.Forms.Label();
            referenceLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_article)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_article)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            nomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(17, 51);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(35, 13);
            nomLabel.TabIndex = 0;
            nomLabel.Text = "Nom :";
            // 
            // prixVenteLabel
            // 
            prixVenteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            prixVenteLabel.AutoSize = true;
            prixVenteLabel.Location = new System.Drawing.Point(17, 77);
            prixVenteLabel.Name = "prixVenteLabel";
            prixVenteLabel.Size = new System.Drawing.Size(78, 13);
            prixVenteLabel.TabIndex = 2;
            prixVenteLabel.Text = "Prix de vente :";
            // 
            // quantiteLabel
            // 
            quantiteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            quantiteLabel.AutoSize = true;
            quantiteLabel.Location = new System.Drawing.Point(17, 103);
            quantiteLabel.Name = "quantiteLabel";
            quantiteLabel.Size = new System.Drawing.Size(56, 13);
            quantiteLabel.TabIndex = 4;
            quantiteLabel.Text = "Quantité :";
            // 
            // referenceLabel
            // 
            referenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            referenceLabel.AutoSize = true;
            referenceLabel.Location = new System.Drawing.Point(17, 25);
            referenceLabel.Name = "referenceLabel";
            referenceLabel.Size = new System.Drawing.Size(64, 13);
            referenceLabel.TabIndex = 6;
            referenceLabel.Text = "Référence :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_rechercheAV);
            this.groupBox1.Controls.Add(this.button_ajouter);
            this.groupBox1.Controls.Add(this.button_supprimer);
            this.groupBox1.Controls.Add(this.button_modifier);
            this.groupBox1.Controls.Add(this.button_rechercher);
            this.groupBox1.Controls.Add(this.button_nouveau);
            this.groupBox1.Controls.Add(nomLabel);
            this.groupBox1.Controls.Add(this.TextBox_nom);
            this.groupBox1.Controls.Add(prixVenteLabel);
            this.groupBox1.Controls.Add(this.TextBox_prixVente);
            this.groupBox1.Controls.Add(quantiteLabel);
            this.groupBox1.Controls.Add(this.TextBox_quantite);
            this.groupBox1.Controls.Add(referenceLabel);
            this.groupBox1.Controls.Add(this.TextBox_reference);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.MinimumSize = new System.Drawing.Size(659, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_rechercheAV
            // 
            this.button_rechercheAV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rechercheAV.Location = new System.Drawing.Point(498, 97);
            this.button_rechercheAV.Name = "button_rechercheAV";
            this.button_rechercheAV.Size = new System.Drawing.Size(143, 23);
            this.button_rechercheAV.TabIndex = 8;
            this.button_rechercheAV.Text = "Recherche Avancée";
            this.button_rechercheAV.UseVisualStyleBackColor = true;
            this.button_rechercheAV.Click += new System.EventHandler(this.button_RechercheAV_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ajouter.Location = new System.Drawing.Point(349, 97);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(143, 23);
            this.button_ajouter.TabIndex = 8;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_supprimer.Location = new System.Drawing.Point(498, 60);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(143, 23);
            this.button_supprimer.TabIndex = 8;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_modifier.Location = new System.Drawing.Point(498, 23);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(143, 23);
            this.button_modifier.TabIndex = 8;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_rechercher
            // 
            this.button_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rechercher.Location = new System.Drawing.Point(349, 60);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(143, 23);
            this.button_rechercher.TabIndex = 8;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.UseVisualStyleBackColor = true;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_nouveau.Location = new System.Drawing.Point(349, 23);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(143, 23);
            this.button_nouveau.TabIndex = 8;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // TextBox_nom
            // 
            this.TextBox_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_nom.Location = new System.Drawing.Point(98, 48);
            this.TextBox_nom.Name = "TextBox_nom";
            this.TextBox_nom.Size = new System.Drawing.Size(232, 20);
            this.TextBox_nom.TabIndex = 1;
            // 
            // TextBox_prixVente
            // 
            this.TextBox_prixVente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_prixVente.Location = new System.Drawing.Point(98, 74);
            this.TextBox_prixVente.Name = "TextBox_prixVente";
            this.TextBox_prixVente.Size = new System.Drawing.Size(232, 20);
            this.TextBox_prixVente.TabIndex = 3;
            // 
            // TextBox_quantite
            // 
            this.TextBox_quantite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_quantite.Location = new System.Drawing.Point(98, 100);
            this.TextBox_quantite.Name = "TextBox_quantite";
            this.TextBox_quantite.Size = new System.Drawing.Size(232, 20);
            this.TextBox_quantite.TabIndex = 5;
            // 
            // TextBox_reference
            // 
            this.TextBox_reference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_reference.BackColor = System.Drawing.Color.AliceBlue;
            this.TextBox_reference.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_reference.ForeColor = System.Drawing.Color.Blue;
            this.TextBox_reference.Location = new System.Drawing.Point(98, 22);
            this.TextBox_reference.Name = "TextBox_reference";
            this.TextBox_reference.Size = new System.Drawing.Size(232, 21);
            this.TextBox_reference.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DataGridView_article);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.MinimumSize = new System.Drawing.Size(659, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // DataGridView_article
            // 
            this.DataGridView_article.AllowUserToAddRows = false;
            this.DataGridView_article.AllowUserToDeleteRows = false;
            this.DataGridView_article.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_article.AutoGenerateColumns = false;
            this.DataGridView_article.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_article.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_article.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DataGridView_article.DataSource = this.BindingSource_article;
            this.DataGridView_article.Location = new System.Drawing.Point(18, 19);
            this.DataGridView_article.Name = "DataGridView_article";
            this.DataGridView_article.ReadOnly = true;
            this.DataGridView_article.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_article.Size = new System.Drawing.Size(622, 175);
            this.DataGridView_article.TabIndex = 0;
            this.DataGridView_article.SelectionChanged += new System.EventHandler(this.DataGridView_article_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Reference";
            this.dataGridViewTextBoxColumn1.FillWeight = 48.35924F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Référence";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.FillWeight = 223.7029F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrixVente";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.FillWeight = 66.33734F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix de vente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantite";
            this.dataGridViewTextBoxColumn4.FillWeight = 61.6005F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantité";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // BindingSource_article
            // 
            this.BindingSource_article.DataSource = typeof(GestionStock.Article);
            // 
            // FormMiseAJour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMiseAJour";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mise çà jour des articles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_article)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_article)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridView_article;
        private System.Windows.Forms.TextBox TextBox_nom;
        private System.Windows.Forms.TextBox TextBox_prixVente;
        private System.Windows.Forms.TextBox TextBox_quantite;
        private System.Windows.Forms.TextBox TextBox_reference;
        private System.Windows.Forms.Button button_rechercheAV;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.BindingSource BindingSource_article;
    }
}

