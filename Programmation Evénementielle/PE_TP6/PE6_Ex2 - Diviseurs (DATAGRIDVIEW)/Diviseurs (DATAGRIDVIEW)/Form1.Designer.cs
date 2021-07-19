namespace Diviseurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_afficherDiviseurs = new System.Windows.Forms.Button();
            this.numericUpDown_nombre = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_effacerDiviseurs = new System.Windows.Forms.Button();
            this.textBox_nbrDiviseurs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_diviseurs = new System.Windows.Forms.DataGridView();
            this.Colonne_Diviseurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nombre)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_diviseurs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_afficherDiviseurs);
            this.panel1.Controls.Add(this.numericUpDown_nombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 79);
            this.panel1.TabIndex = 0;
            // 
            // button_afficherDiviseurs
            // 
            this.button_afficherDiviseurs.Location = new System.Drawing.Point(19, 40);
            this.button_afficherDiviseurs.Name = "button_afficherDiviseurs";
            this.button_afficherDiviseurs.Size = new System.Drawing.Size(174, 23);
            this.button_afficherDiviseurs.TabIndex = 2;
            this.button_afficherDiviseurs.Text = "Afficher la liste des diviseurs";
            this.button_afficherDiviseurs.UseVisualStyleBackColor = true;
            this.button_afficherDiviseurs.Click += new System.EventHandler(this.button_afficherDiviseurs_Click);
            // 
            // numericUpDown_nombre
            // 
            this.numericUpDown_nombre.Location = new System.Drawing.Point(75, 13);
            this.numericUpDown_nombre.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_nombre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nombre.Name = "numericUpDown_nombre";
            this.numericUpDown_nombre.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_nombre.TabIndex = 1;
            this.numericUpDown_nombre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_effacerDiviseurs);
            this.panel2.Controls.Add(this.textBox_nbrDiviseurs);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView_diviseurs);
            this.panel2.Location = new System.Drawing.Point(14, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 192);
            this.panel2.TabIndex = 1;
            // 
            // button_effacerDiviseurs
            // 
            this.button_effacerDiviseurs.Location = new System.Drawing.Point(19, 156);
            this.button_effacerDiviseurs.Name = "button_effacerDiviseurs";
            this.button_effacerDiviseurs.Size = new System.Drawing.Size(176, 23);
            this.button_effacerDiviseurs.TabIndex = 3;
            this.button_effacerDiviseurs.Text = "Effacer la liste";
            this.button_effacerDiviseurs.UseVisualStyleBackColor = true;
            this.button_effacerDiviseurs.Click += new System.EventHandler(this.button_effacerDiviseurs_Click);
            // 
            // textBox_nbrDiviseurs
            // 
            this.textBox_nbrDiviseurs.Location = new System.Drawing.Point(141, 130);
            this.textBox_nbrDiviseurs.Name = "textBox_nbrDiviseurs";
            this.textBox_nbrDiviseurs.ReadOnly = true;
            this.textBox_nbrDiviseurs.Size = new System.Drawing.Size(54, 20);
            this.textBox_nbrDiviseurs.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de diviseurs :";
            // 
            // dataGridView_diviseurs
            // 
            this.dataGridView_diviseurs.AllowUserToAddRows = false;
            this.dataGridView_diviseurs.AllowUserToDeleteRows = false;
            this.dataGridView_diviseurs.AllowUserToResizeColumns = false;
            this.dataGridView_diviseurs.AllowUserToResizeRows = false;
            this.dataGridView_diviseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_diviseurs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_diviseurs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_diviseurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_diviseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_diviseurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colonne_Diviseurs});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_diviseurs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_diviseurs.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView_diviseurs.Location = new System.Drawing.Point(19, 12);
            this.dataGridView_diviseurs.Name = "dataGridView_diviseurs";
            this.dataGridView_diviseurs.ReadOnly = true;
            this.dataGridView_diviseurs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_diviseurs.RowHeadersWidth = 20;
            this.dataGridView_diviseurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_diviseurs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_diviseurs.Size = new System.Drawing.Size(176, 108);
            this.dataGridView_diviseurs.TabIndex = 0;
            // 
            // Colonne_Diviseurs
            // 
            this.Colonne_Diviseurs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Colonne_Diviseurs.HeaderText = "Diviseurs";
            this.Colonne_Diviseurs.Name = "Colonne_Diviseurs";
            this.Colonne_Diviseurs.ReadOnly = true;
            this.Colonne_Diviseurs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Colonne_Diviseurs.Width = 155;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 298);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diviseurs d\'un nombre";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nombre)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_diviseurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_afficherDiviseurs;
        private System.Windows.Forms.NumericUpDown numericUpDown_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_effacerDiviseurs;
        private System.Windows.Forms.TextBox textBox_nbrDiviseurs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_diviseurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonne_Diviseurs;
    }
}

