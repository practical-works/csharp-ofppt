namespace PE_EFM_2015
{
    partial class Form_GArticles
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
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.txt_remise = new System.Windows.Forms.TextBox();
            this.cb_categorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_solde = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_articles = new System.Windows.Forms.DataGridView();
            this.txt_prix = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articles)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(346, 39);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(137, 30);
            this.btn_ajouter.TabIndex = 0;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(346, 79);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(137, 30);
            this.btn_supprimer.TabIndex = 1;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(187, 43);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(121, 20);
            this.txt_code.TabIndex = 2;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(346, 119);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(137, 30);
            this.btn_fermer.TabIndex = 3;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(187, 75);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(121, 20);
            this.txt_designation.TabIndex = 2;
            // 
            // txt_remise
            // 
            this.txt_remise.Location = new System.Drawing.Point(362, 177);
            this.txt_remise.Name = "txt_remise";
            this.txt_remise.Size = new System.Drawing.Size(121, 20);
            this.txt_remise.TabIndex = 2;
            // 
            // cb_categorie
            // 
            this.cb_categorie.FormattingEnabled = true;
            this.cb_categorie.Location = new System.Drawing.Point(187, 107);
            this.cb_categorie.Name = "cb_categorie";
            this.cb_categorie.Size = new System.Drawing.Size(121, 21);
            this.cb_categorie.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Editer les articles :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code article:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Désignation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Catégorie:";
            // 
            // cb_solde
            // 
            this.cb_solde.AutoSize = true;
            this.cb_solde.Location = new System.Drawing.Point(112, 179);
            this.cb_solde.Name = "cb_solde";
            this.cb_solde.Size = new System.Drawing.Size(99, 17);
            this.cb_solde.TabIndex = 8;
            this.cb_solde.Text = "Article en solde";
            this.cb_solde.UseVisualStyleBackColor = true;
            this.cb_solde.CheckedChanged += new System.EventHandler(this.cb_solde_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prix:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pourcentage de réduction:";
            // 
            // dgv_articles
            // 
            this.dgv_articles.AllowUserToAddRows = false;
            this.dgv_articles.AllowUserToDeleteRows = false;
            this.dgv_articles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articles.Location = new System.Drawing.Point(13, 218);
            this.dgv_articles.Name = "dgv_articles";
            this.dgv_articles.ReadOnly = true;
            this.dgv_articles.Size = new System.Drawing.Size(567, 148);
            this.dgv_articles.TabIndex = 11;
            this.dgv_articles.SelectionChanged += new System.EventHandler(this.dgv_articles_SelectionChanged);
            // 
            // txt_prix
            // 
            this.txt_prix.Location = new System.Drawing.Point(187, 139);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(121, 20);
            this.txt_prix.TabIndex = 2;
            // 
            // Form_GArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 380);
            this.Controls.Add(this.dgv_articles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_solde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_categorie);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.txt_prix);
            this.Controls.Add(this.txt_remise);
            this.Controls.Add(this.txt_designation);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_GArticles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des articles";
            this.Load += new System.EventHandler(this.Form_GArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.TextBox txt_remise;
        private System.Windows.Forms.ComboBox cb_categorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_solde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_articles;
        private System.Windows.Forms.TextBox txt_prix;
    }
}

