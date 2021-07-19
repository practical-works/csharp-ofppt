namespace PE2_Ex2
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
            this.textBox_nombre1 = new System.Windows.Forms.TextBox();
            this.textBox_nombre2 = new System.Windows.Forms.TextBox();
            this.textBox_résultat = new System.Windows.Forms.TextBox();
            this.label_signe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_division = new System.Windows.Forms.RadioButton();
            this.radioButton_multiplication = new System.Windows.Forms.RadioButton();
            this.radioButton_soustraction = new System.Windows.Forms.RadioButton();
            this.radioButton_addition = new System.Windows.Forms.RadioButton();
            this.button_calculer = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 143);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre 1\r\n\r\n\r\n\r\nNombre 2\r\n\r\n\r\n\r\n\r\n\r\nRésultat";
            // 
            // textBox_nombre1
            // 
            this.textBox_nombre1.Location = new System.Drawing.Point(76, 23);
            this.textBox_nombre1.Name = "textBox_nombre1";
            this.textBox_nombre1.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre1.TabIndex = 1;
            // 
            // textBox_nombre2
            // 
            this.textBox_nombre2.Location = new System.Drawing.Point(76, 75);
            this.textBox_nombre2.Name = "textBox_nombre2";
            this.textBox_nombre2.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre2.TabIndex = 2;
            // 
            // textBox_résultat
            // 
            this.textBox_résultat.Location = new System.Drawing.Point(76, 150);
            this.textBox_résultat.Name = "textBox_résultat";
            this.textBox_résultat.ReadOnly = true;
            this.textBox_résultat.Size = new System.Drawing.Size(100, 20);
            this.textBox_résultat.TabIndex = 3;
            // 
            // label_signe
            // 
            this.label_signe.AutoSize = true;
            this.label_signe.Location = new System.Drawing.Point(118, 51);
            this.label_signe.Name = "label_signe";
            this.label_signe.Size = new System.Drawing.Size(0, 13);
            this.label_signe.TabIndex = 4;
            this.label_signe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_division);
            this.groupBox1.Controls.Add(this.radioButton_multiplication);
            this.groupBox1.Controls.Add(this.radioButton_soustraction);
            this.groupBox1.Controls.Add(this.radioButton_addition);
            this.groupBox1.Location = new System.Drawing.Point(202, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opérations";
            // 
            // radioButton_division
            // 
            this.radioButton_division.AutoSize = true;
            this.radioButton_division.Location = new System.Drawing.Point(22, 102);
            this.radioButton_division.Name = "radioButton_division";
            this.radioButton_division.Size = new System.Drawing.Size(61, 17);
            this.radioButton_division.TabIndex = 3;
            this.radioButton_division.TabStop = true;
            this.radioButton_division.Text = "Division";
            this.radioButton_division.UseVisualStyleBackColor = true;
            // 
            // radioButton_multiplication
            // 
            this.radioButton_multiplication.AutoSize = true;
            this.radioButton_multiplication.Location = new System.Drawing.Point(22, 77);
            this.radioButton_multiplication.Name = "radioButton_multiplication";
            this.radioButton_multiplication.Size = new System.Drawing.Size(86, 17);
            this.radioButton_multiplication.TabIndex = 2;
            this.radioButton_multiplication.TabStop = true;
            this.radioButton_multiplication.Text = "Multiplication";
            this.radioButton_multiplication.UseVisualStyleBackColor = true;
            // 
            // radioButton_soustraction
            // 
            this.radioButton_soustraction.AutoSize = true;
            this.radioButton_soustraction.Location = new System.Drawing.Point(22, 52);
            this.radioButton_soustraction.Name = "radioButton_soustraction";
            this.radioButton_soustraction.Size = new System.Drawing.Size(85, 17);
            this.radioButton_soustraction.TabIndex = 1;
            this.radioButton_soustraction.TabStop = true;
            this.radioButton_soustraction.Text = "Soustraction";
            this.radioButton_soustraction.UseVisualStyleBackColor = true;
            // 
            // radioButton_addition
            // 
            this.radioButton_addition.AutoSize = true;
            this.radioButton_addition.Checked = true;
            this.radioButton_addition.Location = new System.Drawing.Point(22, 27);
            this.radioButton_addition.Name = "radioButton_addition";
            this.radioButton_addition.Size = new System.Drawing.Size(64, 17);
            this.radioButton_addition.TabIndex = 0;
            this.radioButton_addition.TabStop = true;
            this.radioButton_addition.Text = "Addition";
            this.radioButton_addition.UseVisualStyleBackColor = true;
            // 
            // button_calculer
            // 
            this.button_calculer.Location = new System.Drawing.Point(90, 194);
            this.button_calculer.Name = "button_calculer";
            this.button_calculer.Size = new System.Drawing.Size(75, 23);
            this.button_calculer.TabIndex = 6;
            this.button_calculer.Text = "Calculer";
            this.button_calculer.UseVisualStyleBackColor = true;
            this.button_calculer.Click += new System.EventHandler(this.button_calculer_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(183, 194);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(75, 23);
            this.button_annuler.TabIndex = 7;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 237);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.button_calculer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_signe);
            this.Controls.Add(this.textBox_résultat);
            this.Controls.Add(this.textBox_nombre2);
            this.Controls.Add(this.textBox_nombre1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_calculateur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre1;
        private System.Windows.Forms.TextBox textBox_nombre2;
        private System.Windows.Forms.TextBox textBox_résultat;
        private System.Windows.Forms.Label label_signe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_division;
        private System.Windows.Forms.RadioButton radioButton_multiplication;
        private System.Windows.Forms.RadioButton radioButton_soustraction;
        private System.Windows.Forms.RadioButton radioButton_addition;
        private System.Windows.Forms.Button button_calculer;
        private System.Windows.Forms.Button button_annuler;
    }
}

