using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE_Révision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            if (progressBar1.Value == progressBar1.Maximum) timer1.Stop(); else progressBar1.PerformStep();
            if (trackBar1.Value < trackBar1.Maximum) trackBar1.Value++;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(checkedListBox1.Items);
            monthCalendar1.MaxSelectionCount = 20;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            label1.Text = monthCalendar1.SelectionStart.ToLongDateString() ;

            dataGridView1.Rows.Add(1, 2, 3);
            dataGridView1.Rows.Add(1, 2, 3);
            dataGridView1.Rows.Add(1, 2, 3);

            dataGridView1.Rows[1].Cells[1].Value = DateTime.Today;

        }
    }
}
