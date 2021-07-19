namespace Commande_et_Manipulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.listBox_stock = new System.Windows.Forms.ListBox();
            this.listBox_panier = new System.Windows.Forms.ListBox();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right_all = new System.Windows.Forms.Button();
            this.button_left_all = new System.Windows.Forms.Button();
            this.button_stock_up = new System.Windows.Forms.Button();
            this.button_stock_down = new System.Windows.Forms.Button();
            this.button_panier_up = new System.Windows.Forms.Button();
            this.button_panier_down = new System.Windows.Forms.Button();
            this.button_stock_AZ = new System.Windows.Forms.Button();
            this.button_stock_ZA = new System.Windows.Forms.Button();
            this.button_panier_AZ = new System.Windows.Forms.Button();
            this.button_panier_ZA = new System.Windows.Forms.Button();
            this.button_commander = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.textBox_panier = new System.Windows.Forms.TextBox();
            this.groupBox_commande = new System.Windows.Forms.GroupBox();
            this.richTextBox_commande = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_commande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_stock
            // 
            this.listBox_stock.BackColor = System.Drawing.Color.LightGray;
            this.listBox_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_stock.FormattingEnabled = true;
            this.listBox_stock.Items.AddRange(new object[] {
            "Réchaud",
            "Barbecue",
            "Bouilloire",
            "Bouteille de gaz",
            "Jerrycan",
            "Sceau",
            "Charbon de bois",
            "Evier",
            "Casserole",
            "Poêle ",
            "Cafetière",
            "Théière",
            "Eponge",
            "Brosse à vaisselle",
            "Couvercle de casserole",
            "Assiette",
            "Couvert",
            "Verre",
            "Couteau à pain",
            "Couteau à viande",
            "Planche à découper",
            "Sac à poubelle",
            "Sopalin",
            "Sucre",
            "Thé",
            "Café",
            "Ouvre bouteille",
            "Allumettes",
            "Verre mesure",
            "Glacières",
            "Egouttoir",
            "Packs de glace",
            "Serviette"});
            this.listBox_stock.Location = new System.Drawing.Point(12, 38);
            this.listBox_stock.Name = "listBox_stock";
            this.listBox_stock.Size = new System.Drawing.Size(120, 158);
            this.listBox_stock.TabIndex = 0;
            this.listBox_stock.SelectedIndexChanged += new System.EventHandler(this.listBox_stock_SelectedIndexChanged);
            // 
            // listBox_panier
            // 
            this.listBox_panier.BackColor = System.Drawing.Color.LightGray;
            this.listBox_panier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_panier.FormattingEnabled = true;
            this.listBox_panier.Location = new System.Drawing.Point(215, 38);
            this.listBox_panier.Name = "listBox_panier";
            this.listBox_panier.Size = new System.Drawing.Size(120, 158);
            this.listBox_panier.TabIndex = 1;
            this.listBox_panier.SelectedIndexChanged += new System.EventHandler(this.listBox_panier_SelectedIndexChanged);
            // 
            // button_right
            // 
            this.button_right.BackColor = System.Drawing.Color.DimGray;
            this.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_right.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_right.ForeColor = System.Drawing.Color.White;
            this.button_right.Location = new System.Drawing.Point(156, 33);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(39, 33);
            this.button_right.TabIndex = 2;
            this.button_right.Text = ">";
            this.button_right.UseVisualStyleBackColor = false;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.BackColor = System.Drawing.Color.DimGray;
            this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_left.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_left.ForeColor = System.Drawing.Color.White;
            this.button_left.Location = new System.Drawing.Point(156, 69);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(39, 33);
            this.button_left.TabIndex = 2;
            this.button_left.Text = "<";
            this.button_left.UseVisualStyleBackColor = false;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right_all
            // 
            this.button_right_all.BackColor = System.Drawing.Color.DimGray;
            this.button_right_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_right_all.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_right_all.ForeColor = System.Drawing.Color.White;
            this.button_right_all.Location = new System.Drawing.Point(156, 108);
            this.button_right_all.Name = "button_right_all";
            this.button_right_all.Size = new System.Drawing.Size(39, 33);
            this.button_right_all.TabIndex = 2;
            this.button_right_all.Text = ">>";
            this.button_right_all.UseVisualStyleBackColor = false;
            this.button_right_all.Click += new System.EventHandler(this.button_right_all_Click);
            // 
            // button_left_all
            // 
            this.button_left_all.BackColor = System.Drawing.Color.DimGray;
            this.button_left_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_left_all.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_left_all.ForeColor = System.Drawing.Color.White;
            this.button_left_all.Location = new System.Drawing.Point(156, 147);
            this.button_left_all.Name = "button_left_all";
            this.button_left_all.Size = new System.Drawing.Size(39, 33);
            this.button_left_all.TabIndex = 2;
            this.button_left_all.Text = "<<";
            this.button_left_all.UseVisualStyleBackColor = false;
            this.button_left_all.Click += new System.EventHandler(this.button_left_all_Click);
            // 
            // button_stock_up
            // 
            this.button_stock_up.BackColor = System.Drawing.Color.DimGray;
            this.button_stock_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stock_up.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stock_up.ForeColor = System.Drawing.Color.White;
            this.button_stock_up.Location = new System.Drawing.Point(12, 202);
            this.button_stock_up.Name = "button_stock_up";
            this.button_stock_up.Size = new System.Drawing.Size(39, 33);
            this.button_stock_up.TabIndex = 2;
            this.button_stock_up.Text = "˄";
            this.button_stock_up.UseVisualStyleBackColor = false;
            this.button_stock_up.Click += new System.EventHandler(this.button_stock_up_Click);
            // 
            // button_stock_down
            // 
            this.button_stock_down.BackColor = System.Drawing.Color.DimGray;
            this.button_stock_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stock_down.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stock_down.ForeColor = System.Drawing.Color.White;
            this.button_stock_down.Location = new System.Drawing.Point(57, 202);
            this.button_stock_down.Name = "button_stock_down";
            this.button_stock_down.Size = new System.Drawing.Size(39, 33);
            this.button_stock_down.TabIndex = 2;
            this.button_stock_down.Text = "˅";
            this.button_stock_down.UseVisualStyleBackColor = false;
            this.button_stock_down.Click += new System.EventHandler(this.button_stock_down_Click);
            // 
            // button_panier_up
            // 
            this.button_panier_up.BackColor = System.Drawing.Color.DimGray;
            this.button_panier_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_panier_up.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_panier_up.ForeColor = System.Drawing.Color.White;
            this.button_panier_up.Location = new System.Drawing.Point(251, 202);
            this.button_panier_up.Name = "button_panier_up";
            this.button_panier_up.Size = new System.Drawing.Size(39, 33);
            this.button_panier_up.TabIndex = 2;
            this.button_panier_up.Text = "˄";
            this.button_panier_up.UseVisualStyleBackColor = false;
            this.button_panier_up.Click += new System.EventHandler(this.button_panier_up_Click);
            // 
            // button_panier_down
            // 
            this.button_panier_down.BackColor = System.Drawing.Color.DimGray;
            this.button_panier_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_panier_down.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_panier_down.ForeColor = System.Drawing.Color.White;
            this.button_panier_down.Location = new System.Drawing.Point(296, 202);
            this.button_panier_down.Name = "button_panier_down";
            this.button_panier_down.Size = new System.Drawing.Size(39, 33);
            this.button_panier_down.TabIndex = 2;
            this.button_panier_down.Text = "˅";
            this.button_panier_down.UseVisualStyleBackColor = false;
            this.button_panier_down.Click += new System.EventHandler(this.button_panier_down_Click);
            // 
            // button_stock_AZ
            // 
            this.button_stock_AZ.BackColor = System.Drawing.Color.DimGray;
            this.button_stock_AZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stock_AZ.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stock_AZ.ForeColor = System.Drawing.Color.White;
            this.button_stock_AZ.Location = new System.Drawing.Point(12, 241);
            this.button_stock_AZ.Name = "button_stock_AZ";
            this.button_stock_AZ.Size = new System.Drawing.Size(39, 33);
            this.button_stock_AZ.TabIndex = 2;
            this.button_stock_AZ.Text = "A-Z";
            this.button_stock_AZ.UseVisualStyleBackColor = false;
            this.button_stock_AZ.Click += new System.EventHandler(this.button_stock_AZ_Click);
            // 
            // button_stock_ZA
            // 
            this.button_stock_ZA.BackColor = System.Drawing.Color.DimGray;
            this.button_stock_ZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stock_ZA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stock_ZA.ForeColor = System.Drawing.Color.White;
            this.button_stock_ZA.Location = new System.Drawing.Point(57, 241);
            this.button_stock_ZA.Name = "button_stock_ZA";
            this.button_stock_ZA.Size = new System.Drawing.Size(39, 33);
            this.button_stock_ZA.TabIndex = 2;
            this.button_stock_ZA.Text = "Z-A";
            this.button_stock_ZA.UseVisualStyleBackColor = false;
            this.button_stock_ZA.Click += new System.EventHandler(this.button_stock_ZA_Click);
            // 
            // button_panier_AZ
            // 
            this.button_panier_AZ.BackColor = System.Drawing.Color.DimGray;
            this.button_panier_AZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_panier_AZ.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_panier_AZ.ForeColor = System.Drawing.Color.White;
            this.button_panier_AZ.Location = new System.Drawing.Point(251, 241);
            this.button_panier_AZ.Name = "button_panier_AZ";
            this.button_panier_AZ.Size = new System.Drawing.Size(39, 33);
            this.button_panier_AZ.TabIndex = 2;
            this.button_panier_AZ.Text = "A-Z";
            this.button_panier_AZ.UseVisualStyleBackColor = false;
            this.button_panier_AZ.Click += new System.EventHandler(this.button_panier_AZ_Click);
            // 
            // button_panier_ZA
            // 
            this.button_panier_ZA.BackColor = System.Drawing.Color.DimGray;
            this.button_panier_ZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_panier_ZA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_panier_ZA.ForeColor = System.Drawing.Color.White;
            this.button_panier_ZA.Location = new System.Drawing.Point(296, 241);
            this.button_panier_ZA.Name = "button_panier_ZA";
            this.button_panier_ZA.Size = new System.Drawing.Size(39, 33);
            this.button_panier_ZA.TabIndex = 2;
            this.button_panier_ZA.Text = "Z-A";
            this.button_panier_ZA.UseVisualStyleBackColor = false;
            this.button_panier_ZA.Click += new System.EventHandler(this.button_panier_ZA_Click);
            // 
            // button_commander
            // 
            this.button_commander.BackColor = System.Drawing.Color.DimGray;
            this.button_commander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_commander.ForeColor = System.Drawing.Color.White;
            this.button_commander.Location = new System.Drawing.Point(351, 30);
            this.button_commander.Name = "button_commander";
            this.button_commander.Size = new System.Drawing.Size(179, 36);
            this.button_commander.TabIndex = 3;
            this.button_commander.Text = "Commander";
            this.button_commander.UseVisualStyleBackColor = false;
            this.button_commander.Click += new System.EventHandler(this.button_commander_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Panier";
            // 
            // textBox_stock
            // 
            this.textBox_stock.BackColor = System.Drawing.Color.LightGray;
            this.textBox_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_stock.Location = new System.Drawing.Point(12, 15);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.ReadOnly = true;
            this.textBox_stock.Size = new System.Drawing.Size(46, 20);
            this.textBox_stock.TabIndex = 6;
            // 
            // textBox_panier
            // 
            this.textBox_panier.BackColor = System.Drawing.Color.LightGray;
            this.textBox_panier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_panier.Location = new System.Drawing.Point(215, 15);
            this.textBox_panier.Name = "textBox_panier";
            this.textBox_panier.ReadOnly = true;
            this.textBox_panier.Size = new System.Drawing.Size(46, 20);
            this.textBox_panier.TabIndex = 9;
            // 
            // groupBox_commande
            // 
            this.groupBox_commande.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_commande.Controls.Add(this.richTextBox_commande);
            this.groupBox_commande.ForeColor = System.Drawing.Color.White;
            this.groupBox_commande.Location = new System.Drawing.Point(351, 80);
            this.groupBox_commande.Name = "groupBox_commande";
            this.groupBox_commande.Size = new System.Drawing.Size(179, 194);
            this.groupBox_commande.TabIndex = 10;
            this.groupBox_commande.TabStop = false;
            this.groupBox_commande.Text = "Commande";
            // 
            // richTextBox_commande
            // 
            this.richTextBox_commande.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox_commande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_commande.Location = new System.Drawing.Point(15, 19);
            this.richTextBox_commande.Name = "richTextBox_commande";
            this.richTextBox_commande.Size = new System.Drawing.Size(148, 161);
            this.richTextBox_commande.TabIndex = 0;
            this.richTextBox_commande.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Commande_et_Manipulation.Properties.Resources.www_tec4n_net__166_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(118, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 104);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Commande_et_Manipulation.Properties.Resources.pict120277;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 296);
            this.Controls.Add(this.groupBox_commande);
            this.Controls.Add(this.textBox_panier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.button_commander);
            this.Controls.Add(this.button_panier_down);
            this.Controls.Add(this.button_panier_up);
            this.Controls.Add(this.button_stock_down);
            this.Controls.Add(this.button_panier_ZA);
            this.Controls.Add(this.button_panier_AZ);
            this.Controls.Add(this.button_stock_ZA);
            this.Controls.Add(this.button_stock_AZ);
            this.Controls.Add(this.button_stock_up);
            this.Controls.Add(this.button_left_all);
            this.Controls.Add(this.button_right_all);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.listBox_panier);
            this.Controls.Add(this.listBox_stock);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commander des Produits";
            this.groupBox_commande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_stock;
        private System.Windows.Forms.ListBox listBox_panier;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right_all;
        private System.Windows.Forms.Button button_left_all;
        private System.Windows.Forms.Button button_stock_up;
        private System.Windows.Forms.Button button_stock_down;
        private System.Windows.Forms.Button button_panier_up;
        private System.Windows.Forms.Button button_panier_down;
        private System.Windows.Forms.Button button_stock_AZ;
        private System.Windows.Forms.Button button_stock_ZA;
        private System.Windows.Forms.Button button_panier_AZ;
        private System.Windows.Forms.Button button_panier_ZA;
        private System.Windows.Forms.Button button_commander;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.TextBox textBox_panier;
        private System.Windows.Forms.GroupBox groupBox_commande;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox_commande;
    }
}

