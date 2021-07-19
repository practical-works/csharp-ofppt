using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sélecteur_de_date__DateTimePicker_
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            label_today_datetime.Text = DateTime.Today.ToString();
        }

        private void button_afficher_Click(object sender, EventArgs e)
        {
            textBox_value.Text = dateTimePicker_main.Value.ToString();
            textBox_date.Text = dateTimePicker_main.Value.Date.ToString();
            textBox_time.Text = dateTimePicker_main.Value.ToLongTimeString();
            textBox_short.Text = dateTimePicker_main.Value.ToShortDateString();
            textBox_long.Text = dateTimePicker_main.Value.ToLongDateString();
            textBox_day.Text = dateTimePicker_main.Value.Day.ToString();
            textBox_month.Text = dateTimePicker_main.Value.Month.ToString();
            textBox_year.Text = dateTimePicker_main.Value.Year.ToString();
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            dateTimePicker_main.Value = DateTime.Today;
            button_afficher.PerformClick();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            button_afficher.PerformClick();
        }
    }
}
