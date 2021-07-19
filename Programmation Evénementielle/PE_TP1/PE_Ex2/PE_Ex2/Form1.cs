using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_message.Text = "";
        }
        bool afficher = true;
        private void button_action_Click(object sender, EventArgs e)
        {
            
            if (afficher)
            {
                label_message.Text = "Bienvenue dans mon application";
                button_action.Text = "Effacer";
                afficher = false;
            }
            else
            {
                label_message.Text = "";
                button_action.Text = "Afficher";
                afficher = true;
            }
            
        }
    }
}
