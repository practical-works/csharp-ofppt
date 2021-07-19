using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE2_Ex1
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (radioButton_default.Checked) Form_main.ActiveForm.BackColor = Form_main.DefaultBackColor;
            if (radioButton_blue.Checked) Form_main.ActiveForm.BackColor = Color.Blue;
            if (radioButton_red.Checked) Form_main.ActiveForm.BackColor = Color.Red;
            if (radioButton_green.Checked) Form_main.ActiveForm.BackColor = Color.Green;
        }

        private void button_ColorReset_Click(object sender, EventArgs e)
        {
            Form_main.ActiveForm.BackColor = Form_main.DefaultBackColor;
            radioButton_default.Checked =  true;
        }
    }
}
