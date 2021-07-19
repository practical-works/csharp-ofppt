namespace PE8_GestionTV
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajoutDeProgrammesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emissionsParDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutDeProgrammesToolStripMenuItem,
            this.consultationsToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajoutDeProgrammesToolStripMenuItem
            // 
            this.ajoutDeProgrammesToolStripMenuItem.Image = global::PE8_GestionTV.Properties.Resources.add;
            this.ajoutDeProgrammesToolStripMenuItem.Name = "ajoutDeProgrammesToolStripMenuItem";
            this.ajoutDeProgrammesToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.ajoutDeProgrammesToolStripMenuItem.Text = "Ajout de programmes";
            this.ajoutDeProgrammesToolStripMenuItem.Click += new System.EventHandler(this.ajoutDeProgrammesToolStripMenuItem_Click);
            // 
            // consultationsToolStripMenuItem
            // 
            this.consultationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emissionsParDateToolStripMenuItem,
            this.statistiquesToolStripMenuItem});
            this.consultationsToolStripMenuItem.Image = global::PE8_GestionTV.Properties.Resources.viewstack;
            this.consultationsToolStripMenuItem.Name = "consultationsToolStripMenuItem";
            this.consultationsToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.consultationsToolStripMenuItem.Text = "Consultations";
            // 
            // emissionsParDateToolStripMenuItem
            // 
            this.emissionsParDateToolStripMenuItem.Image = global::PE8_GestionTV.Properties.Resources.date;
            this.emissionsParDateToolStripMenuItem.Name = "emissionsParDateToolStripMenuItem";
            this.emissionsParDateToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.emissionsParDateToolStripMenuItem.Text = "Liste des émissions par date";
            this.emissionsParDateToolStripMenuItem.Click += new System.EventHandler(this.emissionsParDateToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Image = global::PE8_GestionTV.Properties.Resources.statistics;
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.statistiquesToolStripMenuItem.Text = "Statistiques des émissions";
            this.statistiquesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = global::PE8_GestionTV.Properties.Resources.save_data;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = global::PE8_GestionTV.Properties.Resources.cancel;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 528);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des programmes de la chaîne TV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajoutDeProgrammesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emissionsParDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
    }
}

