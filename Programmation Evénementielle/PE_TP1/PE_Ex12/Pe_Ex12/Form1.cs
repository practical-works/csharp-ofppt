using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pe_Ex12
{
    public partial class Form_table : Form
    {
        public Form_table()
        {
            InitializeComponent();
        }
        double nombre;
        private void button_générer_Click(object sender, EventArgs e)
        {
            richTextBox_table.Clear();
            for (int i = 1; i <= 10; i++)
            {
                richTextBox_table.AppendText(nombre + " x " + i + " = " + nombre*i + "\n");
            }

        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox_nombre.Text, out nombre))
            {
                textBox_nombre.Clear();
            }

        }

        
    }
}
