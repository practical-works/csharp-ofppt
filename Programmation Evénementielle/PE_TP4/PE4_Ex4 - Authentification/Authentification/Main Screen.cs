﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Authentification
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form_main_MouseHover(object sender, EventArgs e)
        {
            Opacity = 100;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
