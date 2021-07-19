namespace Prix_d_une_Configuration
{
    partial class Form_main
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
            this.label_process = new System.Windows.Forms.Label();
            this.label_memory = new System.Windows.Forms.Label();
            this.label_grphicCard = new System.Windows.Forms.Label();
            this.comboBox_process = new System.Windows.Forms.ComboBox();
            this.comboBox_memory = new System.Windows.Forms.ComboBox();
            this.comboBox_graphicCard = new System.Windows.Forms.ComboBox();
            this.button_calculer = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_totalHT = new System.Windows.Forms.Label();
            this.label_tva = new System.Windows.Forms.Label();
            this.label_totalTTC = new System.Windows.Forms.Label();
            this.label_value_totalHT = new System.Windows.Forms.Label();
            this.label_value_tva = new System.Windows.Forms.Label();
            this.label_value_totalTTC = new System.Windows.Forms.Label();
            this.panel_prix = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox_devices = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_prix.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_devices.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_process
            // 
            this.label_process.AutoSize = true;
            this.label_process.Location = new System.Drawing.Point(15, 15);
            this.label_process.Name = "label_process";
            this.label_process.Size = new System.Drawing.Size(67, 13);
            this.label_process.TabIndex = 0;
            this.label_process.Text = "Processeur :";
            // 
            // label_memory
            // 
            this.label_memory.AutoSize = true;
            this.label_memory.Location = new System.Drawing.Point(15, 43);
            this.label_memory.Name = "label_memory";
            this.label_memory.Size = new System.Drawing.Size(54, 13);
            this.label_memory.TabIndex = 1;
            this.label_memory.Text = "Mémoire :";
            // 
            // label_grphicCard
            // 
            this.label_grphicCard.AutoSize = true;
            this.label_grphicCard.Location = new System.Drawing.Point(15, 70);
            this.label_grphicCard.Name = "label_grphicCard";
            this.label_grphicCard.Size = new System.Drawing.Size(93, 13);
            this.label_grphicCard.TabIndex = 2;
            this.label_grphicCard.Text = "Carte Graphique :";
            // 
            // comboBox_process
            // 
            this.comboBox_process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_process.FormattingEnabled = true;
            this.comboBox_process.Items.AddRange(new object[] {
            "Pentium 1",
            "Pentium 2",
            "Pentium 3",
            "Pentium 4",
            "Core Duo",
            "Core 2 Duo",
            "Core i3",
            "Core i5",
            "Core i7"});
            this.comboBox_process.Location = new System.Drawing.Point(125, 12);
            this.comboBox_process.Name = "comboBox_process";
            this.comboBox_process.Size = new System.Drawing.Size(121, 21);
            this.comboBox_process.TabIndex = 3;
            this.comboBox_process.SelectedIndexChanged += new System.EventHandler(this.comboBox_process_SelectedIndexChanged);
            // 
            // comboBox_memory
            // 
            this.comboBox_memory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_memory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_memory.FormattingEnabled = true;
            this.comboBox_memory.Items.AddRange(new object[] {
            "256 Mo",
            "512 Mo",
            "1 Go",
            "2 Go",
            "4 Go",
            "8 Go",
            "16 Go",
            "32 Go"});
            this.comboBox_memory.Location = new System.Drawing.Point(125, 40);
            this.comboBox_memory.Name = "comboBox_memory";
            this.comboBox_memory.Size = new System.Drawing.Size(121, 21);
            this.comboBox_memory.TabIndex = 4;
            this.comboBox_memory.SelectedIndexChanged += new System.EventHandler(this.comboBox_memory_SelectedIndexChanged);
            // 
            // comboBox_graphicCard
            // 
            this.comboBox_graphicCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_graphicCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_graphicCard.FormattingEnabled = true;
            this.comboBox_graphicCard.Items.AddRange(new object[] {
            "128 Mo",
            "256 Mo",
            "512 Mo",
            "1 Go",
            "2 Go",
            "4 Go",
            "8 Go",
            "16 Go"});
            this.comboBox_graphicCard.Location = new System.Drawing.Point(125, 67);
            this.comboBox_graphicCard.Name = "comboBox_graphicCard";
            this.comboBox_graphicCard.Size = new System.Drawing.Size(121, 21);
            this.comboBox_graphicCard.TabIndex = 5;
            this.comboBox_graphicCard.SelectedIndexChanged += new System.EventHandler(this.comboBox_graphicCard_SelectedIndexChanged);
            // 
            // button_calculer
            // 
            this.button_calculer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_calculer.BackColor = System.Drawing.Color.White;
            this.button_calculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_calculer.Location = new System.Drawing.Point(351, 271);
            this.button_calculer.Name = "button_calculer";
            this.button_calculer.Size = new System.Drawing.Size(75, 25);
            this.button_calculer.TabIndex = 7;
            this.button_calculer.Text = "Calculer";
            this.button_calculer.UseVisualStyleBackColor = false;
            this.button_calculer.Click += new System.EventHandler(this.button_calculer_Click);
            // 
            // button_reset
            // 
            this.button_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reset.BackColor = System.Drawing.Color.White;
            this.button_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Location = new System.Drawing.Point(432, 271);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 25);
            this.button_reset.TabIndex = 8;
            this.button_reset.Text = "Réinitialiser";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label_totalHT
            // 
            this.label_totalHT.AutoSize = true;
            this.label_totalHT.Location = new System.Drawing.Point(12, 14);
            this.label_totalHT.Name = "label_totalHT";
            this.label_totalHT.Size = new System.Drawing.Size(54, 13);
            this.label_totalHT.TabIndex = 9;
            this.label_totalHT.Text = "Total HT :";
            // 
            // label_tva
            // 
            this.label_tva.AutoSize = true;
            this.label_tva.Location = new System.Drawing.Point(12, 31);
            this.label_tva.Name = "label_tva";
            this.label_tva.Size = new System.Drawing.Size(33, 13);
            this.label_tva.TabIndex = 10;
            this.label_tva.Text = "TVA :";
            // 
            // label_totalTTC
            // 
            this.label_totalTTC.AutoSize = true;
            this.label_totalTTC.Location = new System.Drawing.Point(12, 48);
            this.label_totalTTC.Name = "label_totalTTC";
            this.label_totalTTC.Size = new System.Drawing.Size(60, 13);
            this.label_totalTTC.TabIndex = 11;
            this.label_totalTTC.Text = "Total TTC :";
            // 
            // label_value_totalHT
            // 
            this.label_value_totalHT.AutoSize = true;
            this.label_value_totalHT.Location = new System.Drawing.Point(81, 13);
            this.label_value_totalHT.Name = "label_value_totalHT";
            this.label_value_totalHT.Size = new System.Drawing.Size(30, 13);
            this.label_value_totalHT.TabIndex = 12;
            this.label_value_totalHT.Text = "0 DH";
            // 
            // label_value_tva
            // 
            this.label_value_tva.AutoSize = true;
            this.label_value_tva.Location = new System.Drawing.Point(81, 30);
            this.label_value_tva.Name = "label_value_tva";
            this.label_value_tva.Size = new System.Drawing.Size(27, 13);
            this.label_value_tva.TabIndex = 13;
            this.label_value_tva.Text = "0 %";
            // 
            // label_value_totalTTC
            // 
            this.label_value_totalTTC.AutoSize = true;
            this.label_value_totalTTC.Location = new System.Drawing.Point(81, 47);
            this.label_value_totalTTC.Name = "label_value_totalTTC";
            this.label_value_totalTTC.Size = new System.Drawing.Size(30, 13);
            this.label_value_totalTTC.TabIndex = 14;
            this.label_value_totalTTC.Text = "0 DH";
            // 
            // panel_prix
            // 
            this.panel_prix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_prix.BackColor = System.Drawing.Color.White;
            this.panel_prix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_prix.Controls.Add(this.label_value_totalTTC);
            this.panel_prix.Controls.Add(this.label_tva);
            this.panel_prix.Controls.Add(this.label_value_tva);
            this.panel_prix.Controls.Add(this.label_totalHT);
            this.panel_prix.Controls.Add(this.label_value_totalHT);
            this.panel_prix.Controls.Add(this.label_totalTTC);
            this.panel_prix.Location = new System.Drawing.Point(351, 12);
            this.panel_prix.Name = "panel_prix";
            this.panel_prix.Size = new System.Drawing.Size(156, 77);
            this.panel_prix.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox_process);
            this.panel1.Controls.Add(this.label_process);
            this.panel1.Controls.Add(this.label_memory);
            this.panel1.Controls.Add(this.label_grphicCard);
            this.panel1.Controls.Add(this.comboBox_graphicCard);
            this.panel1.Controls.Add(this.comboBox_memory);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 100);
            this.panel1.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(19, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Ecran LCD";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(19, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Souris";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(19, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Clavier";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Location = new System.Drawing.Point(132, 22);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(59, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Casque";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Location = new System.Drawing.Point(132, 45);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(77, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Imprimante";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Location = new System.Drawing.Point(132, 68);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(62, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Scanner";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // groupBox_devices
            // 
            this.groupBox_devices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_devices.BackColor = System.Drawing.Color.White;
            this.groupBox_devices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_devices.Controls.Add(this.checkBox6);
            this.groupBox_devices.Controls.Add(this.checkBox5);
            this.groupBox_devices.Controls.Add(this.checkBox4);
            this.groupBox_devices.Controls.Add(this.checkBox3);
            this.groupBox_devices.Controls.Add(this.checkBox2);
            this.groupBox_devices.Controls.Add(this.checkBox1);
            this.groupBox_devices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_devices.Location = new System.Drawing.Point(13, 10);
            this.groupBox_devices.Name = "groupBox_devices";
            this.groupBox_devices.Size = new System.Drawing.Size(228, 106);
            this.groupBox_devices.TabIndex = 6;
            this.groupBox_devices.TabStop = false;
            this.groupBox_devices.Text = "Périphériques";
            this.groupBox_devices.Enter += new System.EventHandler(this.groupBox_devices_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox_devices);
            this.panel2.Location = new System.Drawing.Point(18, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 129);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Prix_d_une_Configuration.Properties.Resources.troll_typing_animation;
            this.pictureBox1.Location = new System.Drawing.Point(-15, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 401);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form_main
            // 
            this.AcceptButton = this.button_calculer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_reset;
            this.ClientSize = new System.Drawing.Size(519, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_calculer);
            this.Controls.Add(this.panel_prix);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prix d\'une configuration informatique";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.panel_prix.ResumeLayout(false);
            this.panel_prix.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_devices.ResumeLayout(false);
            this.groupBox_devices.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_process;
        private System.Windows.Forms.Label label_memory;
        private System.Windows.Forms.Label label_grphicCard;
        private System.Windows.Forms.ComboBox comboBox_process;
        private System.Windows.Forms.ComboBox comboBox_memory;
        private System.Windows.Forms.ComboBox comboBox_graphicCard;
        private System.Windows.Forms.Button button_calculer;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_totalHT;
        private System.Windows.Forms.Label label_tva;
        private System.Windows.Forms.Label label_totalTTC;
        private System.Windows.Forms.Label label_value_totalHT;
        private System.Windows.Forms.Label label_value_tva;
        private System.Windows.Forms.Label label_value_totalTTC;
        private System.Windows.Forms.Panel panel_prix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox groupBox_devices;
        private System.Windows.Forms.Panel panel2;
    }
}

