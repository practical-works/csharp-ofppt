namespace A
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.progressBar_time = new System.Windows.Forms.ProgressBar();
            this.button_connect = new System.Windows.Forms.Button();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.Color.Silver;
            this.textBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_login.Location = new System.Drawing.Point(96, 10);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(225, 20);
            this.textBox_login.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.Silver;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Location = new System.Drawing.Point(96, 36);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(225, 20);
            this.textBox_password.TabIndex = 3;
            // 
            // progressBar_time
            // 
            this.progressBar_time.BackColor = System.Drawing.Color.Silver;
            this.progressBar_time.ForeColor = System.Drawing.Color.Red;
            this.progressBar_time.Location = new System.Drawing.Point(96, 65);
            this.progressBar_time.Maximum = 10;
            this.progressBar_time.Name = "progressBar_time";
            this.progressBar_time.Size = new System.Drawing.Size(144, 23);
            this.progressBar_time.Step = 1;
            this.progressBar_time.TabIndex = 4;
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.Color.Silver;
            this.button_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connect.Location = new System.Drawing.Point(246, 65);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 5;
            this.button_connect.Text = "Connexion";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // timer_time
            // 
            this.timer_time.Interval = 1000;
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.button_connect);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.progressBar_time);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.textBox_password);
            this.panel_main.Controls.Add(this.textBox_login);
            this.panel_main.Location = new System.Drawing.Point(13, 11);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(349, 100);
            this.panel_main.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(374, 123);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.ProgressBar progressBar_time;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.Panel panel_main;
    }
}

