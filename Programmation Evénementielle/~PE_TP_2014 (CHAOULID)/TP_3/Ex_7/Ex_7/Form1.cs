using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex_7
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
            {
                c.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in this.groupBox1.Controls)
            {
                c.Checked =false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s="";
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false) &&
                (checkBox5.Checked == false) && (checkBox6.Checked == false) && (checkBox7.Checked == false) && (checkBox8.Checked == false) &&
                (checkBox9.Checked == false) && (checkBox10.Checked == false))
                MessageBox.Show("choisissez une repas svp", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {




                //if (checkBox1.Checked == true)
                //    s = s + checkBox1.Text+"\n";  //c1 = "Appéritif  \n";
                
                //if (checkBox2.Checked == true)
                //    s = s + checkBox2.Text + "\n";// c2 = "Potage  \n";
                
                //if (checkBox3.Checked == true)
                //    s = s + checkBox3.Text + "\n"; //c3 = "Crudités  \n";
                
                //if (checkBox4.Checked == true)
                //    s = s + checkBox4.Text + "\n"; //c4 = "Charcuterie  \n";
                
                //if (checkBox5.Checked == true)
                //    s = s + checkBox5.Text + "\n"; //c5 = "Pouliet routis  \n";
                
                //if (checkBox6.Checked == true)
                //    s = s + checkBox6.Text + "\n";  //c6 = "Poisson  \n";
                
                //if (checkBox7.Checked == true)
                //    s = s + checkBox7.Text + "\n"; //c7 = "Salade  \n";
                
                //if (checkBox8.Checked == true)
                //    s = s + checkBox8.Text + "\n";// c8 = "Fromage  \n";
                
                //if (checkBox9.Checked == true)
                //    s = s + checkBox9.Text + "\n";//c9 = "Dessert  \n";
                
                //if (checkBox10.Checked == true)
                //    s = s + checkBox10.Text + "\n";// c10 = "Café  \n";

                foreach (CheckBox c in this.groupBox1.Controls)
                {

                    if (c.Checked == true)
                        s = s + c.Text + Environment.NewLine;
                }

                   
                

                MessageBox.Show(s+"\t\t\t", "Votre plat contient", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
