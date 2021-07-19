namespace PE_Ex10
{
    partial class Main_Form
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
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code (4 Chiffres)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_code
            // 
            this.textBox_code.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox_code.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_code.ForeColor = System.Drawing.Color.Orange;
            this.textBox_code.Location = new System.Drawing.Point(17, 57);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(219, 82);
            this.textBox_code.TabIndex = 1;
            this.textBox_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_code.TextChanged += new System.EventHandler(this.textBox_code_TextChanged);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_OK.Enabled = false;
            this.button_OK.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_OK.Location = new System.Drawing.Point(17, 148);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(219, 84);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Annuler
            // 
            this.button_Annuler.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Annuler.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Annuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Annuler.Location = new System.Drawing.Point(17, 238);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(219, 41);
            this.button_Annuler.TabIndex = 3;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = false;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // Main_Form
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.button_Annuler;
            this.ClientSize = new System.Drawing.Size(253, 309);
            this.Controls.Add(this.button_Annuler);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Annuler;
    }
}

