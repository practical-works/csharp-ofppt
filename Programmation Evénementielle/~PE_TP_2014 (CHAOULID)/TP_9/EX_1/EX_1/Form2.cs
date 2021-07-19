using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_1
{
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            string j = maskedTextBox1.Text;
            string g = maskedTextBox2.Text;
           
          
            if (textBox1.Text == "")
                MessageBox.Show("Entrez le numéro d'emission SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox1.Text, out n) == false)
                MessageBox.Show("le numéro d'emission n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox2.Text == "")
                MessageBox.Show("Entrez nom d'emission SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (maskedTextBox1.Text == "")
                MessageBox.Show("Entrez l'heure d'emission SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (maskedTextBox1.MaskFull == false)
                MessageBox.Show("L'heure d'emission n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (maskedTextBox2.Text == "")
                MessageBox.Show("Entrez la dureé d'emission SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);         

            else if (maskedTextBox2.MaskFull == false)
                MessageBox.Show("La dureé d'emission n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Choisissez le type d'emission SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else if(int.Parse( j.Substring(0, 2))>23 || int.Parse( j.Substring(3,2))>59)
                MessageBox.Show("L'heure d'emission n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if(int.Parse( g.Substring(0, 2))>23 || int.Parse( g.Substring(3,2))>59)
                MessageBox.Show("Entrez la dureé d'emission SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);         

            
            else
            {
                bool m=false;
                foreach (Emission b in Program.l)
                {
                    if (b.NumEmission == n)
                    { m = true; break; }
                }
                if (m == true)
                    MessageBox.Show("Ce numéro d'emission existe déja", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {


                    DialogResult r = MessageBox.Show("Voulez-vous ajouter cet émission ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {

                        Emission h = new Emission(n, textBox2.Text, dateTimePicker1.Value.Date, maskedTextBox1.Text, maskedTextBox2.Text, comboBox1.Text);

                        Program.l.Add(h);
                        Emission.C = true;
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Program.l;


                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             int n,i;
            if (textBox1.Text == "")
                MessageBox.Show("Entrez le numéro d'emission à supprimer SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox1.Text, out n) == false)
                MessageBox.Show("le numéro d'emission n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
            {
                bool m=false;
                for (i=0;i<Program.l.Count;i++)
                {
                    Emission s=Program.l[i] as Emission;
                    if (s.NumEmission == n)
                    { m = true; break; }
                }
                if (m == false)
                    MessageBox.Show("Ce numéro d'emission n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {


                    DialogResult r = MessageBox.Show("Voulez-vous supprimer cet émission ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {

                        Program.l.RemoveAt(i);
                        Emission.C = true;
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Program.l;


                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n, i; 
            if (textBox1.Text == "")
                MessageBox.Show("Entrez le numéro d'emission à modifier SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox1.Text, out n) == false)
                MessageBox.Show("le numéro d'emission n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox2.Text == "")
                MessageBox.Show("Entrez nom d'emission SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (maskedTextBox1.Text == "")
                MessageBox.Show("Entrez l'heure d'emission SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (maskedTextBox1.MaskFull == false)
                MessageBox.Show("L'heure d'emission n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (maskedTextBox2.Text == "")
                MessageBox.Show("Entrez la dureé d'emission SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (maskedTextBox2.MaskFull == false)
                MessageBox.Show("La dureé d'emission n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Choisissez le type d'emission SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            else
            {
                bool m = false;
                for (i = 0; i < Program.l.Count; i++)
                {
                    Emission s = Program.l[i] as Emission;
                    if (s.NumEmission == n)
                    { m = true; break; }
                }
                if (m == false)
                    MessageBox.Show("Ce numéro d'emission n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {


                    DialogResult r = MessageBox.Show("Voulez-vous modifier cet émission ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {

                      ((Emission)Program.l[i]).Nom= textBox2.Text;
                      ((Emission)Program.l[i]).DateEmission = dateTimePicker1.Value.Date;
                      ((Emission)Program.l[i]).Heure = maskedTextBox1.Text;
                      ((Emission)Program.l[i]).Duree = maskedTextBox2.Text;
                      ((Emission)Program.l[i]).TypeEmission = comboBox1.Text;
                      Emission.C = true;
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Program.l;


                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n, i; 
            if (textBox1.Text == "")
                MessageBox.Show("Entrez le numéro d'emission à recherhcer SVP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox1.Text, out n) == false)
                MessageBox.Show("le numéro d'emission n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool m = false;
                for (i = 0; i < Program.l.Count; i++)
                {
                    Emission s = Program.l[i] as Emission;
                    if (s.NumEmission == n)
                    { m = true; break; }
                }
                if (m == false)
                    MessageBox.Show("Ce numéro d'emission n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                        textBox2.Text=((Emission)Program.l[i]).Nom;
                        dateTimePicker1.Text=((Emission)Program.l[i]).DateEmission.ToString();
                        maskedTextBox1.Text = ((Emission)Program.l[i]).Heure;
                        maskedTextBox2.Text=((Emission)Program.l[i]).Duree;
                                  
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        

        
       

        

        

        
        

        

       

       

        
    }
}
