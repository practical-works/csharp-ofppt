using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PE_Passage_2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] GrSang = { "A", "B", "O", "AB" };
            comboBox_GR.Items.AddRange(GrSang);
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textBox_CIN.Text = textBox_NOM.Text = textBox_PRENOM.Text = "";
            comboBox_GR.SelectedIndex = -1;
            radioButton_PLUS.Checked = radioButton_MINUS.Checked = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string CIN = textBox_CIN.Text.Trim();
            string NOM = textBox_NOM.Text.Trim();
            string PRENOM = textBox_PRENOM.Text.Trim();
            string GRSANG = "";
            if (comboBox_GR.SelectedIndex != -1) GRSANG = comboBox_GR.SelectedItem.ToString();
            string RHESUS = "";
            if (radioButton_PLUS.Checked) RHESUS = "+"; else if (radioButton_MINUS.Checked) RHESUS = "-";

            if (CIN == "" || NOM == "" || PRENOM == "" || GRSANG == "" || RHESUS == "")
            {
                MessageBox.Show("Des champs sont vides!");
            }
            else
            {
                bool trouvee = false;
                foreach (DataGridViewRow R in dataGridView1.Rows)
                {
                    if (R.Cells[0].Value.ToString().CompareTo(CIN) == 0)
                    {
                        trouvee = true;
                        break;
                    }
                }
                if (trouvee)
                {
                    MessageBox.Show("Donneur existe déjà!");
                }
                else
                {
                    dataGridView1.Rows.Add(CIN, NOM, PRENOM, GRSANG, RHESUS);
                    button_new.PerformClick();
                    textBox_CIN.Focus();
                }
                
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            string CIN = textBox_CIN.Text.Trim();
            if (CIN == "")
            {
                MessageBox.Show("Champ de CIN vide!");
            }
            else
            {
                bool trouvee = false;
                int p = -1;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString().CompareTo(CIN) == 0)
                    {
                        trouvee = true;
                        p = i;
                        break;
                    }
                }
                if (!trouvee)
                {
                    MessageBox.Show("Donneur n'existe pas!");
                }
                else
                {
                    DialogResult D = MessageBox.Show("Supprimer ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (D == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(p);
                    }                  
                }
            }
        }

        private void button_sav_Click(object sender, EventArgs e)
        {
            try
            {
                List<Donneur> Donneurs = new List<Donneur>();
                foreach (DataGridViewRow R in dataGridView1.Rows)
                {
                    string CIN = (string)R.Cells[0].Value;
                    string NOM = (string)R.Cells[1].Value;
                    string PRENOM = (string)R.Cells[2].Value;
                    string GRSANG = (string)R.Cells[3].Value;
                    string RHESUS = (string)R.Cells[4].Value;
                    Donneurs.Add(new Donneur(CIN, NOM, PRENOM, GRSANG, RHESUS));
                }
                Stream S = File.OpenWrite("Donneurs.dat");
                BinaryFormatter B = new BinaryFormatter();
                B.Serialize(S, Donneurs);
                S.Close();
                MessageBox.Show("Données bien sauvegardées.","Sauvegarde",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception EXC)
            {

                MessageBox.Show(EXC.Message);
            }
        }
    }
}
