namespace PE_Ex14
{
    partial class Form_Principale
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
            this.richTextBox_original = new System.Windows.Forms.RichTextBox();
            this.richTextBox_inversé = new System.Windows.Forms.RichTextBox();
            this.button_inverser = new System.Windows.Forms.Button();
            this.button_sans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_original
            // 
            this.richTextBox_original.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox_original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_original.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_original.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox_original.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_original.Name = "richTextBox_original";
            this.richTextBox_original.Size = new System.Drawing.Size(261, 256);
            this.richTextBox_original.TabIndex = 0;
            this.richTextBox_original.Text = "";
            this.richTextBox_original.TextChanged += new System.EventHandler(this.richTextBox_original_TextChanged);
            // 
            // richTextBox_inversé
            // 
            this.richTextBox_inversé.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox_inversé.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_inversé.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_inversé.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox_inversé.Location = new System.Drawing.Point(368, 12);
            this.richTextBox_inversé.Name = "richTextBox_inversé";
            this.richTextBox_inversé.Size = new System.Drawing.Size(261, 256);
            this.richTextBox_inversé.TabIndex = 1;
            this.richTextBox_inversé.Text = "";
            // 
            // button_inverser
            // 
            this.button_inverser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_inverser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_inverser.Font = new System.Drawing.Font("Wingdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button_inverser.ForeColor = System.Drawing.Color.White;
            this.button_inverser.Location = new System.Drawing.Point(279, 12);
            this.button_inverser.Name = "button_inverser";
            this.button_inverser.Size = new System.Drawing.Size(83, 228);
            this.button_inverser.TabIndex = 2;
            this.button_inverser.Text = "à";
            this.button_inverser.UseVisualStyleBackColor = false;
            this.button_inverser.Click += new System.EventHandler(this.button_inverser_Click);
            // 
            // button_sans
            // 
            this.button_sans.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_sans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sans.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_sans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_sans.Location = new System.Drawing.Point(279, 241);
            this.button_sans.Name = "button_sans";
            this.button_sans.Size = new System.Drawing.Size(83, 27);
            this.button_sans.TabIndex = 3;
            this.button_sans.Text = "Sans Button";
            this.button_sans.UseVisualStyleBackColor = false;
            this.button_sans.Click += new System.EventHandler(this.button_sans_Click);
            // 
            // Form_Principale
            // 
            this.AcceptButton = this.button_inverser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.button_sans;
            this.ClientSize = new System.Drawing.Size(641, 283);
            this.Controls.Add(this.button_sans);
            this.Controls.Add(this.button_inverser);
            this.Controls.Add(this.richTextBox_inversé);
            this.Controls.Add(this.richTextBox_original);
            this.Name = "Form_Principale";
            this.Text = "Inverseur de Texte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_original;
        private System.Windows.Forms.RichTextBox richTextBox_inversé;
        private System.Windows.Forms.Button button_inverser;
        private System.Windows.Forms.Button button_sans;
    }
}

