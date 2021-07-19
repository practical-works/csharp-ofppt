namespace PE5_Ex7___Séjour
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de places :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ville :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Andalus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(117, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Andalus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(236, 150);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.LightGreen;
            this.numericUpDown1.Location = new System.Drawing.Point(216, 22);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(217, 40);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.BackColor = System.Drawing.Color.LightGreen;
            this.domainUpDown1.Items.Add("Rabat");
            this.domainUpDown1.Items.Add("Ouarzazate");
            this.domainUpDown1.Items.Add("Salé");
            this.domainUpDown1.Items.Add("Safi");
            this.domainUpDown1.Items.Add("Témara");
            this.domainUpDown1.Items.Add("Meknès");
            this.domainUpDown1.Items.Add("BenSlimane");
            this.domainUpDown1.Items.Add("Errachidia");
            this.domainUpDown1.Items.Add("Kénitra");
            this.domainUpDown1.Items.Add("Efrane");
            this.domainUpDown1.Items.Add("Khémisset");
            this.domainUpDown1.Items.Add("Khénifra");
            this.domainUpDown1.Items.Add("SidiKacem");
            this.domainUpDown1.Items.Add("Oujda");
            this.domainUpDown1.Items.Add("Casablanca");
            this.domainUpDown1.Items.Add("Figuig");
            this.domainUpDown1.Items.Add("Mohammédia");
            this.domainUpDown1.Items.Add("Nador");
            this.domainUpDown1.Items.Add("Azilal");
            this.domainUpDown1.Items.Add("Laâyoune");
            this.domainUpDown1.Items.Add("Bénimellal");
            this.domainUpDown1.Items.Add("Boujdour");
            this.domainUpDown1.Items.Add("Eljadida");
            this.domainUpDown1.Items.Add("EsSemara");
            this.domainUpDown1.Items.Add("Khouribga");
            this.domainUpDown1.Items.Add("Dakhla");
            this.domainUpDown1.Items.Add("Settat");
            this.domainUpDown1.Items.Add("Agadir");
            this.domainUpDown1.Items.Add("Fès");
            this.domainUpDown1.Items.Add("Guelmim");
            this.domainUpDown1.Items.Add("Sefrou");
            this.domainUpDown1.Items.Add("TanTan");
            this.domainUpDown1.Items.Add("AlHoceima");
            this.domainUpDown1.Items.Add("Taroudannt");
            this.domainUpDown1.Items.Add("Boulemane");
            this.domainUpDown1.Items.Add("Tata");
            this.domainUpDown1.Items.Add("Taounate");
            this.domainUpDown1.Items.Add("Tiznit");
            this.domainUpDown1.Items.Add("Taza");
            this.domainUpDown1.Items.Add("Tanger");
            this.domainUpDown1.Items.Add("Marrakech");
            this.domainUpDown1.Items.Add("Chefchaouen");
            this.domainUpDown1.Items.Add("Chichaoua");
            this.domainUpDown1.Items.Add("Larache");
            this.domainUpDown1.Items.Add("AlkelaadesSraghna");
            this.domainUpDown1.Items.Add("Tétouan");
            this.domainUpDown1.Items.Add("Essaouirra");
            this.domainUpDown1.Location = new System.Drawing.Point(216, 78);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(217, 40);
            this.domainUpDown1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(463, 213);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Andalus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Séjour";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}

