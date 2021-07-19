namespace PE8_GestionTV.Consultations
{
    partial class FormStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStats));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_totalTous = new System.Windows.Forms.TextBox();
            this.textBox_totalType = new System.Windows.Forms.TextBox();
            this.textBox_pourcentage = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type de l\'émission:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Durée totale de toutes les émissions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Durée totale du type d\'émissions choisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pourcentage de la durée du type choisi::";
            // 
            // textBox_totalTous
            // 
            this.textBox_totalTous.Location = new System.Drawing.Point(249, 85);
            this.textBox_totalTous.Name = "textBox_totalTous";
            this.textBox_totalTous.ReadOnly = true;
            this.textBox_totalTous.Size = new System.Drawing.Size(121, 20);
            this.textBox_totalTous.TabIndex = 1;
            // 
            // textBox_totalType
            // 
            this.textBox_totalType.Location = new System.Drawing.Point(249, 122);
            this.textBox_totalType.Name = "textBox_totalType";
            this.textBox_totalType.ReadOnly = true;
            this.textBox_totalType.Size = new System.Drawing.Size(121, 20);
            this.textBox_totalType.TabIndex = 1;
            // 
            // textBox_pourcentage
            // 
            this.textBox_pourcentage.Location = new System.Drawing.Point(249, 159);
            this.textBox_pourcentage.Name = "textBox_pourcentage";
            this.textBox_pourcentage.ReadOnly = true;
            this.textBox_pourcentage.Size = new System.Drawing.Size(121, 20);
            this.textBox_pourcentage.TabIndex = 1;
            // 
            // comboBox_type
            // 
            this.comboBox_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(249, 52);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(121, 21);
            this.comboBox_type.TabIndex = 2;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Image = global::PE8_GestionTV.Properties.Resources.statistics;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(96, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "     Statistiques des émissions";
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 200);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.textBox_pourcentage);
            this.Controls.Add(this.textBox_totalType);
            this.Controls.Add(this.textBox_totalTous);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStats_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_totalTous;
        private System.Windows.Forms.TextBox textBox_totalType;
        private System.Windows.Forms.TextBox textBox_pourcentage;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label5;
    }
}