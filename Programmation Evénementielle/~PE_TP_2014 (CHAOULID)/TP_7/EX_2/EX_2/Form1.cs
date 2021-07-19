using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, c=0;
            dataGridView1.Rows.Clear();
            for (i = 1; i <= numericUpDown1.Value; i++)
            {
                if ((numericUpDown1.Value) % i == 0)
                {
                    dataGridView1.Rows.Add(i.ToString()); 
                    c++;

                    
                }
            }
            int a = dataGridView1.Rows.Count;
            textBox1.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        

        
    }
}
