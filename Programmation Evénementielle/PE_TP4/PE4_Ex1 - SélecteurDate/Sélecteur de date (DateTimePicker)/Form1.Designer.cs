namespace Sélecteur_de_date__DateTimePicker_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_today_datetime = new System.Windows.Forms.Label();
            this.button_afficher = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.textBox_short = new System.Windows.Forms.TextBox();
            this.textBox_long = new System.Windows.Forms.TextBox();
            this.textBox_day = new System.Windows.Forms.TextBox();
            this.textBox_month = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.dateTimePicker_main = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aujourd\'hui le :\r\n\r\nDate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 195);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valeur :\r\n\r\nDate :\r\n\r\nHeure :\r\n\r\nFormat Court :\r\n\r\nFormat Long :\r\n\r\nJour :\r\n\r\nMoi" +
                "s :\r\n\r\nAnnée :";
            // 
            // label_today_datetime
            // 
            this.label_today_datetime.AutoSize = true;
            this.label_today_datetime.Location = new System.Drawing.Point(170, 35);
            this.label_today_datetime.Name = "label_today_datetime";
            this.label_today_datetime.Size = new System.Drawing.Size(19, 13);
            this.label_today_datetime.TabIndex = 2;
            this.label_today_datetime.Text = "...";
            // 
            // button_afficher
            // 
            this.button_afficher.Location = new System.Drawing.Point(111, 103);
            this.button_afficher.Name = "button_afficher";
            this.button_afficher.Size = new System.Drawing.Size(83, 23);
            this.button_afficher.TabIndex = 3;
            this.button_afficher.Text = "Afficher";
            this.button_afficher.UseVisualStyleBackColor = true;
            this.button_afficher.Click += new System.EventHandler(this.button_afficher_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_annuler.Location = new System.Drawing.Point(218, 103);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(83, 23);
            this.button_annuler.TabIndex = 4;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // textBox_value
            // 
            this.textBox_value.Enabled = false;
            this.textBox_value.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_value.Location = new System.Drawing.Point(173, 146);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.ReadOnly = true;
            this.textBox_value.Size = new System.Drawing.Size(170, 21);
            this.textBox_value.TabIndex = 5;
            // 
            // textBox_date
            // 
            this.textBox_date.Enabled = false;
            this.textBox_date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_date.Location = new System.Drawing.Point(173, 172);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.ReadOnly = true;
            this.textBox_date.Size = new System.Drawing.Size(170, 21);
            this.textBox_date.TabIndex = 5;
            // 
            // textBox_time
            // 
            this.textBox_time.Enabled = false;
            this.textBox_time.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_time.Location = new System.Drawing.Point(173, 198);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.ReadOnly = true;
            this.textBox_time.Size = new System.Drawing.Size(170, 21);
            this.textBox_time.TabIndex = 5;
            // 
            // textBox_short
            // 
            this.textBox_short.Enabled = false;
            this.textBox_short.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_short.Location = new System.Drawing.Point(173, 224);
            this.textBox_short.Name = "textBox_short";
            this.textBox_short.ReadOnly = true;
            this.textBox_short.Size = new System.Drawing.Size(170, 21);
            this.textBox_short.TabIndex = 5;
            // 
            // textBox_long
            // 
            this.textBox_long.Enabled = false;
            this.textBox_long.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_long.Location = new System.Drawing.Point(173, 250);
            this.textBox_long.Name = "textBox_long";
            this.textBox_long.ReadOnly = true;
            this.textBox_long.Size = new System.Drawing.Size(170, 21);
            this.textBox_long.TabIndex = 5;
            // 
            // textBox_day
            // 
            this.textBox_day.Enabled = false;
            this.textBox_day.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_day.Location = new System.Drawing.Point(173, 276);
            this.textBox_day.Name = "textBox_day";
            this.textBox_day.ReadOnly = true;
            this.textBox_day.Size = new System.Drawing.Size(170, 21);
            this.textBox_day.TabIndex = 5;
            // 
            // textBox_month
            // 
            this.textBox_month.Enabled = false;
            this.textBox_month.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_month.Location = new System.Drawing.Point(173, 302);
            this.textBox_month.Name = "textBox_month";
            this.textBox_month.ReadOnly = true;
            this.textBox_month.Size = new System.Drawing.Size(170, 21);
            this.textBox_month.TabIndex = 5;
            // 
            // textBox_year
            // 
            this.textBox_year.Enabled = false;
            this.textBox_year.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_year.Location = new System.Drawing.Point(173, 328);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.ReadOnly = true;
            this.textBox_year.Size = new System.Drawing.Size(170, 21);
            this.textBox_year.TabIndex = 5;
            // 
            // dateTimePicker_main
            // 
            this.dateTimePicker_main.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker_main.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker_main.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker_main.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker_main.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePicker_main.Location = new System.Drawing.Point(143, 64);
            this.dateTimePicker_main.Name = "dateTimePicker_main";
            this.dateTimePicker_main.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_main.TabIndex = 6;
            // 
            // Form_main
            // 
            this.AcceptButton = this.button_afficher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.button_annuler;
            this.ClientSize = new System.Drawing.Size(412, 383);
            this.Controls.Add(this.dateTimePicker_main);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_month);
            this.Controls.Add(this.textBox_day);
            this.Controls.Add(this.textBox_long);
            this.Controls.Add(this.textBox_short);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.button_afficher);
            this.Controls.Add(this.label_today_datetime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date et Heure";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_today_datetime;
        private System.Windows.Forms.Button button_afficher;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.TextBox textBox_short;
        private System.Windows.Forms.TextBox textBox_long;
        private System.Windows.Forms.TextBox textBox_day;
        private System.Windows.Forms.TextBox textBox_month;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.DateTimePicker dateTimePicker_main;
    }
}

