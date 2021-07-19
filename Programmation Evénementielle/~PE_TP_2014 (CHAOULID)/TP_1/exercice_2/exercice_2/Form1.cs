using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exercice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "afficher")
            {
                
                label1.Text = "bienvenue dans notre application";
                button1.Text = "effacer";
            }
            else
            {
                label1.Text = "";
                button1.Text = "afficher";
            }
            

            
 
 
         }

        

        
        
        

       
       
       
        
    }
}
