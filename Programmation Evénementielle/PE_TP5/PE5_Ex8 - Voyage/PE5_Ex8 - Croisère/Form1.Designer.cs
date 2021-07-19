namespace Voyage
{
    partial class Form_voyage
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
            this.textBox_intitule = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_arrivee = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_depart = new System.Windows.Forms.DateTimePicker();
            this.label_jours = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_inscrits = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_places = new System.Windows.Forms.NumericUpDown();
            this.label_libres = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inscrits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_places)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intitulé :";
            // 
            // textBox_intitule
            // 
            this.textBox_intitule.BackColor = System.Drawing.Color.White;
            this.textBox_intitule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_intitule.Location = new System.Drawing.Point(121, 49);
            this.textBox_intitule.Name = "textBox_intitule";
            this.textBox_intitule.Size = new System.Drawing.Size(539, 26);
            this.textBox_intitule.TabIndex = 1;
            this.textBox_intitule.TextChanged += new System.EventHandler(this.textBox_intitule_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_arrivee);
            this.groupBox1.Controls.Add(this.dateTimePicker_depart);
            this.groupBox1.Controls.Add(this.label_jours);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(17, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dates";
            // 
            // dateTimePicker_arrivee
            // 
            this.dateTimePicker_arrivee.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker_arrivee.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker_arrivee.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker_arrivee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_arrivee.Location = new System.Drawing.Point(276, 49);
            this.dateTimePicker_arrivee.Name = "dateTimePicker_arrivee";
            this.dateTimePicker_arrivee.Size = new System.Drawing.Size(205, 26);
            this.dateTimePicker_arrivee.TabIndex = 2;
            this.dateTimePicker_arrivee.ValueChanged += new System.EventHandler(this.dateTimePicker_depart_ValueChanged);
            // 
            // dateTimePicker_depart
            // 
            this.dateTimePicker_depart.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker_depart.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker_depart.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker_depart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_depart.Location = new System.Drawing.Point(31, 49);
            this.dateTimePicker_depart.Name = "dateTimePicker_depart";
            this.dateTimePicker_depart.Size = new System.Drawing.Size(205, 26);
            this.dateTimePicker_depart.TabIndex = 2;
            this.dateTimePicker_depart.ValueChanged += new System.EventHandler(this.dateTimePicker_depart_ValueChanged);
            // 
            // label_jours
            // 
            this.label_jours.AutoSize = true;
            this.label_jours.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jours.Location = new System.Drawing.Point(523, 55);
            this.label_jours.Name = "label_jours";
            this.label_jours.Size = new System.Drawing.Size(90, 19);
            this.label_jours.TabIndex = 1;
            this.label_jours.Text = "0 jour(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Arrivée :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Départ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_inscrits);
            this.groupBox2.Controls.Add(this.numericUpDown_places);
            this.groupBox2.Controls.Add(this.label_libres);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(17, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Effetif";
            // 
            // numericUpDown_inscrits
            // 
            this.numericUpDown_inscrits.BackColor = System.Drawing.Color.Snow;
            this.numericUpDown_inscrits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_inscrits.Location = new System.Drawing.Point(273, 49);
            this.numericUpDown_inscrits.Name = "numericUpDown_inscrits";
            this.numericUpDown_inscrits.Size = new System.Drawing.Size(202, 26);
            this.numericUpDown_inscrits.TabIndex = 4;
            this.numericUpDown_inscrits.ValueChanged += new System.EventHandler(this.numericUpDown_places_ValueChanged);
            // 
            // numericUpDown_places
            // 
            this.numericUpDown_places.BackColor = System.Drawing.Color.Snow;
            this.numericUpDown_places.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_places.Location = new System.Drawing.Point(26, 49);
            this.numericUpDown_places.Name = "numericUpDown_places";
            this.numericUpDown_places.Size = new System.Drawing.Size(205, 26);
            this.numericUpDown_places.TabIndex = 3;
            this.numericUpDown_places.ValueChanged += new System.EventHandler(this.numericUpDown_places_ValueChanged);
            // 
            // label_libres
            // 
            this.label_libres.AutoSize = true;
            this.label_libres.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_libres.Location = new System.Drawing.Point(523, 51);
            this.label_libres.Name = "label_libres";
            this.label_libres.Size = new System.Drawing.Size(99, 19);
            this.label_libres.TabIndex = 2;
            this.label_libres.Text = "Libres : 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre d\'inscrits :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre de places :";
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.Gainsboro;
            this.button_OK.BackgroundImage = global::Voyage.Properties.Resources.gradient_thead;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.ForeColor = System.Drawing.Color.Black;
            this.button_OK.Location = new System.Drawing.Point(549, 319);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(111, 31);
            this.button_OK.TabIndex = 3;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Annuler
            // 
            this.button_Annuler.BackColor = System.Drawing.Color.LightGray;
            this.button_Annuler.BackgroundImage = global::Voyage.Properties.Resources.gradient_thead;
            this.button_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Annuler.ForeColor = System.Drawing.Color.Black;
            this.button_Annuler.Location = new System.Drawing.Point(432, 319);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(111, 31);
            this.button_Annuler.TabIndex = 4;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = false;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_Annuler);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button_OK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.textBox_intitule);
            this.panel1.Location = new System.Drawing.Point(31, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 369);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Voyage.Properties.Resources.gradient_tcat;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 31);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form_voyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Voyage.Properties.Resources.voyage;
            this.ClientSize = new System.Drawing.Size(738, 391);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_voyage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voyage :";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inscrits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_places)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_intitule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_arrivee;
        private System.Windows.Forms.DateTimePicker dateTimePicker_depart;
        private System.Windows.Forms.Label label_jours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown_inscrits;
        private System.Windows.Forms.NumericUpDown numericUpDown_places;
        private System.Windows.Forms.Label label_libres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Annuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

