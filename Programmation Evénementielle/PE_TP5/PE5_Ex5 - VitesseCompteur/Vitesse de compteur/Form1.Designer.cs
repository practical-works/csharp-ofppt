namespace Vitesse_de_compteur
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
            this.components = new System.ComponentModel.Container();
            this.label_counter = new System.Windows.Forms.Label();
            this.trackBar_speed = new System.Windows.Forms.TrackBar();
            this.label_speed = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_interval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // label_counter
            // 
            this.label_counter.AutoSize = true;
            this.label_counter.Font = new System.Drawing.Font("Terminator Two", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_counter.Location = new System.Drawing.Point(12, 17);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(102, 96);
            this.label_counter.TabIndex = 0;
            this.label_counter.Text = "0";
            // 
            // trackBar_speed
            // 
            this.trackBar_speed.Location = new System.Drawing.Point(58, 116);
            this.trackBar_speed.Maximum = 1000;
            this.trackBar_speed.Minimum = 1;
            this.trackBar_speed.Name = "trackBar_speed";
            this.trackBar_speed.Size = new System.Drawing.Size(226, 42);
            this.trackBar_speed.TabIndex = 1;
            this.trackBar_speed.TickFrequency = 100;
            this.trackBar_speed.Value = 1;
            this.trackBar_speed.Scroll += new System.EventHandler(this.trackBar_speed_Scroll);
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Location = new System.Drawing.Point(15, 121);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(48, 13);
            this.label_speed.TabIndex = 2;
            this.label_speed.Text = "Vitesse :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_interval
            // 
            this.label_interval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_interval.AutoSize = true;
            this.label_interval.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_interval.Location = new System.Drawing.Point(177, 154);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(107, 13);
            this.label_interval.TabIndex = 3;
            this.label_interval.Text = "0.000 Tick / Seconde";
            this.label_interval.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 176);
            this.Controls.Add(this.label_interval);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.trackBar_speed);
            this.Controls.Add(this.label_counter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compteur";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.TrackBar trackBar_speed;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_interval;
    }
}

