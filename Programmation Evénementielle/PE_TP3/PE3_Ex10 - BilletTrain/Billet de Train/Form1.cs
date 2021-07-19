using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Billet_de_Train
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            listBox_typebillet.SelectedIndex = 0;
            comboBox_reduction.SelectedIndex = 0;
            textBox_prixbase.Select();
        }

        private void button_calculer_Click(object sender, EventArgs e)
        {
            SFX.metal_hit.Play();
            double prixbase=0, prixHT=0, TVA=20, prixTCC=0;
            if (double.TryParse(textBox_prixbase.Text, out prixbase))
            {
                if (prixbase < 0)
                {
                    ToolTip ValueError = new ToolTip();
                    ValueError.ToolTipTitle = "Attention";
                    ValueError.ToolTipIcon = ToolTipIcon.Warning;
                    ValueError.Show("Le prix doit être un nombre positif!", textBox_prixbase, 2000);
                    prixbase = -prixbase;
                    textBox_prixbase.Text = prixbase.ToString();
                    textBox_prixbase.Select(textBox_prixbase.TextLength, textBox_prixbase.TextLength);
                }

                if (listBox_typebillet.SelectedIndex == 0) prixHT = prixbase + (0.2 * prixbase);
                else if (listBox_typebillet.SelectedIndex == 1) prixHT = prixbase;

                switch (comboBox_reduction.SelectedIndex)
                {
                    case 1: prixHT -= 0.4 * prixHT; break;
                    case 2: prixHT -= 0.3 * prixHT; break;
                    case 3: prixHT -= 0.5 * prixHT; break;
                    default:
                        break;
                }

                prixTCC = prixHT + (TVA/100)*prixHT;

                textBox_prixHT.Text = prixHT.ToString();
                textBox_TVA.Text = TVA.ToString();
                textBox_prixTTC.Text = prixTCC.ToString();

            } else
	        {
                SFX.bingbing.Play();
                ToolTip ParseError = new ToolTip();
                ParseError.ToolTipTitle = "Erreur";
                ParseError.ToolTipIcon = ToolTipIcon.Error;
                ParseError.Show("Données invalides!", textBox_prixbase,2000);
                textBox_prixbase.SelectAll();
        	}


        }

        private void button_reinitialiser_Click(object sender, EventArgs e)
        {
            SFX.toot.Play();
            textBox_prixbase.Text = "0";
            textBox_prixHT.Text = "0";
            textBox_TVA.Text = "0";
            textBox_prixTTC.Text = "0";
            listBox_typebillet.SelectedIndex = 0;
            comboBox_reduction.SelectedIndex = 0;
            textBox_prixbase.Select();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            SFX.train_crossing.Play();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SFX.train_crossing.Play();
            DialogResult ExitConfirm = new DialogResult();
            ExitConfirm = MessageBox.Show("Voulez-vous quitter ?","Fermeture",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ExitConfirm == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
