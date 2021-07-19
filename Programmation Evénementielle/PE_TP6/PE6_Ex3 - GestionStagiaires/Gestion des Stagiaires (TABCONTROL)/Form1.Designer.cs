namespace GS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_ajout = new System.Windows.Forms.TabPage();
            this.button_vider = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.textBox_moyenne = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_liste = new System.Windows.Forms.TabPage();
            this.textBox_liste = new System.Windows.Forms.TextBox();
            this.button_initialiser = new System.Windows.Forms.Button();
            this.tabPage_recherche = new System.Windows.Forms.TabPage();
            this.textBox_resultat = new System.Windows.Forms.TextBox();
            this.button_rechercher = new System.Windows.Forms.Button();
            this.textBox_motCle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_critere = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_quitter = new System.Windows.Forms.Button();
            this.tabControl_main.SuspendLayout();
            this.tabPage_ajout.SuspendLayout();
            this.tabPage_liste.SuspendLayout();
            this.tabPage_recherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_ajout);
            this.tabControl_main.Controls.Add(this.tabPage_liste);
            this.tabControl_main.Controls.Add(this.tabPage_recherche);
            this.tabControl_main.Location = new System.Drawing.Point(15, 13);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(319, 232);
            this.tabControl_main.TabIndex = 0;
            this.tabControl_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // tabPage_ajout
            // 
            this.tabPage_ajout.Controls.Add(this.button_vider);
            this.tabPage_ajout.Controls.Add(this.button_ajouter);
            this.tabPage_ajout.Controls.Add(this.textBox_moyenne);
            this.tabPage_ajout.Controls.Add(this.textBox_prenom);
            this.tabPage_ajout.Controls.Add(this.textBox_nom);
            this.tabPage_ajout.Controls.Add(this.textBox_numero);
            this.tabPage_ajout.Controls.Add(this.label4);
            this.tabPage_ajout.Controls.Add(this.label3);
            this.tabPage_ajout.Controls.Add(this.label2);
            this.tabPage_ajout.Controls.Add(this.label1);
            this.tabPage_ajout.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ajout.Name = "tabPage_ajout";
            this.tabPage_ajout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ajout.Size = new System.Drawing.Size(311, 206);
            this.tabPage_ajout.TabIndex = 0;
            this.tabPage_ajout.Text = "Ajout";
            this.tabPage_ajout.UseVisualStyleBackColor = true;
            // 
            // button_vider
            // 
            this.button_vider.Location = new System.Drawing.Point(77, 165);
            this.button_vider.Name = "button_vider";
            this.button_vider.Size = new System.Drawing.Size(75, 23);
            this.button_vider.TabIndex = 6;
            this.button_vider.Text = "Vider";
            this.button_vider.UseVisualStyleBackColor = true;
            this.button_vider.Click += new System.EventHandler(this.button_vider_Click);
            this.button_vider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(159, 165);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 5;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            this.button_ajouter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // textBox_moyenne
            // 
            this.textBox_moyenne.Location = new System.Drawing.Point(109, 121);
            this.textBox_moyenne.Name = "textBox_moyenne";
            this.textBox_moyenne.Size = new System.Drawing.Size(58, 20);
            this.textBox_moyenne.TabIndex = 4;
            this.textBox_moyenne.Text = "0,00";
            this.textBox_moyenne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(109, 87);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(157, 20);
            this.textBox_prenom.TabIndex = 3;
            this.textBox_prenom.Text = "...";
            this.textBox_prenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(109, 53);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(157, 20);
            this.textBox_nom.TabIndex = 2;
            this.textBox_nom.Text = "...";
            this.textBox_nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(109, 19);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(58, 20);
            this.textBox_numero.TabIndex = 1;
            this.textBox_numero.Text = "1";
            this.textBox_numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Moyenne :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro :";
            // 
            // tabPage_liste
            // 
            this.tabPage_liste.Controls.Add(this.textBox_liste);
            this.tabPage_liste.Controls.Add(this.button_initialiser);
            this.tabPage_liste.Location = new System.Drawing.Point(4, 22);
            this.tabPage_liste.Name = "tabPage_liste";
            this.tabPage_liste.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_liste.Size = new System.Drawing.Size(311, 206);
            this.tabPage_liste.TabIndex = 1;
            this.tabPage_liste.Text = "Liste";
            this.tabPage_liste.UseVisualStyleBackColor = true;
            // 
            // textBox_liste
            // 
            this.textBox_liste.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_liste.Location = new System.Drawing.Point(16, 15);
            this.textBox_liste.Multiline = true;
            this.textBox_liste.Name = "textBox_liste";
            this.textBox_liste.ReadOnly = true;
            this.textBox_liste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_liste.Size = new System.Drawing.Size(278, 151);
            this.textBox_liste.TabIndex = 2;
            // 
            // button_initialiser
            // 
            this.button_initialiser.Location = new System.Drawing.Point(219, 173);
            this.button_initialiser.Name = "button_initialiser";
            this.button_initialiser.Size = new System.Drawing.Size(75, 23);
            this.button_initialiser.TabIndex = 1;
            this.button_initialiser.Text = "Initialiser";
            this.button_initialiser.UseVisualStyleBackColor = true;
            this.button_initialiser.Click += new System.EventHandler(this.button_initialiser_Click);
            // 
            // tabPage_recherche
            // 
            this.tabPage_recherche.Controls.Add(this.textBox_resultat);
            this.tabPage_recherche.Controls.Add(this.button_rechercher);
            this.tabPage_recherche.Controls.Add(this.textBox_motCle);
            this.tabPage_recherche.Controls.Add(this.label6);
            this.tabPage_recherche.Controls.Add(this.comboBox_critere);
            this.tabPage_recherche.Controls.Add(this.label5);
            this.tabPage_recherche.Location = new System.Drawing.Point(4, 22);
            this.tabPage_recherche.Name = "tabPage_recherche";
            this.tabPage_recherche.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_recherche.Size = new System.Drawing.Size(311, 206);
            this.tabPage_recherche.TabIndex = 2;
            this.tabPage_recherche.Text = "Recherche";
            this.tabPage_recherche.UseVisualStyleBackColor = true;
            // 
            // textBox_resultat
            // 
            this.textBox_resultat.Location = new System.Drawing.Point(16, 82);
            this.textBox_resultat.Multiline = true;
            this.textBox_resultat.Name = "textBox_resultat";
            this.textBox_resultat.ReadOnly = true;
            this.textBox_resultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_resultat.Size = new System.Drawing.Size(278, 105);
            this.textBox_resultat.TabIndex = 5;
            // 
            // button_rechercher
            // 
            this.button_rechercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_rechercher.BackgroundImage")));
            this.button_rechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_rechercher.Location = new System.Drawing.Point(253, 42);
            this.button_rechercher.Name = "button_rechercher";
            this.button_rechercher.Size = new System.Drawing.Size(43, 29);
            this.button_rechercher.TabIndex = 4;
            this.button_rechercher.UseVisualStyleBackColor = true;
            this.button_rechercher.Click += new System.EventHandler(this.button_rechercher_Click);
            this.button_rechercher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // textBox_motCle
            // 
            this.textBox_motCle.Location = new System.Drawing.Point(67, 47);
            this.textBox_motCle.Name = "textBox_motCle";
            this.textBox_motCle.Size = new System.Drawing.Size(180, 20);
            this.textBox_motCle.TabIndex = 3;
            this.textBox_motCle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mot clé :";
            // 
            // comboBox_critere
            // 
            this.comboBox_critere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_critere.FormattingEnabled = true;
            this.comboBox_critere.Location = new System.Drawing.Point(66, 17);
            this.comboBox_critere.Name = "comboBox_critere";
            this.comboBox_critere.Size = new System.Drawing.Size(93, 21);
            this.comboBox_critere.TabIndex = 1;
            this.comboBox_critere.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Critère :";
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(256, 251);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(75, 23);
            this.button_quitter.TabIndex = 1;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            this.button_quitter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.control_KeyDown);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 287);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.tabControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Stagiaires";
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_ajout.ResumeLayout(false);
            this.tabPage_ajout.PerformLayout();
            this.tabPage_liste.ResumeLayout(false);
            this.tabPage_liste.PerformLayout();
            this.tabPage_recherche.ResumeLayout(false);
            this.tabPage_recherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_ajout;
        private System.Windows.Forms.Button button_vider;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.TextBox textBox_moyenne;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_liste;
        private System.Windows.Forms.Button button_initialiser;
        private System.Windows.Forms.TabPage tabPage_recherche;
        private System.Windows.Forms.Button button_rechercher;
        private System.Windows.Forms.TextBox textBox_motCle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_critere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.TextBox textBox_liste;
        private System.Windows.Forms.TextBox textBox_resultat;
    }
}

