using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Column1", "Test");
            dataGridView1.Rows.Add(7);
            dataGridView1.Rows[0].Cells[0].Value = "hi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.RemoveAt(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
