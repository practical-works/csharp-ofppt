using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Authentification
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            button_connect.Enabled = false;
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            timer_délai.Interval = 10000;
            timer_délai.Start();
        }

        private void timer_délai_Tick(object sender, EventArgs e)
        {
            timer_délai.Stop();
            MessageBox.Show("Temp épuisé!","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            Close();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            string id = "abb", pass = "abb123";
            if (textBox_id.Text != id)
            {
                MessageBox.Show("Identificacteur incorrecte!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_pass.Text != pass)
            {
                MessageBox.Show("Mot de passe incorrect!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  // Mot de passe correcte
            {
                timer_délai.Stop();
                MessageBox.Show("Bienvenue!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //*******************************************
                Hide();
                Form_main FormMain = new Form_main();
                FormMain.Show();
            }
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_id.Text) || string.IsNullOrWhiteSpace(textBox_pass.Text))
            {
                button_connect.Enabled = false;
            }
            else
            {
                button_connect.Enabled = true;
            }
        }

        private void textBox_pass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_pass.Text) || string.IsNullOrWhiteSpace(textBox_id.Text))
            {
                button_connect.Enabled = false;
            }
            else
            {
                button_connect.Enabled = true;
            }
        }
    }
}
