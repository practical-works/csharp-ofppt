using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Value.ToShortDateString(); 
            s = dateTimePicker1.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString();
            textBox2.Text = dateTimePicker1.Value.Date.ToString();
            textBox3.Text = DateTime.Now.ToLongTimeString();//dateTimePicker1.Value.timeofday.ToString();
            textBox4.Text = dateTimePicker1.Value.ToShortDateString();
            textBox5.Text = dateTimePicker1.Value.ToLongDateString();
            textBox6.Text = dateTimePicker1.Value.Day.ToString();
            textBox7.Text = dateTimePicker1.Value.Month.ToString();
            textBox8.Text = dateTimePicker1.Value.Year.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = s;

            textBox1.Text = dateTimePicker1.Value.ToString();
            textBox2.Text = dateTimePicker1.Value.Date.ToString();
            textBox3.Text = DateTime.Now.ToLongTimeString();
            textBox4.Text = dateTimePicker1.Value.ToShortDateString();
            textBox5.Text = dateTimePicker1.Text.ToString();
            textBox6.Text = dateTimePicker1.Value.Day.ToString();
            textBox7.Text = dateTimePicker1.Value.Month.ToString();
            textBox8.Text = dateTimePicker1.Value.Year.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToLongTimeString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        

    }
}
