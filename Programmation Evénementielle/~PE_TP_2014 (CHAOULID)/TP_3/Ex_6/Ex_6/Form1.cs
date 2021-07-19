using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_6
{
    public partial class Form1 : Form
    {   
        int i = 0;
        string a, b, c, d,m; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false))

                MessageBox.Show("Vous n'avez pas des loisires ?", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                a = "";
                foreach (CheckBox c in this.panel1.Controls)
                    if(c.Checked==true)
                    a = a + c.Text+" , ";
                MessageBox.Show(a, "", MessageBoxButtons.OK);
            }
            
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                i++;
            else
                i--;              
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                i++;
            else
                i--;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                i++;
            else
                i--;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                i++;
            else
                i--;
        }

        

       

        
    }
}
