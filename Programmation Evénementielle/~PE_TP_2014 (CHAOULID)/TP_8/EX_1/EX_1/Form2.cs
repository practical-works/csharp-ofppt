using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
            f.dataGridView1.DataSource = Program.T;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            ArrayList l=new ArrayList();
            
            if (textBox1.Text == "")
                MessageBox.Show("Entrez le nom à rechercher svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool m = false;
               
                {
                     foreach(Article a in Program.T)

                     {
                        if (a.Nom == textBox1.Text)
                        {
                            m = true;
                            l.Add(a);
                           
                        }
                    }
                    if (m == false)
                        MessageBox.Show("Ce nom n'existe pas", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = l;
                    }
                }
 
            }
        }
    }
}
