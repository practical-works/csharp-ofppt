namespace PE2_Ex1
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_default = new System.Windows.Forms.RadioButton();
            this.radioButton_blue = new System.Windows.Forms.RadioButton();
            this.radioButton_red = new System.Windows.Forms.RadioButton();
            this.radioButton_green = new System.Windows.Forms.RadioButton();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_ColorReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez choisir la couleur du formulaire";
            // 
            // radioButton_default
            // 
            this.radioButton_default.AutoSize = true;
            this.radioButton_default.Location = new System.Drawing.Point(88, 67);
            this.radioButton_default.Name = "radioButton_default";
            this.radioButton_default.Size = new System.Drawing.Size(116, 17);
            this.radioButton_default.TabIndex = 1;
            this.radioButton_default.TabStop = true;
            this.radioButton_default.Text = "Couleur par défaut";
            this.radioButton_default.UseVisualStyleBackColor = true;
            // 
            // radioButton_blue
            // 
            this.radioButton_blue.AutoSize = true;
            this.radioButton_blue.Location = new System.Drawing.Point(88, 98);
            this.radioButton_blue.Name = "radioButton_blue";
            this.radioButton_blue.Size = new System.Drawing.Size(45, 17);
            this.radioButton_blue.TabIndex = 2;
            this.radioButton_blue.TabStop = true;
            this.radioButton_blue.Text = "Blue";
            this.radioButton_blue.UseVisualStyleBackColor = true;
            // 
            // radioButton_red
            // 
            this.radioButton_red.AutoSize = true;
            this.radioButton_red.Location = new System.Drawing.Point(88, 129);
            this.radioButton_red.Name = "radioButton_red";
            this.radioButton_red.Size = new System.Drawing.Size(62, 17);
            this.radioButton_red.TabIndex = 3;
            this.radioButton_red.TabStop = true;
            this.radioButton_red.Text = "Reouge";
            this.radioButton_red.UseVisualStyleBackColor = true;
            // 
            // radioButton_green
            // 
            this.radioButton_green.AutoSize = true;
            this.radioButton_green.Location = new System.Drawing.Point(88, 160);
            this.radioButton_green.Name = "radioButton_green";
            this.radioButton_green.Size = new System.Drawing.Size(45, 17);
            this.radioButton_green.TabIndex = 4;
            this.radioButton_green.TabStop = true;
            this.radioButton_green.Text = "Vert";
            this.radioButton_green.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(62, 203);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_ColorReset
            // 
            this.button_ColorReset.Location = new System.Drawing.Point(156, 203);
            this.button_ColorReset.Name = "button_ColorReset";
            this.button_ColorReset.Size = new System.Drawing.Size(75, 23);
            this.button_ColorReset.TabIndex = 6;
            this.button_ColorReset.Text = "Annuler";
            this.button_ColorReset.UseVisualStyleBackColor = true;
            this.button_ColorReset.Click += new System.EventHandler(this.button_ColorReset_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 259);
            this.Controls.Add(this.button_ColorReset);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.radioButton_green);
            this.Controls.Add(this.radioButton_red);
            this.Controls.Add(this.radioButton_blue);
            this.Controls.Add(this.radioButton_default);
            this.Controls.Add(this.label1);
            this.Name = "Form_main";
            this.Text = "Jeu de couleurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_default;
        private System.Windows.Forms.RadioButton radioButton_blue;
        private System.Windows.Forms.RadioButton radioButton_red;
        private System.Windows.Forms.RadioButton radioButton_green;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_ColorReset;
    }
}

