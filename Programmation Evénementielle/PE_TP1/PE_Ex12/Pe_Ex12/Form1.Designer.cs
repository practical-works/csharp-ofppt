namespace Pe_Ex12
{
    partial class Form_table
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_table = new System.Windows.Forms.RichTextBox();
            this.button_générer = new System.Windows.Forms.Button();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez un nombre :";
            // 
            // richTextBox_table
            // 
            this.richTextBox_table.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_table.Location = new System.Drawing.Point(24, 60);
            this.richTextBox_table.Name = "richTextBox_table";
            this.richTextBox_table.ReadOnly = true;
            this.richTextBox_table.Size = new System.Drawing.Size(181, 215);
            this.richTextBox_table.TabIndex = 1;
            this.richTextBox_table.Text = "";
            // 
            // button_générer
            // 
            this.button_générer.Location = new System.Drawing.Point(130, 30);
            this.button_générer.Name = "button_générer";
            this.button_générer.Size = new System.Drawing.Size(75, 23);
            this.button_générer.TabIndex = 3;
            this.button_générer.Text = "Générer";
            this.button_générer.UseVisualStyleBackColor = true;
            this.button_générer.Click += new System.EventHandler(this.button_générer_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(24, 30);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 26);
            this.textBox_nombre.TabIndex = 4;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            // 
            // Form_table
            // 
            this.AcceptButton = this.button_générer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 289);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.button_générer);
            this.Controls.Add(this.richTextBox_table);
            this.Controls.Add(this.label1);
            this.Name = "Form_table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table de Multiplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_table;
        private System.Windows.Forms.Button button_générer;
        private System.Windows.Forms.TextBox textBox_nombre;
    }
}

