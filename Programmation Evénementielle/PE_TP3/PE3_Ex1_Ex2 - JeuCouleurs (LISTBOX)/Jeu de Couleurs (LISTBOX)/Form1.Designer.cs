namespace Jeu_de_Couleurs__LISTBOX_
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
            this.listBox_couleurs = new System.Windows.Forms.ListBox();
            this.button_colorier = new System.Windows.Forms.Button();
            this.label_couleur = new System.Windows.Forms.Label();
            this.checkBox_buttonActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox_couleurs
            // 
            this.listBox_couleurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_couleurs.FormattingEnabled = true;
            this.listBox_couleurs.Items.AddRange(new object[] {
            "Bleu",
            "Jaune",
            "Rouge",
            "Vert"});
            this.listBox_couleurs.Location = new System.Drawing.Point(30, 26);
            this.listBox_couleurs.Name = "listBox_couleurs";
            this.listBox_couleurs.Size = new System.Drawing.Size(250, 69);
            this.listBox_couleurs.TabIndex = 1;
            this.listBox_couleurs.SelectedIndexChanged += new System.EventHandler(this.listBox_couleurs_SelectedIndexChanged);
            // 
            // button_colorier
            // 
            this.button_colorier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_colorier.BackColor = System.Drawing.Color.LightGray;
            this.button_colorier.Location = new System.Drawing.Point(75, 114);
            this.button_colorier.Name = "button_colorier";
            this.button_colorier.Size = new System.Drawing.Size(161, 41);
            this.button_colorier.TabIndex = 0;
            this.button_colorier.Text = "Colorier";
            this.button_colorier.UseVisualStyleBackColor = false;
            this.button_colorier.Click += new System.EventHandler(this.button_colorier_Click);
            // 
            // label_couleur
            // 
            this.label_couleur.AutoSize = true;
            this.label_couleur.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_couleur.Location = new System.Drawing.Point(310, 0);
            this.label_couleur.Name = "label_couleur";
            this.label_couleur.Size = new System.Drawing.Size(0, 13);
            this.label_couleur.TabIndex = 2;
            this.label_couleur.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // checkBox_buttonActive
            // 
            this.checkBox_buttonActive.AutoSize = true;
            this.checkBox_buttonActive.Checked = true;
            this.checkBox_buttonActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_buttonActive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBox_buttonActive.Location = new System.Drawing.Point(0, 164);
            this.checkBox_buttonActive.Name = "checkBox_buttonActive";
            this.checkBox_buttonActive.Size = new System.Drawing.Size(310, 17);
            this.checkBox_buttonActive.TabIndex = 3;
            this.checkBox_buttonActive.Text = "Button";
            this.checkBox_buttonActive.UseVisualStyleBackColor = true;
            this.checkBox_buttonActive.CheckedChanged += new System.EventHandler(this.checkBox_buttonActive_CheckedChanged);
            // 
            // Form_main
            // 
            this.AcceptButton = this.button_colorier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 181);
            this.Controls.Add(this.checkBox_buttonActive);
            this.Controls.Add(this.label_couleur);
            this.Controls.Add(this.listBox_couleurs);
            this.Controls.Add(this.button_colorier);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu de Couleurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_couleurs;
        private System.Windows.Forms.Button button_colorier;
        private System.Windows.Forms.Label label_couleur;
        private System.Windows.Forms.CheckBox checkBox_buttonActive;

    }
}

