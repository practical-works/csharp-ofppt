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
        int c = 0,v=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); radioButton1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = true;
                this.BackColor = Color.Green;
            }

            else if (radioButton2.Checked == true)
            {
                radioButton3.Checked = true;
                this.BackColor = Color.Blue;
            }

            else if (radioButton3.Checked == true)
            { 
                radioButton1.Checked = true; 
                this.BackColor = Color.Red; 
            }
                                             
            }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 1001 - trackBar1.Value;
        }

        


          
            
                  
        }

        

        

        
            
    }

