namespace PE5_Ex1
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
            this.components = new System.ComponentModel.Container();
            this.progressBar_progression = new System.Windows.Forms.ProgressBar();
            this.button_demarrer = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_arreter = new System.Windows.Forms.Button();
            this.label_pourcentage = new System.Windows.Forms.Label();
            this.label_statut = new System.Windows.Forms.Label();
            this.timer_progression = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar_progression
            // 
            this.progressBar_progression.Location = new System.Drawing.Point(31, 41);
            this.progressBar_progression.Name = "progressBar_progression";
            this.progressBar_progression.Size = new System.Drawing.Size(190, 23);
            this.progressBar_progression.TabIndex = 0;
            // 
            // button_demarrer
            // 
            this.button_demarrer.Location = new System.Drawing.Point(31, 115);
            this.button_demarrer.Name = "button_demarrer";
            this.button_demarrer.Size = new System.Drawing.Size(75, 23);
            this.button_demarrer.TabIndex = 1;
            this.button_demarrer.Text = "Démarrer";
            this.button_demarrer.UseVisualStyleBackColor = true;
            this.button_demarrer.Click += new System.EventHandler(this.button_demarrer_Click);
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(112, 115);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(75, 23);
            this.button_pause.TabIndex = 1;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_arreter
            // 
            this.button_arreter.Location = new System.Drawing.Point(193, 115);
            this.button_arreter.Name = "button_arreter";
            this.button_arreter.Size = new System.Drawing.Size(75, 23);
            this.button_arreter.TabIndex = 1;
            this.button_arreter.Text = "Arrêter";
            this.button_arreter.UseVisualStyleBackColor = true;
            this.button_arreter.Click += new System.EventHandler(this.button_arreter_Click);
            // 
            // label_pourcentage
            // 
            this.label_pourcentage.AutoSize = true;
            this.label_pourcentage.Location = new System.Drawing.Point(232, 45);
            this.label_pourcentage.Name = "label_pourcentage";
            this.label_pourcentage.Size = new System.Drawing.Size(36, 13);
            this.label_pourcentage.TabIndex = 2;
            this.label_pourcentage.Text = "000%";
            // 
            // label_statut
            // 
            this.label_statut.AutoSize = true;
            this.label_statut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statut.Location = new System.Drawing.Point(67, 82);
            this.label_statut.Name = "label_statut";
            this.label_statut.Size = new System.Drawing.Size(16, 13);
            this.label_statut.TabIndex = 3;
            this.label_statut.Text = "...";
            this.label_statut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_progression
            // 
            this.timer_progression.Tick += new System.EventHandler(this.timer_progression_Tick);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 175);
            this.Controls.Add(this.label_statut);
            this.Controls.Add(this.label_pourcentage);
            this.Controls.Add(this.button_arreter);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_demarrer);
            this.Controls.Add(this.progressBar_progression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chargement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_progression;
        private System.Windows.Forms.Button button_demarrer;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_arreter;
        private System.Windows.Forms.Label label_pourcentage;
        private System.Windows.Forms.Label label_statut;
        private System.Windows.Forms.Timer timer_progression;
    }
}

