using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_8
{
    public partial class Form1 : Form
    {
        string m;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                button2.Enabled = false;
            else
            {
                this.Text = "Voyage : " + textBox1.Text;
                button2.Enabled = true;
            }
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            { 
                MessageBox.Show("La date d'Arrivé doit être postérieure à la date de Départ", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
              dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                TimeSpan d = (dateTimePicker2.Value.Date - dateTimePicker1.Value.Date);

                label6.Text = d.TotalDays.ToString() + " Jours";



            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("La date d'Arrivé doit être postérieure à la date de Départ", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker2.Value = DateTime.Now;
            }
            else
            {
                TimeSpan d = (dateTimePicker2.Value.Date - dateTimePicker1.Value.Date);

                label6.Text = d.TotalDays.ToString() + " Jours";



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Entrez l'intitulé du voyage svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //else if (dateTimePicker1.Value >dateTimePicker2.Value)
            //    MessageBox.Show("La date d'Arrivé doit être postérieure à la date de Départ", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                   else if (numericUpDown1.Value==0)
                MessageBox.Show("Le nobre des places doit être Superieur à 0", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numericUpDown2.Value==0)
                MessageBox.Show("Le nobre des places Inscrits doit être Superieur à 0", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
         
            else
            {
                DialogResult r = MessageBox.Show("Départ : " + dateTimePicker1.Value.ToShortDateString() + "\n" + "Arrivé : " + dateTimePicker2.Value.ToShortDateString() + "\n" + "Durré : " + label6.Text + "\n" + "Places : " + numericUpDown1.Value.ToString() + "\n" + "Inscrits : " + numericUpDown2.Value.ToString() + "\n" + "Libres : " + label7.Text + "\n\n   Voulez vous enregistrez ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {

                    
                    this.Text = "Voyage";
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Today;
                    dateTimePicker2.Text= dateTimePicker2.Value.AddDays(1).ToString();

                    numericUpDown1.Minimum = 0;
                    numericUpDown2.Minimum = 0;    
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;
                }




            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < numericUpDown2.Value)
            {
                MessageBox.Show("Le nobre des places inscrit doit être inferieur ou égale à le nombre de places totales", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label7.Text = "";
            }
            else
                label7.Text = (numericUpDown1.Value - numericUpDown2.Value).ToString()+" Libres";
    

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < numericUpDown2.Value)
            {
                MessageBox.Show("Le nobre des places inscrit doit être inferieur ou égale à le nombre de places totales", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label7.Text = "";
            }
            else
                label7.Text = (numericUpDown1.Value - numericUpDown2.Value).ToString()+" Libres";
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        

       

        

        

        

        

        

        

        
            
       

        
        

       

        

        

        

        


        

       
      
    }
}
