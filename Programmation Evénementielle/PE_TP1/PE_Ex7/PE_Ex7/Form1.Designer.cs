namespace PE_Ex7
{
    partial class Main_Form
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
            this.label_prix = new System.Windows.Forms.Label();
            this.label_quant = new System.Windows.Forms.Label();
            this.label_tva = new System.Windows.Forms.Label();
            this.label_prixTotal = new System.Windows.Forms.Label();
            this.text_prix = new System.Windows.Forms.TextBox();
            this.text_quantite = new System.Windows.Forms.TextBox();
            this.text_tva = new System.Windows.Forms.TextBox();
            this.button_calculer = new System.Windows.Forms.Button();
            this.button_vider = new System.Windows.Forms.Button();
            this.button_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_prix
            // 
            this.label_prix.AutoSize = true;
            this.label_prix.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prix.Location = new System.Drawing.Point(16, 17);
            this.label_prix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(148, 25);
            this.label_prix.TabIndex = 0;
            this.label_prix.Text = "Prix Unitaire (DH)";
            // 
            // label_quant
            // 
            this.label_quant.AutoSize = true;
            this.label_quant.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quant.Location = new System.Drawing.Point(85, 48);
            this.label_quant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_quant.Name = "label_quant";
            this.label_quant.Size = new System.Drawing.Size(79, 25);
            this.label_quant.TabIndex = 1;
            this.label_quant.Text = "Quantité";
            // 
            // label_tva
            // 
            this.label_tva.AutoSize = true;
            this.label_tva.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tva.Location = new System.Drawing.Point(85, 78);
            this.label_tva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tva.Name = "label_tva";
            this.label_tva.Size = new System.Drawing.Size(81, 25);
            this.label_tva.TabIndex = 2;
            this.label_tva.Text = "TVA (%)";
            // 
            // label_prixTotal
            // 
            this.label_prixTotal.AutoSize = true;
            this.label_prixTotal.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prixTotal.Location = new System.Drawing.Point(16, 125);
            this.label_prixTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_prixTotal.Name = "label_prixTotal";
            this.label_prixTotal.Size = new System.Drawing.Size(247, 50);
            this.label_prixTotal.TabIndex = 3;
            this.label_prixTotal.Text = "Le prix total à payer est 0 DH.\r\n\r\n";
            // 
            // text_prix
            // 
            this.text_prix.Location = new System.Drawing.Point(167, 13);
            this.text_prix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_prix.Name = "text_prix";
            this.text_prix.Size = new System.Drawing.Size(58, 29);
            this.text_prix.TabIndex = 4;
            // 
            // text_quantite
            // 
            this.text_quantite.Location = new System.Drawing.Point(167, 44);
            this.text_quantite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_quantite.Name = "text_quantite";
            this.text_quantite.Size = new System.Drawing.Size(58, 29);
            this.text_quantite.TabIndex = 5;
            // 
            // text_tva
            // 
            this.text_tva.Location = new System.Drawing.Point(167, 74);
            this.text_tva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_tva.Name = "text_tva";
            this.text_tva.Size = new System.Drawing.Size(58, 29);
            this.text_tva.TabIndex = 6;
            // 
            // button_calculer
            // 
            this.button_calculer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calculer.Location = new System.Drawing.Point(308, 13);
            this.button_calculer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_calculer.Name = "button_calculer";
            this.button_calculer.Size = new System.Drawing.Size(144, 64);
            this.button_calculer.TabIndex = 7;
            this.button_calculer.Text = "Calculer";
            this.button_calculer.UseVisualStyleBackColor = true;
            this.button_calculer.Click += new System.EventHandler(this.button_calculer_Click);
            // 
            // button_vider
            // 
            this.button_vider.Location = new System.Drawing.Point(308, 84);
            this.button_vider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(144, 29);
            this.button_vider.TabIndex = 8;
            this.button_vider.Text = "Vider";
            this.button_vider.UseVisualStyleBackColor = true;
            this.button_vider.Click += new System.EventHandler(this.button_vider_Click);
            // 
            // button_fermer
            // 
            this.button_fermer.Location = new System.Drawing.Point(308, 123);
            this.button_fermer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(144, 29);
            this.button_fermer.TabIndex = 9;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.UseVisualStyleBackColor = true;
            this.button_fermer.Click += new System.EventHandler(this.button_fermer_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 166);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.button_vider);
            this.Controls.Add(this.button_calculer);
            this.Controls.Add(this.text_tva);
            this.Controls.Add(this.text_quantite);
            this.Controls.Add(this.text_prix);
            this.Controls.Add(this.label_prixTotal);
            this.Controls.Add(this.label_tva);
            this.Controls.Add(this.label_quant);
            this.Controls.Add(this.label_prix);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Achat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_prix;
        private System.Windows.Forms.Label label_quant;
        private System.Windows.Forms.Label label_tva;
        private System.Windows.Forms.Label label_prixTotal;
        private System.Windows.Forms.TextBox text_prix;
        private System.Windows.Forms.TextBox text_quantite;
        private System.Windows.Forms.TextBox text_tva;
        private System.Windows.Forms.Button button_calculer;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.Button button_fermer;
    }
}

