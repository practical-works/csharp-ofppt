namespace Menu_Commande
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
            this.listBoxe_menu = new System.Windows.Forms.ListBox();
            this.button_commander = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxe_menu
            // 
            this.listBoxe_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxe_menu.FormattingEnabled = true;
            this.listBoxe_menu.Items.AddRange(new object[] {
            "Salde",
            "Fromage",
            "Poulet routis",
            "Poisson",
            "Dessert",
            "Café",
            "Thé"});
            this.listBoxe_menu.Location = new System.Drawing.Point(10, 11);
            this.listBoxe_menu.Name = "listBoxe_menu";
            this.listBoxe_menu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxe_menu.Size = new System.Drawing.Size(120, 95);
            this.listBoxe_menu.TabIndex = 0;
            // 
            // button_commander
            // 
            this.button_commander.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_commander.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_commander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_commander.Location = new System.Drawing.Point(10, 112);
            this.button_commander.Name = "button_commander";
            this.button_commander.Size = new System.Drawing.Size(120, 23);
            this.button_commander.TabIndex = 1;
            this.button_commander.Text = "Commander";
            this.button_commander.UseVisualStyleBackColor = false;
            this.button_commander.Click += new System.EventHandler(this.button_commander_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(141, 146);
            this.Controls.Add(this.button_commander);
            this.Controls.Add(this.listBoxe_menu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxe_menu;
        private System.Windows.Forms.Button button_commander;
    }
}

