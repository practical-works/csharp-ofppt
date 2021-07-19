using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_6
{
    public partial class Form1 : Form
    {
         int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = listBox1.SelectedIndex; string s;
            bool v = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à gauche est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (c == -1)           
                MessageBox.Show("Séléctionner un element svp", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            else
            {
               
                s = listBox1.Items[c].ToString();
                listBox1.Items[c] = listBox1.Items[c - 1];
                listBox1.Items[c - 1] = s;
                listBox1.SelectedIndex = c - 1;
            }
            
               
           
        }



        private void button2_Click(object sender, EventArgs e)
        {

            int c = listBox1.SelectedIndex; string s;
            bool v = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à gauche est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
      
            else if (c == -1)
                MessageBox.Show("Séléctionner un element svp","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                s = listBox1.Items[c].ToString();
                listBox1.Items[c] = listBox1.Items[c +1];
                listBox1.Items[c +1] = s;
                listBox1.SelectedIndex = c + 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool v = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à gauche est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            listBox1.Sorted=true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool v = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à gauche est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                listBox1.Sorted = true; string s; int c = listBox1.Items.Count;
                for (int i = 0; i < c / 2; i++)
                {
                    s = listBox1.Items[i].ToString();
                    listBox1.Items[i] = listBox1.Items[c - 1 - i];
                    listBox1.Items[c - 1 - i] = s;
                }
                listBox1.Sorted = false;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool v = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à gauche est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Séléctionner un element de la liste gauche svp ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else

            {
                listBox2.Items.Add(listBox1.Text);
                listBox1.Items.Remove(listBox1.Text);
            }
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool v = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à gauche est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                for (int j = 0; j < listBox1.Items.Count; j++)
                { listBox2.Items.Add(listBox1.Items[j]); }
                listBox1.Items.Clear();
            }
                    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool v = false;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à droite est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (listBox2.SelectedIndex == -1)
                MessageBox.Show("Séléctionner un element de la liste droite svp", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
     
            else

            {
                listBox1.Items.Add(listBox2.Text);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool v = false;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
             MessageBox.Show("la liste à droite est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int j = 0; j < listBox2.Items.Count; j++)
                { listBox1.Items.Add(listBox2.Items[j]); }
                listBox2.Items.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int c = listBox2.SelectedIndex; string s;

            bool v = false;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à droite est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
         
            else if (c == -1)
                MessageBox.Show("Séléctionner un element de la liste droite  svp", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            else 
            {
                s = listBox2.Items[c].ToString();
                listBox2.Items[c] = listBox2.Items[c - 1];
                listBox2.Items[c - 1] = s;
                listBox2.SelectedIndex = c - 1;

             }

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int c = listBox2.SelectedIndex; string s;
            bool v = false;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à droite est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (c == -1)
                MessageBox.Show("Séléctionner un element de la liste droite svp", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
            {
                s = listBox2.Items[c].ToString();
                listBox2.Items[c] = listBox2.Items[c + 1];
                listBox2.Items[c+1] = s;
                listBox2.SelectedIndex = c + 1;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool v = false;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à droite est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                listBox2.Sorted = false;
                listBox2.Sorted = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool v = false;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString() != "")
                { v = true; break; }
            }
            if (v == false)
                MessageBox.Show("la liste à droite est vide", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                listBox2.Sorted = true; string s; int c = listBox2.Items.Count;
                for (int i = 0; i < c / 2; i++)
                {
                    s = listBox2.Items[i].ToString();
                    listBox2.Items[i] = listBox2.Items[c - 1 - i];
                    listBox2.Items[c - 1 - i] = s;
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            if (a == 0 )

                button1.Enabled = false;
            else
                button1.Enabled = true;
            if (a == listBox1.Items.Count - 1)
                button2.Enabled = false;
            else
                button2.Enabled = true;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = listBox2.SelectedIndex;
            if (a == 0)

                button11.Enabled = false;
            else
                button11.Enabled = true;
            if (a == listBox2.Items.Count - 1)
                button10.Enabled = false;
            else
                button10.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
