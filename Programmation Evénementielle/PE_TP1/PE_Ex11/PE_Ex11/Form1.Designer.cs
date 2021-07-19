namespace PE_Ex11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_resultat = new System.Windows.Forms.Label();
            this.button_calculer = new System.Windows.Forms.Button();
            this.textBox_nombre1 = new System.Windows.Forms.TextBox();
            this.textBox_operation = new System.Windows.Forms.TextBox();
            this.textBox_nombre2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Premier Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opération";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deuxième Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Résultat";
            // 
            // label_resultat
            // 
            this.label_resultat.AutoSize = true;
            this.label_resultat.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_resultat.Location = new System.Drawing.Point(86, 109);
            this.label_resultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_resultat.Name = "label_resultat";
            this.label_resultat.Size = new System.Drawing.Size(49, 20);
            this.label_resultat.TabIndex = 4;
            this.label_resultat.Text = "Aucun";
            // 
            // button_calculer
            // 
            this.button_calculer.Enabled = false;
            this.button_calculer.Location = new System.Drawing.Point(257, 109);
            this.button_calculer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_calculer.Name = "button_calculer";
            this.button_calculer.Size = new System.Drawing.Size(75, 33);
            this.button_calculer.TabIndex = 5;
            this.button_calculer.Text = "Calculer";
            this.button_calculer.UseVisualStyleBackColor = true;
            this.button_calculer.Click += new System.EventHandler(this.button_calculer_Click);
            // 
            // textBox_nombre1
            // 
            this.textBox_nombre1.Location = new System.Drawing.Point(162, 9);
            this.textBox_nombre1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_nombre1.Name = "textBox_nombre1";
            this.textBox_nombre1.Size = new System.Drawing.Size(62, 27);
            this.textBox_nombre1.TabIndex = 6;
            this.textBox_nombre1.TextChanged += new System.EventHandler(this.textBox_nombre1_TextChanged);
            // 
            // textBox_operation
            // 
            this.textBox_operation.Location = new System.Drawing.Point(162, 38);
            this.textBox_operation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_operation.Name = "textBox_operation";
            this.textBox_operation.Size = new System.Drawing.Size(38, 27);
            this.textBox_operation.TabIndex = 7;
            this.textBox_operation.TextChanged += new System.EventHandler(this.textBox_operation_TextChanged);
            // 
            // textBox_nombre2
            // 
            this.textBox_nombre2.Location = new System.Drawing.Point(162, 70);
            this.textBox_nombre2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_nombre2.Name = "textBox_nombre2";
            this.textBox_nombre2.Size = new System.Drawing.Size(62, 27);
            this.textBox_nombre2.TabIndex = 8;
            this.textBox_nombre2.TextChanged += new System.EventHandler(this.textBox_nombre2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 84);
            this.label6.TabIndex = 9;
            this.label6.Text = "Somme +\r\nDiférence -\r\nProduit *\r\nQuotient /\r\nModulo %   \r\nPuissance ^ ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_calculer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 156);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_nombre2);
            this.Controls.Add(this.textBox_operation);
            this.Controls.Add(this.textBox_nombre1);
            this.Controls.Add(this.button_calculer);
            this.Controls.Add(this.label_resultat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 250);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculatrice";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_resultat;
        private System.Windows.Forms.Button button_calculer;
        private System.Windows.Forms.TextBox textBox_nombre1;
        private System.Windows.Forms.TextBox textBox_operation;
        private System.Windows.Forms.TextBox textBox_nombre2;
        private System.Windows.Forms.Label label6;
    }
}

