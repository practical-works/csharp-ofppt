using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_5
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                
                s = s + listBox1.SelectedItems[i].ToString() + "\n";//Environment.NewLine;
               
            }
            
            
              MessageBox.Show(s);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode=SelectionMode.MultiSimple;
        }
    }
}
