namespace Pe_Ex13
{
    partial class Form_mechant
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
            this.label_question = new System.Windows.Forms.Label();
            this.pictureBox_cuteAnime = new System.Windows.Forms.PictureBox();
            this.button_oui = new System.Windows.Forms.Button();
            this.button_non = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cuteAnime)).BeginInit();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question.ForeColor = System.Drawing.Color.Maroon;
            this.label_question.Location = new System.Drawing.Point(11, 9);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(296, 45);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "Est-tu Méchant ?";
            // 
            // pictureBox_cuteAnime
            // 
            this.pictureBox_cuteAnime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cuteAnime.Image = global::Pe_Ex13.Properties.Resources.png_cute_anime;
            this.pictureBox_cuteAnime.InitialImage = null;
            this.pictureBox_cuteAnime.Location = new System.Drawing.Point(-17, 57);
            this.pictureBox_cuteAnime.Name = "pictureBox_cuteAnime";
            this.pictureBox_cuteAnime.Size = new System.Drawing.Size(319, 187);
            this.pictureBox_cuteAnime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_cuteAnime.TabIndex = 1;
            this.pictureBox_cuteAnime.TabStop = false;
            // 
            // button_oui
            // 
            this.button_oui.BackColor = System.Drawing.Color.LightCoral;
            this.button_oui.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_oui.ForeColor = System.Drawing.Color.Red;
            this.button_oui.Location = new System.Drawing.Point(81, 258);
            this.button_oui.Name = "button_oui";
            this.button_oui.Size = new System.Drawing.Size(71, 36);
            this.button_oui.TabIndex = 2;
            this.button_oui.Text = "OUI";
            this.button_oui.UseVisualStyleBackColor = false;
            this.button_oui.Click += new System.EventHandler(this.button_oui_Click);
            // 
            // button_non
            // 
            this.button_non.BackColor = System.Drawing.Color.YellowGreen;
            this.button_non.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_non.ForeColor = System.Drawing.Color.DarkGreen;
            this.button_non.Location = new System.Drawing.Point(167, 258);
            this.button_non.Name = "button_non";
            this.button_non.Size = new System.Drawing.Size(71, 36);
            this.button_non.TabIndex = 3;
            this.button_non.Text = "NON";
            this.button_non.UseVisualStyleBackColor = false;
            this.button_non.Click += new System.EventHandler(this.button_non_Click);
            this.button_non.MouseHover += new System.EventHandler(this.button_non_MouseHover);
            // 
            // Form_mechant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(318, 313);
            this.Controls.Add(this.button_non);
            this.Controls.Add(this.button_oui);
            this.Controls.Add(this.label_question);
            this.Controls.Add(this.pictureBox_cuteAnime);
            this.Name = "Form_mechant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Méchant ou Pas xD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cuteAnime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.PictureBox pictureBox_cuteAnime;
        private System.Windows.Forms.Button button_oui;
        private System.Windows.Forms.Button button_non;
    }
}

