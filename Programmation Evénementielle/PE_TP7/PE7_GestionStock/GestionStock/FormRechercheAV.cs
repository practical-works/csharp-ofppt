using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class FormRechercheAV : Form
    {
        public FormRechercheAV()
        {
            InitializeComponent();
            textBox_rechercher.Select();
        }

        public void Actualiser(string MotCle)
        {
            BindingSource_recherche.DataSource = null;
            BindingSource_recherche.DataSource = Stock.Get(MotCle);
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            Actualiser(textBox_rechercher.Text);
        }
    }
}
