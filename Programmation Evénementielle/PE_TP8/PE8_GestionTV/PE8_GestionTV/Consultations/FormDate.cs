using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE8_GestionTV.Consultations
{
    public partial class FormDate : Form
    {
        private static FormDate instance;

        public static FormDate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormDate();
                }
                return instance;
            }
        }
        
        public FormDate()
        {
            InitializeComponent();
            // Contrôler le choix de la date
            dateTimePicker1.MinDate = DateTime.Today;
            // Remplir Liste au début
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TV.ListeDateGet(dateTimePicker1.Value);
        }

        private void FormDate_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void button_afficher_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TV.ListeDateGet(dateTimePicker1.Value);
        }
    }
}
