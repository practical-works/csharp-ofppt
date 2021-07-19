namespace PE2_Ex3
{
    partial class Form1
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
            this.label_nom = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.groupBox_sexe = new System.Windows.Forms.GroupBox();
            this.groupBox_situation = new System.Windows.Forms.GroupBox();
            this.button_afficher = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            this.radioButton_homme = new System.Windows.Forms.RadioButton();
            this.radioButton_femme = new System.Windows.Forms.RadioButton();
            this.radioButton_célibataire = new System.Windows.Forms.RadioButton();
            this.radioButton_marié = new System.Windows.Forms.RadioButton();
            this.groupBox_sexe.SuspendLayout();
            this.groupBox_situation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(13, 13);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(80, 13);
            this.label_nom.TabIndex = 0;
            this.label_nom.Text = "Nom et Prénom";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(99, 13);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(201, 20);
            this.textBox_nom.TabIndex = 1;
            // 
            // groupBox_sexe
            // 
            this.groupBox_sexe.Controls.Add(this.radioButton_femme);
            this.groupBox_sexe.Controls.Add(this.radioButton_homme);
            this.groupBox_sexe.Location = new System.Drawing.Point(16, 39);
            this.groupBox_sexe.Name = "groupBox_sexe";
            this.groupBox_sexe.Size = new System.Drawing.Size(139, 74);
            this.groupBox_sexe.TabIndex = 2;
            this.groupBox_sexe.TabStop = false;
            this.groupBox_sexe.Text = "Sexe";
            // 
            // groupBox_situation
            // 
            this.groupBox_situation.Controls.Add(this.radioButton_célibataire);
            this.groupBox_situation.Controls.Add(this.radioButton_marié);
            this.groupBox_situation.Location = new System.Drawing.Point(161, 39);
            this.groupBox_situation.Name = "groupBox_situation";
            this.groupBox_situation.Size = new System.Drawing.Size(139, 74);
            this.groupBox_situation.TabIndex = 3;
            this.groupBox_situation.TabStop = false;
            this.groupBox_situation.Text = "Situation Familiale";
            // 
            // button_afficher
            // 
            this.button_afficher.Location = new System.Drawing.Point(80, 119);
            this.button_afficher.Name = "button_afficher";
            this.button_afficher.Size = new System.Drawing.Size(75, 23);
            this.button_afficher.TabIndex = 4;
            this.button_afficher.Text = "Afficher";
            this.button_afficher.UseVisualStyleBackColor = true;
            this.button_afficher.Click += new System.EventHandler(this.button_afficher_Click);
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(161, 119);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(75, 23);
            this.button_quitter.TabIndex = 5;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // radioButton_homme
            // 
            this.radioButton_homme.AutoSize = true;
            this.radioButton_homme.Checked = true;
            this.radioButton_homme.Location = new System.Drawing.Point(26, 17);
            this.radioButton_homme.Name = "radioButton_homme";
            this.radioButton_homme.Size = new System.Drawing.Size(60, 17);
            this.radioButton_homme.TabIndex = 0;
            this.radioButton_homme.TabStop = true;
            this.radioButton_homme.Text = "Homme";
            this.radioButton_homme.UseVisualStyleBackColor = true;
            // 
            // radioButton_femme
            // 
            this.radioButton_femme.AutoSize = true;
            this.radioButton_femme.Location = new System.Drawing.Point(26, 40);
            this.radioButton_femme.Name = "radioButton_femme";
            this.radioButton_femme.Size = new System.Drawing.Size(59, 17);
            this.radioButton_femme.TabIndex = 1;
            this.radioButton_femme.Text = "Femme";
            this.radioButton_femme.UseVisualStyleBackColor = true;
            // 
            // radioButton_célibataire
            // 
            this.radioButton_célibataire.AutoSize = true;
            this.radioButton_célibataire.Checked = true;
            this.radioButton_célibataire.Location = new System.Drawing.Point(26, 17);
            this.radioButton_célibataire.Name = "radioButton_célibataire";
            this.radioButton_célibataire.Size = new System.Drawing.Size(76, 17);
            this.radioButton_célibataire.TabIndex = 2;
            this.radioButton_célibataire.TabStop = true;
            this.radioButton_célibataire.Text = "Célibataire";
            this.radioButton_célibataire.UseVisualStyleBackColor = true;
            // 
            // radioButton_marié
            // 
            this.radioButton_marié.AutoSize = true;
            this.radioButton_marié.Location = new System.Drawing.Point(26, 40);
            this.radioButton_marié.Name = "radioButton_marié";
            this.radioButton_marié.Size = new System.Drawing.Size(65, 17);
            this.radioButton_marié.TabIndex = 3;
            this.radioButton_marié.Text = "Marié(e)";
            this.radioButton_marié.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 156);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_afficher);
            this.Controls.Add(this.groupBox_situation);
            this.Controls.Add(this.groupBox_sexe);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bienvenue";
            this.groupBox_sexe.ResumeLayout(false);
            this.groupBox_sexe.PerformLayout();
            this.groupBox_situation.ResumeLayout(false);
            this.groupBox_situation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.GroupBox groupBox_sexe;
        private System.Windows.Forms.GroupBox groupBox_situation;
        private System.Windows.Forms.RadioButton radioButton_femme;
        private System.Windows.Forms.RadioButton radioButton_homme;
        private System.Windows.Forms.RadioButton radioButton_célibataire;
        private System.Windows.Forms.RadioButton radioButton_marié;
        private System.Windows.Forms.Button button_afficher;
        private System.Windows.Forms.Button button_quitter;
    }
}

