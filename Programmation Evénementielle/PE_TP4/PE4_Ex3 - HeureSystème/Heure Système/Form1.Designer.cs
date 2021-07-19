namespace Heure_Système
{
    partial class Form_time
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
            this.label_heureSystème = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_heureSystème
            // 
            this.label_heureSystème.AutoSize = true;
            this.label_heureSystème.ForeColor = System.Drawing.Color.White;
            this.label_heureSystème.Location = new System.Drawing.Point(20, 22);
            this.label_heureSystème.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_heureSystème.Name = "label_heureSystème";
            this.label_heureSystème.Size = new System.Drawing.Size(239, 24);
            this.label_heureSystème.TabIndex = 0;
            this.label_heureSystème.Text = "Heure Système :";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(273, 22);
            this.label_time.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(116, 24);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(408, 69);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_heureSystème);
            this.Font = new System.Drawing.Font("Visitor TT1 BRK", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Form_time";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sytem Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_heureSystème;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer1;
    }
}

