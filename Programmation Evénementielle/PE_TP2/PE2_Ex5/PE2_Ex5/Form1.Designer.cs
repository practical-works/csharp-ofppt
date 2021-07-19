namespace PE2_Ex5
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
            this.label_question = new System.Windows.Forms.Label();
            this.groupBox_loisirs = new System.Windows.Forms.GroupBox();
            this.checkBox_internet = new System.Windows.Forms.CheckBox();
            this.checkBox_voyage = new System.Windows.Forms.CheckBox();
            this.checkBox_lecture = new System.Windows.Forms.CheckBox();
            this.checkBox_sport = new System.Windows.Forms.CheckBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_loisirs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label_question.Location = new System.Drawing.Point(12, 9);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(138, 13);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "Quelle sont vos loisirs ?";
            // 
            // groupBox_loisirs
            // 
            this.groupBox_loisirs.BackColor = System.Drawing.Color.Thistle;
            this.groupBox_loisirs.Controls.Add(this.button1);
            this.groupBox_loisirs.Controls.Add(this.checkBox_internet);
            this.groupBox_loisirs.Controls.Add(this.checkBox_voyage);
            this.groupBox_loisirs.Controls.Add(this.checkBox_lecture);
            this.groupBox_loisirs.Controls.Add(this.checkBox_sport);
            this.groupBox_loisirs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_loisirs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_loisirs.Location = new System.Drawing.Point(15, 38);
            this.groupBox_loisirs.Name = "groupBox_loisirs";
            this.groupBox_loisirs.Size = new System.Drawing.Size(200, 122);
            this.groupBox_loisirs.TabIndex = 1;
            this.groupBox_loisirs.TabStop = false;
            this.groupBox_loisirs.Text = "Loisirs";
            // 
            // checkBox_internet
            // 
            this.checkBox_internet.AutoSize = true;
            this.checkBox_internet.Location = new System.Drawing.Point(17, 89);
            this.checkBox_internet.Name = "checkBox_internet";
            this.checkBox_internet.Size = new System.Drawing.Size(74, 17);
            this.checkBox_internet.TabIndex = 3;
            this.checkBox_internet.Text = "Internet";
            this.checkBox_internet.UseVisualStyleBackColor = true;
            // 
            // checkBox_voyage
            // 
            this.checkBox_voyage.AutoSize = true;
            this.checkBox_voyage.Location = new System.Drawing.Point(17, 66);
            this.checkBox_voyage.Name = "checkBox_voyage";
            this.checkBox_voyage.Size = new System.Drawing.Size(68, 17);
            this.checkBox_voyage.TabIndex = 2;
            this.checkBox_voyage.Text = "Voyage";
            this.checkBox_voyage.UseVisualStyleBackColor = true;
            // 
            // checkBox_lecture
            // 
            this.checkBox_lecture.AutoSize = true;
            this.checkBox_lecture.Location = new System.Drawing.Point(17, 43);
            this.checkBox_lecture.Name = "checkBox_lecture";
            this.checkBox_lecture.Size = new System.Drawing.Size(69, 17);
            this.checkBox_lecture.TabIndex = 1;
            this.checkBox_lecture.Text = "Lecture";
            this.checkBox_lecture.UseVisualStyleBackColor = true;
            // 
            // checkBox_sport
            // 
            this.checkBox_sport.AutoSize = true;
            this.checkBox_sport.Location = new System.Drawing.Point(17, 20);
            this.checkBox_sport.Name = "checkBox_sport";
            this.checkBox_sport.Size = new System.Drawing.Size(57, 17);
            this.checkBox_sport.TabIndex = 0;
            this.checkBox_sport.Text = "Sport";
            this.checkBox_sport.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.DeepPink;
            this.button_OK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(140, 166);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(234, 204);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox_loisirs);
            this.Controls.Add(this.label_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loisirs";
            this.groupBox_loisirs.ResumeLayout(false);
            this.groupBox_loisirs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.GroupBox groupBox_loisirs;
        private System.Windows.Forms.CheckBox checkBox_internet;
        private System.Windows.Forms.CheckBox checkBox_voyage;
        private System.Windows.Forms.CheckBox checkBox_lecture;
        private System.Windows.Forms.CheckBox checkBox_sport;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button1;
    }
}

