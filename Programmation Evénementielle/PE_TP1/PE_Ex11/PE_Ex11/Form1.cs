using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_operation.MaxLength = 1;
        }

        private void button_calculer_Click(object sender, EventArgs e)
        {
            label_resultat.ForeColor = DefaultForeColor;
            double num1, num2, result;
            if (double.TryParse(textBox_nombre1.Text,out num1) && double.TryParse(textBox_nombre2.Text,out num2))
            {
                switch (textBox_operation.Text)
                {
                    case "+": result = num1 + num2; label_resultat.Text = result.ToString(); break;
                    case "-": result = num1 - num2; label_resultat.Text = result.ToString(); break;
                    case "*": result = num1 * num2; label_resultat.Text = result.ToString(); break;
                    case "/": result = num1 / num2; label_resultat.Text = result.ToString(); break;
                    case "%": result = num1 % num2; label_resultat.Text = result.ToString(); break;
                    case "^": result = Math.Pow(num1,num2); label_resultat.Text = result.ToString(); break;
                    default: label_resultat.ForeColor = Color.Red; label_resultat.Text = "Opérateur invalide!"; break;
                }
            }
            else
            {
                label_resultat.ForeColor = Color.Red;
                label_resultat.Text = "Nombre invalide!";
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void textBox_nombre1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_nombre1.Text) && !string.IsNullOrWhiteSpace(textBox_nombre2.Text))
            {
                button_calculer.Enabled = true;
            }
            else
            {
                button_calculer.Enabled = false;
            }
        }

        private void textBox_nombre2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_nombre1.Text) && !string.IsNullOrWhiteSpace(textBox_nombre2.Text))
            {
                button_calculer.Enabled = true;
            }
            else
            {
                button_calculer.Enabled = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox_operation_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
