namespace FicheClient
{
    partial class Form_consultation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_fiche = new System.Windows.Forms.GroupBox();
            this.label_adresse2 = new System.Windows.Forms.Label();
            this.label_adresse1 = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_retour = new System.Windows.Forms.Button();
            this.groupBox_fiche.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiche Client";
            // 
            // groupBox_fiche
            // 
            this.groupBox_fiche.Controls.Add(this.label_adresse2);
            this.groupBox_fiche.Controls.Add(this.label_adresse1);
            this.groupBox_fiche.Controls.Add(this.label_nom);
            this.groupBox_fiche.Controls.Add(this.label4);
            this.groupBox_fiche.Controls.Add(this.label3);
            this.groupBox_fiche.Controls.Add(this.label2);
            this.groupBox_fiche.Location = new System.Drawing.Point(13, 47);
            this.groupBox_fiche.Name = "groupBox_fiche";
            this.groupBox_fiche.Size = new System.Drawing.Size(487, 185);
            this.groupBox_fiche.TabIndex = 1;
            this.groupBox_fiche.TabStop = false;
            // 
            // label_adresse2
            // 
            this.label_adresse2.AutoSize = true;
            this.label_adresse2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adresse2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_adresse2.Location = new System.Drawing.Point(99, 136);
            this.label_adresse2.Name = "label_adresse2";
            this.label_adresse2.Size = new System.Drawing.Size(125, 23);
            this.label_adresse2.TabIndex = 1;
            this.label_adresse2.Text = "_adresse2_";
            // 
            // label_adresse1
            // 
            this.label_adresse1.AutoSize = true;
            this.label_adresse1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adresse1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_adresse1.Location = new System.Drawing.Point(99, 81);
            this.label_adresse1.Name = "label_adresse1";
            this.label_adresse1.Size = new System.Drawing.Size(125, 23);
            this.label_adresse1.TabIndex = 1;
            this.label_adresse1.Text = "_adresse1_";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_nom.Location = new System.Drawing.Point(99, 26);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(77, 23);
            this.label_nom.TabIndex = 1;
            this.label_nom.Text = "_nom_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            // 
            // button_retour
            // 
            this.button_retour.Location = new System.Drawing.Point(413, 242);
            this.button_retour.Name = "button_retour";
            this.button_retour.Size = new System.Drawing.Size(87, 27);
            this.button_retour.TabIndex = 0;
            this.button_retour.Text = "Retour";
            this.button_retour.UseVisualStyleBackColor = true;
            this.button_retour.Click += new System.EventHandler(this.button_retour_Click);
            // 
            // Form_consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 278);
            this.Controls.Add(this.button_retour);
            this.Controls.Add(this.groupBox_fiche);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_consultation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultation";
            this.groupBox_fiche.ResumeLayout(false);
            this.groupBox_fiche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_fiche;
        private System.Windows.Forms.Button button_retour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label_adresse2;
        public System.Windows.Forms.Label label_adresse1;
        public System.Windows.Forms.Label label_nom;
    }
}