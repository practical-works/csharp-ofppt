namespace PE2_Ex4
{
    partial class Form_Conversion
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
            this.groupBox_change = new System.Windows.Forms.GroupBox();
            this.textBox_change = new System.Windows.Forms.TextBox();
            this.label_change = new System.Windows.Forms.Label();
            this.groupBox_ChoixConversion = new System.Windows.Forms.GroupBox();
            this.radioButton_euroTOdh = new System.Windows.Forms.RadioButton();
            this.radioButton_dhTOeuro = new System.Windows.Forms.RadioButton();
            this.groupBox_montantEURO = new System.Windows.Forms.GroupBox();
            this.textBox_second = new System.Windows.Forms.TextBox();
            this.textBox_first = new System.Windows.Forms.TextBox();
            this.label_first = new System.Windows.Forms.Label();
            this.button_convert = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.label_second = new System.Windows.Forms.Label();
            this.groupBox_change.SuspendLayout();
            this.groupBox_ChoixConversion.SuspendLayout();
            this.groupBox_montantEURO.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_change
            // 
            this.groupBox_change.Controls.Add(this.textBox_change);
            this.groupBox_change.Controls.Add(this.label_change);
            this.groupBox_change.Location = new System.Drawing.Point(15, 12);
            this.groupBox_change.Name = "groupBox_change";
            this.groupBox_change.Size = new System.Drawing.Size(299, 45);
            this.groupBox_change.TabIndex = 0;
            this.groupBox_change.TabStop = false;
            // 
            // textBox_change
            // 
            this.textBox_change.Location = new System.Drawing.Point(179, 15);
            this.textBox_change.Name = "textBox_change";
            this.textBox_change.Size = new System.Drawing.Size(100, 20);
            this.textBox_change.TabIndex = 1;
            // 
            // label_change
            // 
            this.label_change.AutoSize = true;
            this.label_change.Location = new System.Drawing.Point(17, 19);
            this.label_change.Name = "label_change";
            this.label_change.Size = new System.Drawing.Size(156, 13);
            this.label_change.TabIndex = 0;
            this.label_change.Text = "Valeur de change     1 EURO = ";
            // 
            // groupBox_ChoixConversion
            // 
            this.groupBox_ChoixConversion.Controls.Add(this.radioButton_euroTOdh);
            this.groupBox_ChoixConversion.Controls.Add(this.radioButton_dhTOeuro);
            this.groupBox_ChoixConversion.Location = new System.Drawing.Point(15, 63);
            this.groupBox_ChoixConversion.Name = "groupBox_ChoixConversion";
            this.groupBox_ChoixConversion.Size = new System.Drawing.Size(299, 42);
            this.groupBox_ChoixConversion.TabIndex = 1;
            this.groupBox_ChoixConversion.TabStop = false;
            // 
            // radioButton_euroTOdh
            // 
            this.radioButton_euroTOdh.AutoSize = true;
            this.radioButton_euroTOdh.Location = new System.Drawing.Point(190, 13);
            this.radioButton_euroTOdh.Name = "radioButton_euroTOdh";
            this.radioButton_euroTOdh.Size = new System.Drawing.Size(89, 17);
            this.radioButton_euroTOdh.TabIndex = 1;
            this.radioButton_euroTOdh.Text = "EURO --> DH";
            this.radioButton_euroTOdh.UseVisualStyleBackColor = true;
            this.radioButton_euroTOdh.CheckedChanged += new System.EventHandler(this.radioButton_euroTOdh_CheckedChanged);
            // 
            // radioButton_dhTOeuro
            // 
            this.radioButton_dhTOeuro.AutoSize = true;
            this.radioButton_dhTOeuro.Checked = true;
            this.radioButton_dhTOeuro.Location = new System.Drawing.Point(20, 14);
            this.radioButton_dhTOeuro.Name = "radioButton_dhTOeuro";
            this.radioButton_dhTOeuro.Size = new System.Drawing.Size(89, 17);
            this.radioButton_dhTOeuro.TabIndex = 0;
            this.radioButton_dhTOeuro.TabStop = true;
            this.radioButton_dhTOeuro.Text = "DH --> EURO";
            this.radioButton_dhTOeuro.UseVisualStyleBackColor = true;
            this.radioButton_dhTOeuro.CheckedChanged += new System.EventHandler(this.radioButton_dhTOeuro_CheckedChanged);
            // 
            // groupBox_montantEURO
            // 
            this.groupBox_montantEURO.Controls.Add(this.label_second);
            this.groupBox_montantEURO.Controls.Add(this.textBox_second);
            this.groupBox_montantEURO.Controls.Add(this.textBox_first);
            this.groupBox_montantEURO.Controls.Add(this.label_first);
            this.groupBox_montantEURO.Location = new System.Drawing.Point(15, 111);
            this.groupBox_montantEURO.Name = "groupBox_montantEURO";
            this.groupBox_montantEURO.Size = new System.Drawing.Size(299, 77);
            this.groupBox_montantEURO.TabIndex = 2;
            this.groupBox_montantEURO.TabStop = false;
            // 
            // textBox_second
            // 
            this.textBox_second.Location = new System.Drawing.Point(123, 45);
            this.textBox_second.Name = "textBox_second";
            this.textBox_second.ReadOnly = true;
            this.textBox_second.Size = new System.Drawing.Size(156, 20);
            this.textBox_second.TabIndex = 2;
            // 
            // textBox_first
            // 
            this.textBox_first.Location = new System.Drawing.Point(123, 18);
            this.textBox_first.Name = "textBox_first";
            this.textBox_first.Size = new System.Drawing.Size(156, 20);
            this.textBox_first.TabIndex = 1;
            // 
            // label_first
            // 
            this.label_first.AutoSize = true;
            this.label_first.Location = new System.Drawing.Point(17, 25);
            this.label_first.Name = "label_first";
            this.label_first.Size = new System.Drawing.Size(86, 13);
            this.label_first.TabIndex = 0;
            this.label_first.Text = "Montant en DH :";
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(81, 208);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(75, 23);
            this.button_convert.TabIndex = 3;
            this.button_convert.Text = "Convertir";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(172, 208);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(75, 23);
            this.button_annuler.TabIndex = 4;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // label_second
            // 
            this.label_second.AutoSize = true;
            this.label_second.Location = new System.Drawing.Point(17, 44);
            this.label_second.Name = "label_second";
            this.label_second.Size = new System.Drawing.Size(100, 13);
            this.label_second.TabIndex = 5;
            this.label_second.Text = "Montant en EURO :";
            // 
            // Form_Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 247);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.groupBox_montantEURO);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.groupBox_ChoixConversion);
            this.Controls.Add(this.groupBox_change);
            this.Name = "Form_Conversion";
            this.Text = "Conversion de Devises";
            this.groupBox_change.ResumeLayout(false);
            this.groupBox_change.PerformLayout();
            this.groupBox_ChoixConversion.ResumeLayout(false);
            this.groupBox_ChoixConversion.PerformLayout();
            this.groupBox_montantEURO.ResumeLayout(false);
            this.groupBox_montantEURO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_change;
        private System.Windows.Forms.TextBox textBox_change;
        private System.Windows.Forms.Label label_change;
        private System.Windows.Forms.GroupBox groupBox_ChoixConversion;
        private System.Windows.Forms.RadioButton radioButton_euroTOdh;
        private System.Windows.Forms.RadioButton radioButton_dhTOeuro;
        private System.Windows.Forms.GroupBox groupBox_montantEURO;
        private System.Windows.Forms.TextBox textBox_second;
        private System.Windows.Forms.TextBox textBox_first;
        private System.Windows.Forms.Label label_first;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.Label label_second;
    }
}

