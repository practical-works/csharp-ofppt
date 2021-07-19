using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_10
{
    public partial class Form1 : Form
    {
        int p = 0, m = 0, o = 0, e1 = 0, e2 = 0, e3 = 0, e4 = 0, prix; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Select();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                groupBox4.Enabled = true;
            else
            {
                groupBox4.Enabled = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                o = 0;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                p = 800;


            else if (radioButton2.Checked == true)
                p = 1200;


            else if (radioButton3.Checked == true)
                p = 1500;
            else
                p = 0;
            

            if (radioButton4.Checked == true)
            
                m = 400;
           
            
            else if (radioButton5.Checked == true)
            
                m = 800;


            else if (radioButton6.Checked == true)

                m = 1000;
            else
            
                m = 0;
            

           
            
            
            
           if (checkBox1.Checked == true)
                e1 = 60;
           else
                e1= 0;
          
            if (checkBox2.Checked == true)
                 e2 = 80;
            else  
                  e2 = 0;
               
          if (checkBox3.Checked == true)
             e3 = 80;
          else      
              e3 = 0;
                
              if (checkBox4.Checked == true)
                   e4 = 700;
               else
                    e4 = 0;

              if (checkBox5.Checked == true)
              {
                  if (radioButton7.Checked == true)
                      o = 1500;

                  else if (radioButton8.Checked == true)
                      o = 500;
                  else
                      o = 0;
                  
              }
            
            



              prix = p + m + o + e1 + e2 + e3 + e4;



              MessageBox.Show("Le prix que vous devez payez est : " + prix, "", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }
    }
}
                   
                      

              

                     
                
                
                 
                
             

           
             
            
             
            
            

           
            
                
                
                
            
             
            
            
             
            


