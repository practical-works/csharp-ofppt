namespace PE_Ex8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_ValeurChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_montantDH = new System.Windows.Forms.TextBox();
            this.text_montantEURO = new System.Windows.Forms.TextBox();
            this.button_convertir = new System.Windows.Forms.Button();
            this.button_vider = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_ValeurChange);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valeur de change";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_convertir);
            this.groupBox2.Controls.Add(this.text_montantDH);
            this.groupBox2.Controls.Add(this.text_montantEURO);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(42, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 EURO =                                        DH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_ValeurChange
            // 
            this.text_ValeurChange.Location = new System.Drawing.Point(86, 26);
            this.text_ValeurChange.Name = "text_ValeurChange";
            this.text_ValeurChange.Size = new System.Drawing.Size(100, 20);
            this.text_ValeurChange.TabIndex = 1;
            this.text_ValeurChange.TextChanged += new System.EventHandler(this.text_ValeurChange_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Montant DH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Montant EURO";
            // 
            // text_montantDH
            // 
            this.text_montantDH.Location = new System.Drawing.Point(114, 28);
            this.text_montantDH.Name = "text_montantDH";
            this.text_montantDH.Size = new System.Drawing.Size(100, 20);
            this.text_montantDH.TabIndex = 2;
            this.text_montantDH.TextChanged += new System.EventHandler(this.text_montantDH_TextChanged);
            // 
            // text_montantEURO
            // 
            this.text_montantEURO.Location = new System.Drawing.Point(114, 90);
            this.text_montantEURO.Name = "text_montantEURO";
            this.text_montantEURO.ReadOnly = true;
            this.text_montantEURO.Size = new System.Drawing.Size(100, 20);
            this.text_montantEURO.TabIndex = 3;
            this.text_montantEURO.TextChanged += new System.EventHandler(this.text_montantEURO_TextChanged);
            // 
            // button_convertir
            // 
            this.button_convertir.Enabled = false;
            this.button_convertir.Location = new System.Drawing.Point(19, 58);
            this.button_convertir.Name = "button_convertir";
            this.button_convertir.Size = new System.Drawing.Size(195, 23);
            this.button_convertir.TabIndex = 4;
            this.button_convertir.Text = "Convertir";
            this.button_convertir.UseVisualStyleBackColor = true;
            this.button_convertir.Click += new System.EventHandler(this.button_convertir_Click);
            // 
            // button_vider
            // 
            this.button_vider.Location = new System.Drawing.Point(65, 283);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(75, 23);
            this.button_vider.TabIndex = 2;
            this.button_vider.Text = "Vider";
            this.button_vider.UseVisualStyleBackColor = true;
            this.button_vider.Click += new System.EventHandler(this.button_vider_Click);
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(185, 283);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(75, 23);
            this.button_quitter.TabIndex = 3;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(325, 334);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_vider);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion DIRHAM vers EURO";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_ValeurChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_convertir;
        private System.Windows.Forms.TextBox text_montantDH;
        private System.Windows.Forms.TextBox text_montantEURO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.Button button_quitter;
    }
}

