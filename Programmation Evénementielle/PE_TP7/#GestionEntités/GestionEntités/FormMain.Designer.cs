namespace GestionEntités
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip_menu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_ajouter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_modifier = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_supprimer = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_entite = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_entite = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_entite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_entite)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_menu
            // 
            this.toolStrip_menu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip_menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_ajouter,
            this.toolStripButton_modifier,
            this.toolStripButton_supprimer});
            this.toolStrip_menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip_menu.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_menu.Name = "toolStrip_menu";
            this.toolStrip_menu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip_menu.Size = new System.Drawing.Size(423, 26);
            this.toolStrip_menu.TabIndex = 0;
            this.toolStrip_menu.Text = "Menu";
            // 
            // toolStripButton_ajouter
            // 
            this.toolStripButton_ajouter.Image = global::GestionEntités.Properties.Resources.add;
            this.toolStripButton_ajouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ajouter.Name = "toolStripButton_ajouter";
            this.toolStripButton_ajouter.Size = new System.Drawing.Size(82, 23);
            this.toolStripButton_ajouter.Text = "Ajouter";
            this.toolStripButton_ajouter.Click += new System.EventHandler(this.toolStripButton_ajouter_Click);
            // 
            // toolStripButton_modifier
            // 
            this.toolStripButton_modifier.Image = global::GestionEntités.Properties.Resources.edit_button;
            this.toolStripButton_modifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_modifier.Name = "toolStripButton_modifier";
            this.toolStripButton_modifier.Size = new System.Drawing.Size(86, 23);
            this.toolStripButton_modifier.Text = "Modifier";
            this.toolStripButton_modifier.Click += new System.EventHandler(this.toolStripButton_modifier_Click);
            // 
            // toolStripButton_supprimer
            // 
            this.toolStripButton_supprimer.Image = global::GestionEntités.Properties.Resources.delete;
            this.toolStripButton_supprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_supprimer.Name = "toolStripButton_supprimer";
            this.toolStripButton_supprimer.Size = new System.Drawing.Size(103, 23);
            this.toolStripButton_supprimer.Text = "Supprimer";
            this.toolStripButton_supprimer.Click += new System.EventHandler(this.toolStripButton_supprimer_Click);
            // 
            // dataGridView_entite
            // 
            this.dataGridView_entite.AllowUserToAddRows = false;
            this.dataGridView_entite.AllowUserToDeleteRows = false;
            this.dataGridView_entite.AllowUserToResizeColumns = false;
            this.dataGridView_entite.AllowUserToResizeRows = false;
            this.dataGridView_entite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_entite.AutoGenerateColumns = false;
            this.dataGridView_entite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_entite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_entite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView_entite.DataSource = this.bindingSource_entite;
            this.dataGridView_entite.Location = new System.Drawing.Point(22, 39);
            this.dataGridView_entite.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_entite.Name = "dataGridView_entite";
            this.dataGridView_entite.ReadOnly = true;
            this.dataGridView_entite.RowHeadersVisible = false;
            this.dataGridView_entite.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_entite.Size = new System.Drawing.Size(378, 226);
            this.dataGridView_entite.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn1.FillWeight = 48.99439F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Identifiant";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.FillWeight = 100.763F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Texte représentant le nom";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valeur";
            this.dataGridViewTextBoxColumn3.FillWeight = 50.93787F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Valeur";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.ToolTipText = "Valeur numérique associée";
            // 
            // bindingSource_entite
            // 
            this.bindingSource_entite.DataSource = typeof(GestionEntités.Entité);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 282);
            this.Controls.Add(this.dataGridView_entite);
            this.Controls.Add(this.toolStrip_menu);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Entités";
            this.toolStrip_menu.ResumeLayout(false);
            this.toolStrip_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_entite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_entite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_menu;
        private System.Windows.Forms.ToolStripButton toolStripButton_ajouter;
        private System.Windows.Forms.ToolStripButton toolStripButton_modifier;
        private System.Windows.Forms.ToolStripButton toolStripButton_supprimer;
        private System.Windows.Forms.BindingSource bindingSource_entite;
        private System.Windows.Forms.DataGridView dataGridView_entite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

