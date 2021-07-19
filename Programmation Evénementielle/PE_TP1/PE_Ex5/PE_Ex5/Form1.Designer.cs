namespace PE_Ex5
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
            this.button_default = new System.Windows.Forms.Button();
            this.button_green = new System.Windows.Forms.Button();
            this.button_blue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_default
            // 
            this.button_default.Location = new System.Drawing.Point(67, 21);
            this.button_default.Name = "button_default";
            this.button_default.Size = new System.Drawing.Size(158, 44);
            this.button_default.TabIndex = 0;
            this.button_default.Text = "Couleur par défaut";
            this.button_default.UseVisualStyleBackColor = true;
            this.button_default.Click += new System.EventHandler(this.button_default_Click);
            // 
            // button_green
            // 
            this.button_green.Location = new System.Drawing.Point(67, 91);
            this.button_green.Name = "button_green";
            this.button_green.Size = new System.Drawing.Size(158, 44);
            this.button_green.TabIndex = 1;
            this.button_green.Text = "Vert";
            this.button_green.UseVisualStyleBackColor = true;
            this.button_green.Click += new System.EventHandler(this.button_green_Click);
            // 
            // button_blue
            // 
            this.button_blue.Location = new System.Drawing.Point(67, 162);
            this.button_blue.Name = "button_blue";
            this.button_blue.Size = new System.Drawing.Size(158, 44);
            this.button_blue.TabIndex = 2;
            this.button_blue.Text = "Bleu";
            this.button_blue.UseVisualStyleBackColor = true;
            this.button_blue.Click += new System.EventHandler(this.button_blue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 240);
            this.Controls.Add(this.button_blue);
            this.Controls.Add(this.button_green);
            this.Controls.Add(this.button_default);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_default;
        private System.Windows.Forms.Button button_green;
        private System.Windows.Forms.Button button_blue;
    }
}

