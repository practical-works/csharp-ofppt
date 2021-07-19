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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int z = 0, f, k; string x, y, i; int p, T = 0;
            if (Program.l.Count == 0)
                MessageBox.Show("La liste d'emissions est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                foreach (Emission m in Program.l)
                {


                    x = m.Duree;
                    y = x[0].ToString() + x[1].ToString();
                    i = x[3].ToString() + x[4].ToString();
                    p = (int.Parse(y) * 60) + (int.Parse(i));
                    z = z + p;

                }

                f = z / 60; k = z % 60;
                string v, w;
                if (f < 10)
                    v = "0";
                else
                    v = "";
                if (k < 10)
                    w = "0";
                else
                    w = "";
                textBox1.Text = v + f.ToString() + "h" + w + k.ToString() + "min";
                if (comboBox1.SelectedIndex == 0)
                {
                    int d = 0, h, r; string a, b, c; int s;
                    foreach (Emission m in Program.l)
                    {
                        if (m.TypeEmission == comboBox1.Text)
                        {

                            a = m.Duree;
                            b = a[0].ToString() + a[1].ToString();
                            c = a[3].ToString() + a[4].ToString();
                            s = (int.Parse(b) * 60) + (int.Parse(c));
                            d = d + s;
                        }
                    }
                    T = d;
                    h = d / 60; r = d % 60;
                    string n, q;
                    if (f < 10)
                        n = "0";
                    else
                        n = "";
                    if (k < 10)
                        q = "0";
                    else
                        q = "";
                    textBox2.Text = n + h.ToString() + "h" + q + r.ToString() + "min";


                }

                else if (comboBox1.SelectedIndex == 1)
                {
                    int d = 0, h, r; string a, b, c; int s;
                    foreach (Emission m in Program.l)
                    {
                        if (m.TypeEmission == comboBox1.Text)
                        {

                            a = ""; b = ""; c = ""; s = 0;
                            a = m.Duree;
                            b = a[0].ToString() + a[1].ToString();
                            c = a[3].ToString() + a[4].ToString();
                            s = (int.Parse(b) * 60) + (int.Parse(c));

                            d = d + s;
                        }
                    }
                    T = d;
                    h = d / 60; r = d % 60;

                    string n, q;
                    if (f < 10)
                        n = "0";
                    else
                        n = "";
                    if (k < 10)
                        q = "0";
                    else
                        q = "";
                    textBox2.Text = n + h.ToString() + "h" + q + r.ToString() + "min";


                }

                else if (comboBox1.SelectedIndex == 2)
                {
                    int d = 0, h, r; string a, b, c; int s;
                    foreach (Emission m in Program.l)
                    {
                        if (m.TypeEmission == comboBox1.Text)
                        {
                            a = ""; b = ""; c = ""; s = 0;
                            a = m.Duree;
                            b = a[0].ToString() + a[1].ToString();
                            c = a[3].ToString() + a[4].ToString();
                            s = (int.Parse(b) * 60) + (int.Parse(c));
                            d = d + s;
                        }
                    }
                    T = d;
                    h = d / 60; r = d % 60;

                    string n, q;
                    if (f < 10)
                        n = "0";
                    else
                        n = "";
                    if (k < 10)
                        q = "0";
                    else
                        q = "";
                    textBox2.Text = n + h.ToString() + "h" + q + r.ToString() + "min";


                }

                else if (comboBox1.SelectedIndex == 3)
                {
                    int d = 0, h, r; string a, b, c; int s;
                    foreach (Emission m in Program.l)
                    {
                        if (m.TypeEmission == comboBox1.Text)
                        {

                            a = ""; b = ""; c = ""; s = 0;
                            a = m.Duree;
                            b = a[0].ToString() + a[1].ToString();
                            c = a[3].ToString() + a[4].ToString();
                            s = (int.Parse(b) * 60) + (int.Parse(c));
                            d = d + s;
                        }
                    }
                    T = d;
                    h = d / 60; r = d % 60;

                    string n, q;
                    if (f < 10)
                        n = "0";
                    else
                        n = "";
                    if (k < 10)
                        q = "0";
                    else
                        q = "";
                    textBox2.Text = n + h.ToString() + "h" + q + r.ToString() + "min";


                }
                double g = (double)T / z;
                textBox3.Text = (g * 100).ToString() + "  %";
            }
        }
        
    }
}

