using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EX_1
{

    public partial class Form1 : Form
    {
        bool V = false;

        public Form1()
        {
            InitializeComponent();
        }



        private void ajoutProgrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 g = new Form2();
            g.MdiParent = this;
            g.Show();



            g.dataGridView1.DataSource = null;
            g.dataGridView1.DataSource = Program.l;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeDesEmissionsParDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 f = new Form3();
            f.MdiParent = this;
            f.Show();
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form4 f = new Form4();
            f.MdiParent = this;
            f.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Emission.C == true)
            {
                DialogResult r = MessageBox.Show("Vouler-vous enregistrez les modifications", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream f = new FileStream("test", FileMode.Create);
                    //Stream f = File.OpenWrite("test");
                    bf.Serialize(f, Program.l);
                    f.Close();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
            menuStrip1.Enabled = false;
            if (File.Exists("test") == true)
            {

                BinaryFormatter bf = new BinaryFormatter();
                //Stream f = File.OpenRead("test");
                FileStream f = new FileStream("test", FileMode.Open);
                Program.l = (ArrayList)bf.Deserialize(f);
                f.Close();

            }











            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                textBox1.Visible = false;
                button1.Visible = false;
                menuStrip1.Enabled = true;
            }
            else
            { MessageBox.Show("Le code est incorrect"); textBox1.Text = ""; }
        }
    }
}
