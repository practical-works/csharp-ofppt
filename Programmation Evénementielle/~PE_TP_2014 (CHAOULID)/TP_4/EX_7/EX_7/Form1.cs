using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  int i;
        bool r = false; bool j = false;
            
            for (i = 0; i < listBox1.Items.Count; i++)
                {
                    if ((listBox1.Items[i].ToString())!= "")
                    { r = true; break; }
                }
                if (r ==false)
                   MessageBox.Show("La liste est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
                            
           else if (textBox1.Text == "")
                MessageBox.Show("Entrez la ville que vous voulez rechercher", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            
            else
            {

                for (i = 0; i < listBox1.Items.Count; i++)
                {
                    if ((listBox1.Items[i].ToString().ToLower()) == textBox1.Text.ToLower())
                    { j = true; break; }
                }
                if (j == true)
                    listBox1.SelectedIndex = i;
                else 
                    MessageBox.Show("cette ville ne se trouve pas dans la liste", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Entrez la ville que vous voulez ajouter à la liste", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            { listBox1.Items.Add(textBox1.Text); textBox1.Text = ""; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            int i; bool r = false;
            for (i = 0; i < listBox1.Items.Count; i++)
            {
                if ((listBox1.Items[i].ToString()) != "")
                { r = true; break; }
            }
            if (r == false)
                MessageBox.Show("La liste est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
           else if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Séléctionner la ville que vous voulez supprimer", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                textBox1.Text = listBox1.Text.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int p = listBox1.FindStringExact(textBox1.Text);
            MessageBox.Show(p.ToString());
        }

        
    }
}
