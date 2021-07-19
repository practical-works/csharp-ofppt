using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_12
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s="";
            for(int i=0;i<checkedListBox1.CheckedItems.Count;i++)
            {
              
                    s=s+checkedListBox1.CheckedItems[i].ToString()+Environment.NewLine;

            }
            MessageBox.Show(s);

        }

        
    }
}
