namespace Chronomètre
{
    partial class Form_chrono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_chrono));
            this.button_arreter = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_demarrer = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_capturer = new System.Windows.Forms.Button();
            this.listBox_captures = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_arreter
            // 
            this.button_arreter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_arreter.BackColor = System.Drawing.Color.Black;
            this.button_arreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_arreter.ForeColor = System.Drawing.Color.White;
            this.button_arreter.Image = global::Chronomètre.Properties.Resources.bullet_black;
            this.button_arreter.Location = new System.Drawing.Point(207, 136);
            this.button_arreter.Name = "button_arreter";
            this.button_arreter.Size = new System.Drawing.Size(95, 38);
            this.button_arreter.TabIndex = 2;
            this.button_arreter.Text = "Arrêter";
            this.button_arreter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_arreter.UseVisualStyleBackColor = false;
            this.button_arreter.Click += new System.EventHandler(this.button_arreter_Click);
            // 
            // button_pause
            // 
            this.button_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_pause.BackColor = System.Drawing.Color.Black;
            this.button_pause.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_pause.ForeColor = System.Drawing.Color.White;
            this.button_pause.Image = global::Chronomètre.Properties.Resources.bullet_arrow_right_2;
            this.button_pause.Location = new System.Drawing.Point(109, 136);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(95, 38);
            this.button_pause.TabIndex = 1;
            this.button_pause.Text = "Pause";
            this.button_pause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_pause.UseVisualStyleBackColor = false;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_demarrer
            // 
            this.button_demarrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_demarrer.BackColor = System.Drawing.Color.Black;
            this.button_demarrer.ForeColor = System.Drawing.Color.White;
            this.button_demarrer.Image = global::Chronomètre.Properties.Resources.bullet_arrow_right1;
            this.button_demarrer.Location = new System.Drawing.Point(11, 136);
            this.button_demarrer.Name = "button_demarrer";
            this.button_demarrer.Size = new System.Drawing.Size(95, 38);
            this.button_demarrer.TabIndex = 0;
            this.button_demarrer.Text = "Démarrer";
            this.button_demarrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_demarrer.UseVisualStyleBackColor = false;
            this.button_demarrer.Click += new System.EventHandler(this.button_demarrer_Click);
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.Black;
            this.label_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_time.Font = new System.Drawing.Font("Terminator Two", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(11, 14);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(228, 50);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "00:00:00";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Chronomètre.Properties.Resources.anime_ani__4_;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 181);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_capturer
            // 
            this.button_capturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_capturer.BackColor = System.Drawing.Color.Black;
            this.button_capturer.ForeColor = System.Drawing.Color.White;
            this.button_capturer.Image = global::Chronomètre.Properties.Resources.walk;
            this.button_capturer.Location = new System.Drawing.Point(245, 14);
            this.button_capturer.Name = "button_capturer";
            this.button_capturer.Size = new System.Drawing.Size(57, 50);
            this.button_capturer.TabIndex = 5;
            this.button_capturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_capturer.UseVisualStyleBackColor = false;
            this.button_capturer.Click += new System.EventHandler(this.button_capturer_Click);
            // 
            // listBox_captures
            // 
            this.listBox_captures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_captures.BackColor = System.Drawing.Color.Black;
            this.listBox_captures.ForeColor = System.Drawing.Color.White;
            this.listBox_captures.FormattingEnabled = true;
            this.listBox_captures.Location = new System.Drawing.Point(12, 72);
            this.listBox_captures.Name = "listBox_captures";
            this.listBox_captures.Size = new System.Drawing.Size(289, 56);
            this.listBox_captures.TabIndex = 6;
            // 
            // Form_chrono
            // 
            this.AcceptButton = this.button_demarrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.button_pause;
            this.ClientSize = new System.Drawing.Size(313, 182);
            this.Controls.Add(this.listBox_captures);
            this.Controls.Add(this.button_capturer);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.button_arreter);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_demarrer);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_chrono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chronomètre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_demarrer;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_arreter;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_capturer;
        private System.Windows.Forms.ListBox listBox_captures;
    }
}

