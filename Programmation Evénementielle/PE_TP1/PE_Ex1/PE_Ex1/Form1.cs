using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Ma première application évènementielle";
            this.BackColor = Color.LightBlue;
            label1.Font = new Font("Comic Sans MS", 17);
            label1.ForeColor = Color.Green;
            MessageBox.Show("Ma première application évènementielle");
        }
    }
}
