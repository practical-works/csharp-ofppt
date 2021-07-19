namespace Jeu_de_Loterie
{
    partial class Form_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.button_validerNombre = new System.Windows.Forms.Button();
            this.groupBox_jeu = new System.Windows.Forms.GroupBox();
            this.label_resultat = new System.Windows.Forms.Label();
            this.label_nombre3 = new System.Windows.Forms.Label();
            this.label_nombre2 = new System.Windows.Forms.Label();
            this.label_nombre1 = new System.Windows.Forms.Label();
            this.button_arreter = new System.Windows.Forms.Button();
            this.button_demarrer = new System.Windows.Forms.Button();
            this.button_recommencer = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            this.timer_T = new System.Windows.Forms.Timer(this.components);
            this.label_coups = new System.Windows.Forms.Label();
            this.groupBox_jeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez un nombre entre 1 et 10";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(56, 39);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(46, 36);
            this.textBox_nombre.TabIndex = 1;
            // 
            // button_validerNombre
            // 
            this.button_validerNombre.Location = new System.Drawing.Point(108, 39);
            this.button_validerNombre.Name = "button_validerNombre";
            this.button_validerNombre.Size = new System.Drawing.Size(75, 39);
            this.button_validerNombre.TabIndex = 2;
            this.button_validerNombre.Text = "Valider";
            this.button_validerNombre.UseVisualStyleBackColor = true;
            this.button_validerNombre.Click += new System.EventHandler(this.button_validerNombre_Click);
            // 
            // groupBox_jeu
            // 
            this.groupBox_jeu.Controls.Add(this.label_resultat);
            this.groupBox_jeu.Controls.Add(this.label_nombre3);
            this.groupBox_jeu.Controls.Add(this.label_nombre2);
            this.groupBox_jeu.Controls.Add(this.label_nombre1);
            this.groupBox_jeu.Controls.Add(this.button_arreter);
            this.groupBox_jeu.Controls.Add(this.button_demarrer);
            this.groupBox_jeu.Controls.Add(this.label_coups);
            this.groupBox_jeu.Enabled = false;
            this.groupBox_jeu.Location = new System.Drawing.Point(19, 90);
            this.groupBox_jeu.Name = "groupBox_jeu";
            this.groupBox_jeu.Size = new System.Drawing.Size(201, 170);
            this.groupBox_jeu.TabIndex = 3;
            this.groupBox_jeu.TabStop = false;
            this.groupBox_jeu.Text = "Jeu";
            // 
            // label_resultat
            // 
            this.label_resultat.AutoSize = true;
            this.label_resultat.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultat.Location = new System.Drawing.Point(21, 129);
            this.label_resultat.Name = "label_resultat";
            this.label_resultat.Size = new System.Drawing.Size(0, 25);
            this.label_resultat.TabIndex = 5;
            this.label_resultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_nombre3
            // 
            this.label_nombre3.AutoSize = true;
            this.label_nombre3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre3.Location = new System.Drawing.Point(135, 32);
            this.label_nombre3.Name = "label_nombre3";
            this.label_nombre3.Size = new System.Drawing.Size(34, 39);
            this.label_nombre3.TabIndex = 4;
            this.label_nombre3.Text = "0";
            // 
            // label_nombre2
            // 
            this.label_nombre2.AutoSize = true;
            this.label_nombre2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre2.Location = new System.Drawing.Point(83, 32);
            this.label_nombre2.Name = "label_nombre2";
            this.label_nombre2.Size = new System.Drawing.Size(34, 39);
            this.label_nombre2.TabIndex = 3;
            this.label_nombre2.Text = "0";
            // 
            // label_nombre1
            // 
            this.label_nombre1.AutoSize = true;
            this.label_nombre1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre1.Location = new System.Drawing.Point(31, 32);
            this.label_nombre1.Name = "label_nombre1";
            this.label_nombre1.Size = new System.Drawing.Size(34, 39);
            this.label_nombre1.TabIndex = 2;
            this.label_nombre1.Text = "0";
            // 
            // button_arreter
            // 
            this.button_arreter.Enabled = false;
            this.button_arreter.Location = new System.Drawing.Point(103, 87);
            this.button_arreter.Name = "button_arreter";
            this.button_arreter.Size = new System.Drawing.Size(75, 30);
            this.button_arreter.TabIndex = 1;
            this.button_arreter.Text = "Arrêter";
            this.button_arreter.UseVisualStyleBackColor = true;
            this.button_arreter.Click += new System.EventHandler(this.button_arreter_Click);
            // 
            // button_demarrer
            // 
            this.button_demarrer.Location = new System.Drawing.Point(22, 87);
            this.button_demarrer.Name = "button_demarrer";
            this.button_demarrer.Size = new System.Drawing.Size(75, 30);
            this.button_demarrer.TabIndex = 0;
            this.button_demarrer.Text = "Démarrer";
            this.button_demarrer.UseVisualStyleBackColor = true;
            this.button_demarrer.Click += new System.EventHandler(this.button_demarrer_Click);
            // 
            // button_recommencer
            // 
            this.button_recommencer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_recommencer.Location = new System.Drawing.Point(28, 273);
            this.button_recommencer.Name = "button_recommencer";
            this.button_recommencer.Size = new System.Drawing.Size(88, 35);
            this.button_recommencer.TabIndex = 4;
            this.button_recommencer.Text = "Recommencer";
            this.button_recommencer.UseVisualStyleBackColor = true;
            this.button_recommencer.Click += new System.EventHandler(this.button_recommencer_Click);
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(122, 273);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(89, 35);
            this.button_quitter.TabIndex = 5;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // timer_T
            // 
            this.timer_T.Tick += new System.EventHandler(this.timer_T_Tick);
            // 
            // label_coups
            // 
            this.label_coups.AutoSize = true;
            this.label_coups.Location = new System.Drawing.Point(181, 149);
            this.label_coups.Name = "label_coups";
            this.label_coups.Size = new System.Drawing.Size(16, 13);
            this.label_coups.TabIndex = 6;
            this.label_coups.Text = "0 ";
            // 
            // Form_Game
            // 
            this.AcceptButton = this.button_validerNombre;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_recommencer;
            this.ClientSize = new System.Drawing.Size(239, 320);
            this.Controls.Add(this.button_validerNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_recommencer);
            this.Controls.Add(this.groupBox_jeu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu de Loterie";
            this.groupBox_jeu.ResumeLayout(false);
            this.groupBox_jeu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Button button_validerNombre;
        private System.Windows.Forms.GroupBox groupBox_jeu;
        private System.Windows.Forms.Label label_nombre3;
        private System.Windows.Forms.Label label_nombre2;
        private System.Windows.Forms.Label label_nombre1;
        private System.Windows.Forms.Button button_arreter;
        private System.Windows.Forms.Button button_demarrer;
        private System.Windows.Forms.Button button_recommencer;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Timer timer_T;
        private System.Windows.Forms.Label label_resultat;
        private System.Windows.Forms.Label label_coups;
    }
}

