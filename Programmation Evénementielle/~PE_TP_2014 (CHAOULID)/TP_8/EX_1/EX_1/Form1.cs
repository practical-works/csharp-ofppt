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
        int r, q; bool C;
        double p;
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Entrez la référence svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox1.Text, out r) == false)
                MessageBox.Show("La référence doit être un entier svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox2.Text == "")
                MessageBox.Show("Entrez le nom svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox3.Text == "")
                MessageBox.Show("Entrez la référence svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (double.TryParse(textBox3.Text, out p) == false || p < 0)
                MessageBox.Show("Le prix de vente doit être un reèl positif svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox4.Text == "")
                MessageBox.Show("Entrez la quantité svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox4.Text, out q) == false || q < 0)
                MessageBox.Show("La quantité doit être un entier positif svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool m = false;
                if (textBox1.Text == "")
                    MessageBox.Show("Entrez la référence svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (int.TryParse(textBox1.Text, out r) == false)
                    MessageBox.Show("La référence doit être un entier svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    for (int i = 0; i < Program.T.Count; i++)
                    {
                        Article a = (Article)Program.T[i];
                        if (a.Référence.ToString() == textBox1.Text)
                        {
                            m = true;
                            break;
                        }
                    }
                    if (m == true)
                        MessageBox.Show("Cet article existe déja", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        DialogResult d = MessageBox.Show("Voulez-vous ajouter cet article ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (d == DialogResult.Yes)
                        {
                            Article b = new Article(r, textBox2.Text, p, q);
                            Program.T.Add(b);
                            C = true;
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = Program.T;
                            MessageBox.Show("Article bien ajouté", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                        }
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool m = false;
            if (textBox1.Text == "")
                MessageBox.Show("Entrez la référence svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox1.Text, out r) == false)
                MessageBox.Show("La référence doit être un entier svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < Program.T.Count; i++)
                {
                    Article a = (Article)Program.T[i];
                    if (a.Référence.ToString() == textBox1.Text)
                    {
                        m = true;
                        textBox1.Text = a.Référence.ToString();
                        textBox2.Text = a.Nom;
                        textBox3.Text = a.PrixDeVente.ToString();
                        textBox4.Text = a.Quantité.ToString();
                        break;
                    }
                }
                if (m == false)
                    MessageBox.Show("Cette référence n'existe pas", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool m = false;
            if (textBox1.Text == "")
                MessageBox.Show("Entrez la référence à modifier svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox1.Text, out r) == false)
                MessageBox.Show("La référence doit être un entier positif svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           else if (textBox2.Text == "")
                MessageBox.Show("Entrez le nom svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox3.Text == "")
                MessageBox.Show("Entrez la référence svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (double.TryParse(textBox3.Text, out p) == false || p < 0)
                MessageBox.Show("Le prix de vente doit être un reèl positif svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox4.Text == "")
                MessageBox.Show("Entrez la quantité svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox4.Text, out q) == false || q < 0)
                MessageBox.Show("La quantité doit être un entier positif svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            else
            {
                for (int i = 0; i < Program.T.Count; i++)
                {
                    Article a = (Article)Program.T[i];
                    if (a.Référence.ToString() == textBox1.Text)
                    {
                        m = true;
                          
                        
                             DialogResult d = MessageBox.Show("Voulez-vous modifier cet article numéro "+textBox1.Text+" ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                             if (d == DialogResult.Yes)
                             {
                                 a.Nom = textBox2.Text;
                                 a.PrixDeVente = double.Parse(textBox3.Text);
                                 a.Quantité = int.Parse(textBox4.Text);
                                 C = true;
                                 dataGridView1.DataSource = null;
                                 dataGridView1.DataSource = Program.T;
                                 break;
                             }
                        }
                    
                }
                if (m == false)
                    MessageBox.Show("Cette référence n'existe pas", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool m = false; 
            int i;
            if (textBox1.Text == "")
                MessageBox.Show("Entrez la référence à supprimer svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.TryParse(textBox1.Text, out r) == false)
                MessageBox.Show("La référence doit être un entier positif svp", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for ( i = 0; i < Program.T.Count; i++)
                {
                    Article a = (Article)Program.T[i];
                    if (a.Référence ==r)
                    {
                        m = true;
                        break;
                    }
                }
                if (m == false)
                    MessageBox.Show("Cette référence n'existe pas", "Erreur !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                     
                    {
                        DialogResult d = MessageBox.Show("Voulez-vous supprimer cet article ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (d == DialogResult.Yes)
                        {
                            Program.T.RemoveAt(i);
                            C = true;
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = Program.T;
                            
                            
                            MessageBox.Show("Article bien supprimé", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }           
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (File.Exists("test") == true)
            {    
               
                BinaryFormatter bf = new BinaryFormatter();
                //Stream f = File.OpenRead("test");
                FileStream f = new FileStream("test", FileMode.Open);
                Program.T = (ArrayList)bf.Deserialize(f);
                f.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Program.T;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(C==true)
            {
            DialogResult r = MessageBox.Show("Vouler-vous enregistrez les modifications", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream f = new FileStream("test", FileMode.Create);
                //Stream f = File.OpenWrite("test");
                bf.Serialize(f, Program.T);
                f.Close();
            }
            }
        }

        
    }
}

