namespace Jeu_de_Couleurs__COMBOBOX_
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
            this.button_colorier = new System.Windows.Forms.Button();
            this.comboBox_couleur = new System.Windows.Forms.ComboBox();
            this.checkBox_buttonEnable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_colorier
            // 
            this.button_colorier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_colorier.BackColor = System.Drawing.Color.Gray;
            this.button_colorier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_colorier.ForeColor = System.Drawing.Color.White;
            this.button_colorier.Location = new System.Drawing.Point(112, 88);
            this.button_colorier.Name = "button_colorier";
            this.button_colorier.Size = new System.Drawing.Size(65, 34);
            this.button_colorier.TabIndex = 0;
            this.button_colorier.Text = "OK";
            this.button_colorier.UseVisualStyleBackColor = false;
            this.button_colorier.Click += new System.EventHandler(this.button_colorier_Click);
            // 
            // comboBox_couleur
            // 
            this.comboBox_couleur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_couleur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_couleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_couleur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_couleur.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_couleur.ForeColor = System.Drawing.Color.White;
            this.comboBox_couleur.FormattingEnabled = true;
            this.comboBox_couleur.Items.AddRange(new object[] {
            "Bleu",
            "Rouge",
            "Vert",
            "Jaune"});
            this.comboBox_couleur.Location = new System.Drawing.Point(62, 51);
            this.comboBox_couleur.Name = "comboBox_couleur";
            this.comboBox_couleur.Size = new System.Drawing.Size(164, 22);
            this.comboBox_couleur.TabIndex = 1;
            this.comboBox_couleur.SelectedIndexChanged += new System.EventHandler(this.comboBox_couleur_SelectedIndexChanged);
            // 
            // checkBox_buttonEnable
            // 
            this.checkBox_buttonEnable.AutoSize = true;
            this.checkBox_buttonEnable.Checked = true;
            this.checkBox_buttonEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_buttonEnable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBox_buttonEnable.ForeColor = System.Drawing.Color.White;
            this.checkBox_buttonEnable.Location = new System.Drawing.Point(0, 155);
            this.checkBox_buttonEnable.Name = "checkBox_buttonEnable";
            this.checkBox_buttonEnable.Size = new System.Drawing.Size(288, 17);
            this.checkBox_buttonEnable.TabIndex = 2;
            this.checkBox_buttonEnable.Text = "Button";
            this.checkBox_buttonEnable.UseVisualStyleBackColor = true;
            this.checkBox_buttonEnable.CheckedChanged += new System.EventHandler(this.checkBox_buttonEnable_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(288, 172);
            this.Controls.Add(this.checkBox_buttonEnable);
            this.Controls.Add(this.comboBox_couleur);
            this.Controls.Add(this.button_colorier);
            this.MinimumSize = new System.Drawing.Size(296, 199);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu de Couleurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_colorier;
        private System.Windows.Forms.ComboBox comboBox_couleur;
        private System.Windows.Forms.CheckBox checkBox_buttonEnable;
    }
}

