using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Listes_et_Propriétés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_count.Text = listBox_mois.Items.Count.ToString();
            textBox_index.Text = listBox_mois.SelectedIndex.ToString();
            textBox_text.Text = listBox_mois.Text;
        }
    }
}
