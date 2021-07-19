using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ArrayList k=new ArrayList();
            
            int i;bool m=false;

            for (i = 0; i < Program.l.Count; i++)
            {
                Emission r = Program.l[i] as Emission;
                if (r.DateEmission.ToLongDateString() == dateTimePicker1.Value.ToLongDateString())
                {
                    m = true; k.Add(r);
                }
            }
            if (m == false)
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Cette date n'existe pas");
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = k;
            }
                
                   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.l.Count == 0)
                MessageBox.Show("le numéro d'emissions n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Program.l;
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
