namespace PE_Ex9
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
            this.button_vérifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.label_résultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_vérifier
            // 
            this.button_vérifier.Location = new System.Drawing.Point(129, 32);
            this.button_vérifier.Name = "button_vérifier";
            this.button_vérifier.Size = new System.Drawing.Size(75, 23);
            this.button_vérifier.TabIndex = 0;
            this.button_vérifier.Text = "Vérifier";
            this.button_vérifier.UseVisualStyleBackColor = true;
            this.button_vérifier.Click += new System.EventHandler(this.button_vérifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrez un nombre entier positif";
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(23, 34);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(100, 20);
            this.text_nombre.TabIndex = 2;
            // 
            // label_résultat
            // 
            this.label_résultat.AutoSize = true;
            this.label_résultat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_résultat.Location = new System.Drawing.Point(20, 67);
            this.label_résultat.Name = "label_résultat";
            this.label_résultat.Size = new System.Drawing.Size(149, 13);
            this.label_résultat.TabIndex = 3;
            this.label_résultat.Text = "Nombre Premier ou Non ?";
            this.label_résultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 98);
            this.Controls.Add(this.label_résultat);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_vérifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre Premier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_vérifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.Label label_résultat;
    }
}

