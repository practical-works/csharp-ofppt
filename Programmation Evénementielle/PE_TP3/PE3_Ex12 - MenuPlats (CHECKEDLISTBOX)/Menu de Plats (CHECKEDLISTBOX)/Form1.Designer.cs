namespace Menu_de_Plats__CHECKEDLISTBOX_
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
            this.checkedListBox_menu = new System.Windows.Forms.CheckedListBox();
            this.button_commander = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox_menu
            // 
            this.checkedListBox_menu.FormattingEnabled = true;
            this.checkedListBox_menu.Items.AddRange(new object[] {
            "Salade",
            "Fromage",
            "Poulet routis",
            "Poisson",
            "Dessert",
            "Café"});
            this.checkedListBox_menu.Location = new System.Drawing.Point(14, 12);
            this.checkedListBox_menu.Name = "checkedListBox_menu";
            this.checkedListBox_menu.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_menu.TabIndex = 0;
            // 
            // button_commander
            // 
            this.button_commander.Location = new System.Drawing.Point(14, 112);
            this.button_commander.Name = "button_commander";
            this.button_commander.Size = new System.Drawing.Size(120, 23);
            this.button_commander.TabIndex = 1;
            this.button_commander.Text = "Commander";
            this.button_commander.UseVisualStyleBackColor = true;
            this.button_commander.Click += new System.EventHandler(this.button_commander_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(148, 147);
            this.Controls.Add(this.button_commander);
            this.Controls.Add(this.checkedListBox_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Plats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_menu;
        private System.Windows.Forms.Button button_commander;
    }
}

