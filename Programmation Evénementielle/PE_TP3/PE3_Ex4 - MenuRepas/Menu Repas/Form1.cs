using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu_Repas
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void Commander()
        {
            foreach (CheckBox plat in groupBox_plats.Controls)
            {
                if (plat.Checked && listBox_commande.FindString(plat.Text, -1) == -1)
                {
                    listBox_commande.Items.Add(plat.Text);
                }
                else if (!plat.Checked)
                {
                    listBox_commande.Items.Remove(plat.Text);
                 }
            
            }
           
        }

        private void button_checkAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBox plat in groupBox_plats.Controls) plat.Checked = true;
        }

        private void button_UnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBox plat in groupBox_plats.Controls) plat.Checked = false;
        }

        private void button_commander_Click(object sender, EventArgs e)
        {
            Commander();
        }

        private void groupBox_plats_Enter(object sender, EventArgs e)
        {

        }

    }
}
