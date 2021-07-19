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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            
            if (button2.Location == new Point(147,34))
            { button2.Location = new Point(147,100); }
            else
                button2.Location = new Point(147,34);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lah ya3fo 3lik", "!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        

        
        

       

        

        
    }
}
