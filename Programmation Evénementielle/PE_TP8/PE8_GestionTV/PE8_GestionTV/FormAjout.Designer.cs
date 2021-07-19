namespace PE8_GestionTV
{
    partial class FormAjout
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label heureLabel;
            System.Windows.Forms.Label dureeLabel;
            System.Windows.Forms.Label typeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjout));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.dureeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.heureMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.emissionDataGridView = new System.Windows.Forms.DataGridView();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            numeroLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            heureLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emissionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            numeroLabel.Location = new System.Drawing.Point(49, 31);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(54, 13);
            numeroLabel.TabIndex = 0;
            numeroLabel.Text = "Numéro:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(63, 59);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 2;
            nomLabel.Text = "Nom:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(63, 89);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(34, 13);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date:";
            // 
            // heureLabel
            // 
            heureLabel.AutoSize = true;
            heureLabel.Location = new System.Drawing.Point(222, 89);
            heureLabel.Name = "heureLabel";
            heureLabel.Size = new System.Drawing.Size(40, 13);
            heureLabel.TabIndex = 6;
            heureLabel.Text = "Heure:";
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Location = new System.Drawing.Point(319, 89);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(67, 13);
            dureeLabel.TabIndex = 8;
            dureeLabel.Text = "Durée (min):";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(282, 55);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(35, 13);
            typeLabel.TabIndex = 10;
            typeLabel.Text = "Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(typeLabel);
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Controls.Add(dureeLabel);
            this.groupBox1.Controls.Add(this.dureeNumericUpDown);
            this.groupBox1.Controls.Add(heureLabel);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(this.dateDateTimePicker);
            this.groupBox1.Controls.Add(this.heureMaskedTextBox);
            this.groupBox1.Controls.Add(nomLabel);
            this.groupBox1.Controls.Add(this.nomTextBox);
            this.groupBox1.Controls.Add(numeroLabel);
            this.groupBox1.Controls.Add(this.numeroTextBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edition de l\'émission";
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(323, 51);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(130, 21);
            this.typeComboBox.TabIndex = 11;
            // 
            // dureeNumericUpDown
            // 
            this.dureeNumericUpDown.Location = new System.Drawing.Point(392, 85);
            this.dureeNumericUpDown.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.dureeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dureeNumericUpDown.Name = "dureeNumericUpDown";
            this.dureeNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.dureeNumericUpDown.TabIndex = 9;
            this.dureeNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(103, 85);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(113, 20);
            this.dateDateTimePicker.TabIndex = 5;
            // 
            // heureMaskedTextBox
            // 
            this.heureMaskedTextBox.Location = new System.Drawing.Point(268, 85);
            this.heureMaskedTextBox.Mask = "00:00";
            this.heureMaskedTextBox.Name = "heureMaskedTextBox";
            this.heureMaskedTextBox.Size = new System.Drawing.Size(37, 20);
            this.heureMaskedTextBox.TabIndex = 7;
            this.heureMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(103, 55);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(173, 20);
            this.nomTextBox.TabIndex = 3;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numeroTextBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.numeroTextBox.Location = new System.Drawing.Point(103, 25);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(92, 24);
            this.numeroTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.emissionDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(15, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 209);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste de l\'émission";
            // 
            // emissionDataGridView
            // 
            this.emissionDataGridView.AllowUserToAddRows = false;
            this.emissionDataGridView.AllowUserToDeleteRows = false;
            this.emissionDataGridView.AutoGenerateColumns = false;
            this.emissionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emissionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.emissionDataGridView.DataSource = this.emissionBindingSource;
            this.emissionDataGridView.Location = new System.Drawing.Point(16, 20);
            this.emissionDataGridView.Name = "emissionDataGridView";
            this.emissionDataGridView.ReadOnly = true;
            this.emissionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emissionDataGridView.Size = new System.Drawing.Size(644, 170);
            this.emissionDataGridView.TabIndex = 0;
            this.emissionDataGridView.SelectionChanged += new System.EventHandler(this.emissionDataGridView_SelectionChanged);
            // 
            // button_modifier
            // 
            this.button_modifier.Image = global::PE8_GestionTV.Properties.Resources.edit_button;
            this.button_modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modifier.Location = new System.Drawing.Point(540, 53);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(152, 27);
            this.button_modifier.TabIndex = 1;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_rechercher
            // 
            this.button_rechercher.Image = global::PE8_GestionTV.Properties.Resources.find;
            this.button_rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rechercher.Location = new System.Drawing.Point(540, 125);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(152, 27);
            this.button_rechercher.TabIndex = 1;
            this.button_rechercher.Text = "Rechercher";
            this.button_rechercher.UseVisualStyleBackColor = true;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Image = global::PE8_GestionTV.Properties.Resources.delete;
            this.button_supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_supprimer.Location = new System.Drawing.Point(540, 89);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(152, 27);
            this.button_supprimer.TabIndex = 1;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Image = global::PE8_GestionTV.Properties.Resources.add;
            this.button_ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ajouter.Location = new System.Drawing.Point(540, 17);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(152, 27);
            this.button_ajouter.TabIndex = 1;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Heure";
            this.dataGridViewTextBoxColumn4.HeaderText = "Heure";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Duree";
            this.dataGridViewTextBoxColumn5.HeaderText = "Duree";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn6.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // emissionBindingSource
            // 
            this.emissionBindingSource.DataSource = typeof(PE8_GestionTV.Emission);
            // 
            // FormAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 384);
            this.Controls.Add(this.button_rechercher);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAjout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des émissions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAjout_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emissionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emissionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.DataGridView emissionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.NumericUpDown dureeNumericUpDown;
        private System.Windows.Forms.MaskedTextBox heureMaskedTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        public System.Windows.Forms.BindingSource emissionBindingSource;
    }
}