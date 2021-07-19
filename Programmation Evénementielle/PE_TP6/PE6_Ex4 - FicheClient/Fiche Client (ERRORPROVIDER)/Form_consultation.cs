using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FicheClient
{
    public partial class Form_consultation : Form
    {
        public Form_consultation()
        {
            InitializeComponent();
        }

        private void button_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
