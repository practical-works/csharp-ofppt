using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_4
{
    public partial class Form1 : Form
    {
        string m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Entrez votre Nom et Prenom svp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                    MessageBox.Show("Précisez votre sexe svp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (radioButton3.Checked == false && radioButton4.Checked == false)
                    MessageBox.Show("Précisez votre situation familiale  svp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        if (radioButton3.Checked == true || radioButton4.Checked == true)
                            m = "Mr";
                    }
                    if (radioButton2.Checked == true)
                    {
                        if (radioButton3.Checked == true)
                            m = "Mlle";
                        if (radioButton4.Checked == true)
                            m = "Mme";
                    }
                    MessageBox.Show("Bienvenue " + m +" "+ textBox1.Text);

                }
                



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}