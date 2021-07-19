namespace Ajouter_un_client
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
            this.label_nom = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label_dateInscription = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label_adresse = new System.Windows.Forms.Label();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.label_telephone = new System.Windows.Forms.Label();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.button_vider = new System.Windows.Forms.Button();
            this.maskedTextBox_telephone = new System.Windows.Forms.MaskedTextBox();
            this.listBox_num = new System.Windows.Forms.ListBox();
            this.listBox_clients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(29, 23);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(80, 13);
            this.label_nom.TabIndex = 0;
            this.label_nom.Text = "Nom et Prénom";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(123, 20);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(199, 20);
            this.textBox_nom.TabIndex = 1;
            // 
            // label_dateInscription
            // 
            this.label_dateInscription.AutoSize = true;
            this.label_dateInscription.Location = new System.Drawing.Point(29, 49);
            this.label_dateInscription.Name = "label_dateInscription";
            this.label_dateInscription.Size = new System.Drawing.Size(89, 13);
            this.label_dateInscription.TabIndex = 2;
            this.label_dateInscription.Text = "Date d\'inscription";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(123, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar1.TabIndex = 3;
            // 
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Location = new System.Drawing.Point(29, 221);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(46, 13);
            this.label_adresse.TabIndex = 4;
            this.label_adresse.Text = "Adresse";
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(123, 221);
            this.textBox_adresse.Multiline = true;
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(199, 47);
            this.textBox_adresse.TabIndex = 5;
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Location = new System.Drawing.Point(29, 280);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(57, 13);
            this.label_telephone.TabIndex = 6;
            this.label_telephone.Text = "Téléphone";
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(95, 317);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 8;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(176, 317);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(75, 23);
            this.button_annuler.TabIndex = 9;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // button_vider
            // 
            this.button_vider.Location = new System.Drawing.Point(679, 317);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(75, 23);
            this.button_vider.TabIndex = 10;
            this.button_vider.Text = "Vider";
            this.button_vider.UseVisualStyleBackColor = true;
            this.button_vider.Click += new System.EventHandler(this.button_vider_Click);
            // 
            // maskedTextBox_telephone
            // 
            this.maskedTextBox_telephone.Location = new System.Drawing.Point(123, 280);
            this.maskedTextBox_telephone.Mask = "00 00 00 00 00";
            this.maskedTextBox_telephone.Name = "maskedTextBox_telephone";
            this.maskedTextBox_telephone.Size = new System.Drawing.Size(199, 20);
            this.maskedTextBox_telephone.TabIndex = 11;
            // 
            // listBox_num
            // 
            this.listBox_num.FormattingEnabled = true;
            this.listBox_num.Items.AddRange(new object[] {
            "1."});
            this.listBox_num.Location = new System.Drawing.Point(365, 20);
            this.listBox_num.Name = "listBox_num";
            this.listBox_num.Size = new System.Drawing.Size(41, 277);
            this.listBox_num.TabIndex = 12;
            this.listBox_num.SelectedIndexChanged += new System.EventHandler(this.listBox_num_SelectedIndexChanged);
            // 
            // listBox_clients
            // 
            this.listBox_clients.FormattingEnabled = true;
            this.listBox_clients.Items.AddRange(new object[] {
            "Flan Lflani,17-11-1997,Derb Drouba N°17 Place Ville Pays,0647859417"});
            this.listBox_clients.Location = new System.Drawing.Point(416, 20);
            this.listBox_clients.Name = "listBox_clients";
            this.listBox_clients.Size = new System.Drawing.Size(338, 277);
            this.listBox_clients.TabIndex = 12;
            this.listBox_clients.DoubleClick += new System.EventHandler(this.listBox_clients_DoubleClick);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 359);
            this.Controls.Add(this.listBox_clients);
            this.Controls.Add(this.listBox_num);
            this.Controls.Add(this.maskedTextBox_telephone);
            this.Controls.Add(this.button_vider);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.label_telephone);
            this.Controls.Add(this.textBox_adresse);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label_dateInscription);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout de clients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label_dateInscription;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telephone;
        private System.Windows.Forms.ListBox listBox_num;
        private System.Windows.Forms.ListBox listBox_clients;
    }
}

