namespace GestionVehicules
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_vehicule = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_marque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_consommation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_capReservoir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_QteCarburant = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_diesel = new System.Windows.Forms.RadioButton();
            this.radioButton_essence = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_compteurKm = new System.Windows.Forms.TextBox();
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.button_ajouterCarburant = new System.Windows.Forms.Button();
            this.button_effectuerVoyage = new System.Windows.Forms.Button();
            this.button_gaucheFIN = new System.Windows.Forms.Button();
            this.button_gauche = new System.Windows.Forms.Button();
            this.button_droit = new System.Windows.Forms.Button();
            this.button_droitFIN = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_fermer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisir un véhicule";
            // 
            // comboBox_vehicule
            // 
            this.comboBox_vehicule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_vehicule.FormattingEnabled = true;
            this.comboBox_vehicule.Location = new System.Drawing.Point(205, 24);
            this.comboBox_vehicule.Name = "comboBox_vehicule";
            this.comboBox_vehicule.Size = new System.Drawing.Size(144, 31);
            this.comboBox_vehicule.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marque";
            // 
            // textBox_marque
            // 
            this.textBox_marque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_marque.Location = new System.Drawing.Point(96, 65);
            this.textBox_marque.Name = "textBox_marque";
            this.textBox_marque.Size = new System.Drawing.Size(80, 30);
            this.textBox_marque.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Consommation";
            // 
            // textBox_consommation
            // 
            this.textBox_consommation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_consommation.Location = new System.Drawing.Point(375, 66);
            this.textBox_consommation.Name = "textBox_consommation";
            this.textBox_consommation.Size = new System.Drawing.Size(80, 30);
            this.textBox_consommation.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "L/100Km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Capacité du réservoir";
            // 
            // textBox_capReservoir
            // 
            this.textBox_capReservoir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_capReservoir.Location = new System.Drawing.Point(224, 102);
            this.textBox_capReservoir.Name = "textBox_capReservoir";
            this.textBox_capReservoir.Size = new System.Drawing.Size(92, 30);
            this.textBox_capReservoir.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "L";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantité du carburant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(666, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "L";
            // 
            // textBox_QteCarburant
            // 
            this.textBox_QteCarburant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_QteCarburant.Location = new System.Drawing.Point(569, 102);
            this.textBox_QteCarburant.Name = "textBox_QteCarburant";
            this.textBox_QteCarburant.Size = new System.Drawing.Size(92, 30);
            this.textBox_QteCarburant.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_essence);
            this.groupBox1.Controls.Add(this.radioButton_diesel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 67);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carburant";
            // 
            // radioButton_diesel
            // 
            this.radioButton_diesel.AutoSize = true;
            this.radioButton_diesel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_diesel.Location = new System.Drawing.Point(31, 26);
            this.radioButton_diesel.Name = "radioButton_diesel";
            this.radioButton_diesel.Size = new System.Drawing.Size(83, 27);
            this.radioButton_diesel.TabIndex = 0;
            this.radioButton_diesel.TabStop = true;
            this.radioButton_diesel.Text = "Diesel";
            this.radioButton_diesel.UseVisualStyleBackColor = false;
            // 
            // radioButton_essence
            // 
            this.radioButton_essence.AutoSize = true;
            this.radioButton_essence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_essence.Location = new System.Drawing.Point(154, 26);
            this.radioButton_essence.Name = "radioButton_essence";
            this.radioButton_essence.Size = new System.Drawing.Size(101, 27);
            this.radioButton_essence.TabIndex = 0;
            this.radioButton_essence.TabStop = true;
            this.radioButton_essence.Text = "Essence";
            this.radioButton_essence.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Compteur de Km";
            // 
            // textBox_compteurKm
            // 
            this.textBox_compteurKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_compteurKm.Location = new System.Drawing.Point(538, 151);
            this.textBox_compteurKm.Name = "textBox_compteurKm";
            this.textBox_compteurKm.Size = new System.Drawing.Size(92, 30);
            this.textBox_compteurKm.TabIndex = 15;
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.button_droitFIN);
            this.groupBox_main.Controls.Add(this.button_droit);
            this.groupBox_main.Controls.Add(this.button_gauche);
            this.groupBox_main.Controls.Add(this.button_gaucheFIN);
            this.groupBox_main.Controls.Add(this.button_effectuerVoyage);
            this.groupBox_main.Controls.Add(this.textBox_compteurKm);
            this.groupBox_main.Controls.Add(this.button_ajouterCarburant);
            this.groupBox_main.Controls.Add(this.label2);
            this.groupBox_main.Controls.Add(this.label10);
            this.groupBox_main.Controls.Add(this.comboBox_vehicule);
            this.groupBox_main.Controls.Add(this.groupBox1);
            this.groupBox_main.Controls.Add(this.label3);
            this.groupBox_main.Controls.Add(this.textBox_QteCarburant);
            this.groupBox_main.Controls.Add(this.textBox_marque);
            this.groupBox_main.Controls.Add(this.label8);
            this.groupBox_main.Controls.Add(this.label4);
            this.groupBox_main.Controls.Add(this.label9);
            this.groupBox_main.Controls.Add(this.textBox_consommation);
            this.groupBox_main.Controls.Add(this.label7);
            this.groupBox_main.Controls.Add(this.label5);
            this.groupBox_main.Controls.Add(this.textBox_capReservoir);
            this.groupBox_main.Controls.Add(this.label6);
            this.groupBox_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_main.Location = new System.Drawing.Point(12, 11);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(697, 285);
            this.groupBox_main.TabIndex = 16;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "Fiche Véhicule";
            // 
            // button_ajouterCarburant
            // 
            this.button_ajouterCarburant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_ajouterCarburant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajouterCarburant.Location = new System.Drawing.Point(479, 194);
            this.button_ajouterCarburant.Name = "button_ajouterCarburant";
            this.button_ajouterCarburant.Size = new System.Drawing.Size(209, 35);
            this.button_ajouterCarburant.TabIndex = 17;
            this.button_ajouterCarburant.Text = "Ajouter Carburant";
            this.button_ajouterCarburant.UseVisualStyleBackColor = false;
            // 
            // button_effectuerVoyage
            // 
            this.button_effectuerVoyage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_effectuerVoyage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_effectuerVoyage.Location = new System.Drawing.Point(479, 235);
            this.button_effectuerVoyage.Name = "button_effectuerVoyage";
            this.button_effectuerVoyage.Size = new System.Drawing.Size(209, 35);
            this.button_effectuerVoyage.TabIndex = 17;
            this.button_effectuerVoyage.Text = "Effectuer Voyage";
            this.button_effectuerVoyage.UseVisualStyleBackColor = false;
            // 
            // button_gaucheFIN
            // 
            this.button_gaucheFIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_gaucheFIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gaucheFIN.Font = new System.Drawing.Font("18thCentury", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gaucheFIN.Location = new System.Drawing.Point(13, 226);
            this.button_gaucheFIN.Name = "button_gaucheFIN";
            this.button_gaucheFIN.Size = new System.Drawing.Size(63, 44);
            this.button_gaucheFIN.TabIndex = 18;
            this.button_gaucheFIN.Text = "|<";
            this.button_gaucheFIN.UseVisualStyleBackColor = false;
            // 
            // button_gauche
            // 
            this.button_gauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_gauche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gauche.Font = new System.Drawing.Font("18thCentury", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gauche.Location = new System.Drawing.Point(90, 226);
            this.button_gauche.Name = "button_gauche";
            this.button_gauche.Size = new System.Drawing.Size(63, 44);
            this.button_gauche.TabIndex = 18;
            this.button_gauche.Text = "<<";
            this.button_gauche.UseVisualStyleBackColor = false;
            // 
            // button_droit
            // 
            this.button_droit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_droit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_droit.Font = new System.Drawing.Font("18thCentury", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_droit.Location = new System.Drawing.Point(192, 226);
            this.button_droit.Name = "button_droit";
            this.button_droit.Size = new System.Drawing.Size(63, 44);
            this.button_droit.TabIndex = 18;
            this.button_droit.Text = ">>";
            this.button_droit.UseVisualStyleBackColor = false;
            // 
            // button_droitFIN
            // 
            this.button_droitFIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_droitFIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_droitFIN.Font = new System.Drawing.Font("18thCentury", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_droitFIN.Location = new System.Drawing.Point(269, 226);
            this.button_droitFIN.Name = "button_droitFIN";
            this.button_droitFIN.Size = new System.Drawing.Size(63, 44);
            this.button_droitFIN.TabIndex = 18;
            this.button_droitFIN.Text = ">|";
            this.button_droitFIN.UseVisualStyleBackColor = false;
            // 
            // button_nouveau
            // 
            this.button_nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nouveau.ForeColor = System.Drawing.Color.Black;
            this.button_nouveau.Location = new System.Drawing.Point(715, 28);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(137, 33);
            this.button_nouveau.TabIndex = 17;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = false;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajouter.ForeColor = System.Drawing.Color.White;
            this.button_ajouter.Location = new System.Drawing.Point(715, 85);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(137, 33);
            this.button_ajouter.TabIndex = 17;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = false;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modifier.ForeColor = System.Drawing.Color.White;
            this.button_modifier.Location = new System.Drawing.Point(715, 142);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(137, 33);
            this.button_modifier.TabIndex = 17;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_supprimer.ForeColor = System.Drawing.Color.White;
            this.button_supprimer.Location = new System.Drawing.Point(715, 199);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(137, 33);
            this.button_supprimer.TabIndex = 17;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            // 
            // button_fermer
            // 
            this.button_fermer.BackColor = System.Drawing.Color.Black;
            this.button_fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fermer.ForeColor = System.Drawing.Color.White;
            this.button_fermer.Location = new System.Drawing.Point(715, 256);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(137, 33);
            this.button_fermer.TabIndex = 17;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(864, 316);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.button_nouveau);
            this.Controls.Add(this.groupBox_main);
            this.Font = new System.Drawing.Font("18thCentury", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Véhicules";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_vehicule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_marque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_consommation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_capReservoir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_QteCarburant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_essence;
        private System.Windows.Forms.RadioButton radioButton_diesel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_compteurKm;
        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.Button button_droitFIN;
        private System.Windows.Forms.Button button_droit;
        private System.Windows.Forms.Button button_gauche;
        private System.Windows.Forms.Button button_gaucheFIN;
        private System.Windows.Forms.Button button_effectuerVoyage;
        private System.Windows.Forms.Button button_ajouterCarburant;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_fermer;
    }
}

