namespace PE2_Ex7
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
            this.checkBox_AfficherCouleurs = new System.Windows.Forms.CheckBox();
            this.button_quitter = new System.Windows.Forms.Button();
            this.groupBox_Couleurs = new System.Windows.Forms.GroupBox();
            this.radioButton_bleu = new System.Windows.Forms.RadioButton();
            this.radioButton_vert = new System.Windows.Forms.RadioButton();
            this.radioButton_rouge = new System.Windows.Forms.RadioButton();
            this.groupBox_Couleurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_AfficherCouleurs
            // 
            this.checkBox_AfficherCouleurs.AutoSize = true;
            this.checkBox_AfficherCouleurs.Location = new System.Drawing.Point(12, 16);
            this.checkBox_AfficherCouleurs.Name = "checkBox_AfficherCouleurs";
            this.checkBox_AfficherCouleurs.Size = new System.Drawing.Size(123, 17);
            this.checkBox_AfficherCouleurs.TabIndex = 0;
            this.checkBox_AfficherCouleurs.Text = "Afficher les coulerus";
            this.checkBox_AfficherCouleurs.UseVisualStyleBackColor = true;
            this.checkBox_AfficherCouleurs.CheckedChanged += new System.EventHandler(this.checkBox_AfficherCouleurs_CheckedChanged);
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(389, 12);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(75, 23);
            this.button_quitter.TabIndex = 1;
            this.button_quitter.Text = "Quiiter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // groupBox_Couleurs
            // 
            this.groupBox_Couleurs.Controls.Add(this.radioButton_bleu);
            this.groupBox_Couleurs.Controls.Add(this.radioButton_vert);
            this.groupBox_Couleurs.Controls.Add(this.radioButton_rouge);
            this.groupBox_Couleurs.Location = new System.Drawing.Point(12, 119);
            this.groupBox_Couleurs.Name = "groupBox_Couleurs";
            this.groupBox_Couleurs.Size = new System.Drawing.Size(452, 87);
            this.groupBox_Couleurs.TabIndex = 2;
            this.groupBox_Couleurs.TabStop = false;
            this.groupBox_Couleurs.Text = "Couleurs";
            // 
            // radioButton_bleu
            // 
            this.radioButton_bleu.AutoSize = true;
            this.radioButton_bleu.Location = new System.Drawing.Point(344, 35);
            this.radioButton_bleu.Name = "radioButton_bleu";
            this.radioButton_bleu.Size = new System.Drawing.Size(45, 17);
            this.radioButton_bleu.TabIndex = 2;
            this.radioButton_bleu.TabStop = true;
            this.radioButton_bleu.Text = "Bleu";
            this.radioButton_bleu.UseVisualStyleBackColor = true;
            this.radioButton_bleu.CheckedChanged += new System.EventHandler(this.radioButton_bleu_CheckedChanged);
            // 
            // radioButton_vert
            // 
            this.radioButton_vert.AutoSize = true;
            this.radioButton_vert.Location = new System.Drawing.Point(209, 35);
            this.radioButton_vert.Name = "radioButton_vert";
            this.radioButton_vert.Size = new System.Drawing.Size(45, 17);
            this.radioButton_vert.TabIndex = 1;
            this.radioButton_vert.TabStop = true;
            this.radioButton_vert.Text = "Vert";
            this.radioButton_vert.UseVisualStyleBackColor = true;
            this.radioButton_vert.CheckedChanged += new System.EventHandler(this.radioButton_vert_CheckedChanged);
            // 
            // radioButton_rouge
            // 
            this.radioButton_rouge.AutoSize = true;
            this.radioButton_rouge.Location = new System.Drawing.Point(63, 35);
            this.radioButton_rouge.Name = "radioButton_rouge";
            this.radioButton_rouge.Size = new System.Drawing.Size(56, 17);
            this.radioButton_rouge.TabIndex = 0;
            this.radioButton_rouge.TabStop = true;
            this.radioButton_rouge.Text = "Rouge";
            this.radioButton_rouge.UseVisualStyleBackColor = true;
            this.radioButton_rouge.CheckedChanged += new System.EventHandler(this.radioButton_rouge_CheckedChanged);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 50);
            this.Controls.Add(this.groupBox_Couleurs);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.checkBox_AfficherCouleurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu de Couleurs";
            this.groupBox_Couleurs.ResumeLayout(false);
            this.groupBox_Couleurs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_AfficherCouleurs;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.GroupBox groupBox_Couleurs;
        private System.Windows.Forms.RadioButton radioButton_bleu;
        private System.Windows.Forms.RadioButton radioButton_vert;
        private System.Windows.Forms.RadioButton radioButton_rouge;
    }
}

