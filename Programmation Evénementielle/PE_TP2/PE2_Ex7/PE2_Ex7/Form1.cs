using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE2_Ex7
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton_rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_rouge.Checked)
            {
                Form_main.ActiveForm.BackColor = Color.Red;
            }
        }

        private void radioButton_vert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_vert.Checked)
            {
                Form_main.ActiveForm.BackColor = Color.Green;
            }
        }

        private void radioButton_bleu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_bleu.Checked)
            {
                Form_main.ActiveForm.BackColor = Color.Blue;
            }
        }

        private void checkBox_AfficherCouleurs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AfficherCouleurs.Checked)
            {
                Form_main.ActiveForm.Size = new Size(Form_main.ActiveForm.Size.Width, 256);
            }
            else
            {
                Form_main.ActiveForm.Size = new Size(Form_main.ActiveForm.Size.Width, 75);
                Form_main.ActiveForm.BackColor = Form_main.DefaultBackColor;
            }
        }
    }
}
