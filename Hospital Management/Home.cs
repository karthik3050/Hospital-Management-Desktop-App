﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Preg().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Ireg().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
