namespace Authentification
{
    partial class Form_login
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
            this.timer_délai = new System.Windows.Forms.Timer(this.components);
            this.label_id = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer_délai
            // 
            this.timer_délai.Tick += new System.EventHandler(this.timer_délai_Tick);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(23, 20);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(57, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Identifiant";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(23, 59);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(71, 13);
            this.label_pass.TabIndex = 1;
            this.label_pass.Text = "Mot de passe";
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Location = new System.Drawing.Point(26, 36);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(141, 20);
            this.textBox_id.TabIndex = 2;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // textBox_pass
            // 
            this.textBox_pass.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pass.Location = new System.Drawing.Point(26, 75);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '●';
            this.textBox_pass.Size = new System.Drawing.Size(141, 20);
            this.textBox_pass.TabIndex = 3;
            this.textBox_pass.TextChanged += new System.EventHandler(this.textBox_pass_TextChanged);
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.Color.Silver;
            this.button_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connect.Location = new System.Drawing.Point(26, 126);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(141, 23);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "Connexion";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // Form_login
            // 
            this.AcceptButton = this.button_connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(191, 168);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_délai;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_connect;
    }
}

