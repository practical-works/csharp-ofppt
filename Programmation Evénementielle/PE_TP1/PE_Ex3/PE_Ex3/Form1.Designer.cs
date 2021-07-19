namespace PE_Ex3
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
            this.button_vert = new System.Windows.Forms.Button();
            this.button_bleu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_vert
            // 
            this.button_vert.Location = new System.Drawing.Point(12, 12);
            this.button_vert.Name = "button_vert";
            this.button_vert.Size = new System.Drawing.Size(184, 52);
            this.button_vert.TabIndex = 0;
            this.button_vert.Text = "button1";
            this.button_vert.UseVisualStyleBackColor = true;
            this.button_vert.Click += new System.EventHandler(this.button_vert_Click);
            // 
            // button_bleu
            // 
            this.button_bleu.Location = new System.Drawing.Point(12, 160);
            this.button_bleu.Name = "button_bleu";
            this.button_bleu.Size = new System.Drawing.Size(184, 52);
            this.button_bleu.TabIndex = 1;
            this.button_bleu.Text = "button2";
            this.button_bleu.UseVisualStyleBackColor = true;
            this.button_bleu.Click += new System.EventHandler(this.button_bleu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(208, 224);
            this.Controls.Add(this.button_bleu);
            this.Controls.Add(this.button_vert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_vert;
        private System.Windows.Forms.Button button_bleu;
    }
}

