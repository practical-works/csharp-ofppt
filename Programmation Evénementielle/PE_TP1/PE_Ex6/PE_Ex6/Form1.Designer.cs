namespace PE_Ex6
{
    partial class Form_Somme
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
            this.text_num1 = new System.Windows.Forms.TextBox();
            this.text_num2 = new System.Windows.Forms.TextBox();
            this.text_sum = new System.Windows.Forms.TextBox();
            this.button_calcul = new System.Windows.Forms.Button();
            this.button_undo = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Somme";
            // 
            // text_num1
            // 
            this.text_num1.Location = new System.Drawing.Point(93, 51);
            this.text_num1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_num1.Name = "text_num1";
            this.text_num1.Size = new System.Drawing.Size(60, 29);
            this.text_num1.TabIndex = 3;
            this.text_num1.TextChanged += new System.EventHandler(this.text_num1_TextChanged);
            // 
            // text_num2
            // 
            this.text_num2.Location = new System.Drawing.Point(93, 85);
            this.text_num2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_num2.Name = "text_num2";
            this.text_num2.Size = new System.Drawing.Size(60, 29);
            this.text_num2.TabIndex = 4;
            this.text_num2.TextChanged += new System.EventHandler(this.text_num2_TextChanged);
            // 
            // text_sum
            // 
            this.text_sum.Location = new System.Drawing.Point(244, 64);
            this.text_sum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_sum.Name = "text_sum";
            this.text_sum.ReadOnly = true;
            this.text_sum.Size = new System.Drawing.Size(56, 29);
            this.text_sum.TabIndex = 5;
            // 
            // button_calcul
            // 
            this.button_calcul.BackColor = System.Drawing.SystemColors.Control;
            this.button_calcul.Enabled = false;
            this.button_calcul.Location = new System.Drawing.Point(361, 16);
            this.button_calcul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_calcul.Name = "button_calcul";
            this.button_calcul.Size = new System.Drawing.Size(112, 41);
            this.button_calcul.TabIndex = 6;
            this.button_calcul.Text = "Calculer";
            this.button_calcul.UseVisualStyleBackColor = false;
            this.button_calcul.Click += new System.EventHandler(this.button_calcul_Click);
            // 
            // button_undo
            // 
            this.button_undo.Location = new System.Drawing.Point(361, 67);
            this.button_undo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(112, 41);
            this.button_undo.TabIndex = 7;
            this.button_undo.Text = "Annuler";
            this.button_undo.UseVisualStyleBackColor = true;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(361, 118);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(112, 41);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Quitter";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form_Somme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 173);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_undo);
            this.Controls.Add(this.button_calcul);
            this.Controls.Add(this.text_sum);
            this.Controls.Add(this.text_num2);
            this.Controls.Add(this.text_num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Somme";
            this.Text = "Somme de deux nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_num1;
        private System.Windows.Forms.TextBox text_num2;
        private System.Windows.Forms.TextBox text_sum;
        private System.Windows.Forms.Button button_calcul;
        private System.Windows.Forms.Button button_undo;
        private System.Windows.Forms.Button button_exit;
    }
}

