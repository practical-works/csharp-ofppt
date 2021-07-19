namespace GestionEntités
{
    partial class FormSaisie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label valeurLabel;
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_valeur = new System.Windows.Forms.TextBox();
            codeLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            valeurLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(74, 116);
            this.button_OK.Margin = new System.Windows.Forms.Padding(2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(100, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(18, 23);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(42, 16);
            codeLabel.TabIndex = 2;
            codeLabel.Text = "Code:";
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(74, 20);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(100, 23);
            this.textBox_code.TabIndex = 3;
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(18, 52);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(39, 16);
            nomLabel.TabIndex = 4;
            nomLabel.Text = "Nom:";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(74, 49);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(100, 23);
            this.textBox_nom.TabIndex = 5;
            // 
            // valeurLabel
            // 
            valeurLabel.AutoSize = true;
            valeurLabel.Location = new System.Drawing.Point(18, 81);
            valeurLabel.Name = "valeurLabel";
            valeurLabel.Size = new System.Drawing.Size(50, 16);
            valeurLabel.TabIndex = 6;
            valeurLabel.Text = "Valeur:";
            // 
            // textBox_valeur
            // 
            this.textBox_valeur.Location = new System.Drawing.Point(74, 78);
            this.textBox_valeur.Name = "textBox_valeur";
            this.textBox_valeur.Size = new System.Drawing.Size(100, 23);
            this.textBox_valeur.TabIndex = 7;
            // 
            // FormSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 160);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(valeurLabel);
            this.Controls.Add(this.textBox_valeur);
            this.Controls.Add(this.button_OK);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaisie";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saisie des Données";
            this.Load += new System.EventHandler(this.FormSaisie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_valeur;
    }
}