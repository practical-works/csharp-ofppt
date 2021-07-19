using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in this.groupBox1.Controls)
                c.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in this.groupBox1.Controls)
                c.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                listBox1.Items.Add(checkBox1.Text);
            else
                listBox1.Items.Remove(checkBox1.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                listBox1.Items.Add(checkBox2.Text);
            else
                listBox1.Items.Remove(checkBox2.Text);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                listBox1.Items.Add(checkBox3.Text);
            else
                listBox1.Items.Remove(checkBox3.Text);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                listBox1.Items.Add(checkBox4.Text);
            else
                listBox1.Items.Remove(checkBox4.Text);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                listBox1.Items.Add(checkBox5.Text);
            else
                listBox1.Items.Remove(checkBox5.Text);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
                listBox1.Items.Add(checkBox6.Text);
            else
                listBox1.Items.Remove(checkBox6.Text);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
                listBox1.Items.Add(checkBox7.Text);
            else
                listBox1.Items.Remove(checkBox7.Text);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
                listBox1.Items.Add(checkBox8.Text);
            else
                listBox1.Items.Remove(checkBox8.Text);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
                listBox1.Items.Add(checkBox9.Text);
            else
                listBox1.Items.Remove(checkBox9.Text);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
                listBox1.Items.Add(checkBox10.Text);
            else
                listBox1.Items.Remove(checkBox10.Text);
        }

        

        
       

        
        

        

        

        

        
       

        

        

        

        
       

        

        

        
        
    }
}
