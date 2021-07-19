using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_3
{
    public partial class Form1 : Form
    {
        int s = 0, m = 0, h = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            //string s;int v = DateTime.Now.Second;
            //if(v<10)
            //    s="0";
            //else
            //    s="";
            //string m; int k = DateTime.Now.Minute;
            //if (k< 10)
            //    m = "0";
            //else
            //    m = "";
            //string h; int u = DateTime.Now.Hour;
            //if (u < 10)
            //    h= "0";
            //else
            //    h = "";
            //label1.Text =h+ DateTime.Now.Hour+":"+m+DateTime.Now.Minute+":"+s+DateTime.Now.Second.ToString();

            label1.Text = DateTime.Now.ToLongTimeString();

        }

        
        

       

        
    }
}
