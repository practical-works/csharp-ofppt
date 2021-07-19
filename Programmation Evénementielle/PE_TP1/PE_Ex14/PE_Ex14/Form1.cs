using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex14
{
    public partial class Form_Principale : Form
    {
        public Form_Principale()
        {
            InitializeComponent();
        }

        private void button_inverser_Click(object sender, EventArgs e)
        {
            string original_text = richTextBox_original.Text;
            int N = original_text.Length;
            string inverted_text = string.Empty;

            for (int i = 0; i < N; i++)
            {
                inverted_text += original_text[N - i - 1];
            }
            
            richTextBox_inversé.Text = inverted_text;
        }

        private void button_sans_Click(object sender, EventArgs e)
        {
            if (button_inverser.Enabled == true)
            {
                button_sans.Text = "Avec Button";
                button_inverser.Enabled = false;
            }
            else
            {
                button_sans.Text = "Sans Button";
                button_inverser.Enabled = true;
            }                                   
        }

        private void richTextBox_original_TextChanged(object sender, EventArgs e)
        {
            if (button_inverser.Enabled == false)
            {
                string original_text = richTextBox_original.Text;
                int N = original_text.Length;
                string inverted_text = string.Empty;

                for (int i = 0; i < N; i++)
                {
                    inverted_text += original_text[N - i - 1];
                }
            
                richTextBox_inversé.Text = inverted_text;
            }
        }
    }
}
