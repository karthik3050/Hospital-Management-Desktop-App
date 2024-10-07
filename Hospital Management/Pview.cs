﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace final2
{
    public partial class Pview : Form

    {
        private OleDbConnection connection = new OleDbConnection();

        public Pview()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=regdb.mdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;
            command1.CommandText = "SELECT * from REG";
            OleDbDataAdapter da = new OleDbDataAdapter(command1);
            DataTable dt = new DataTable();
            da.Fill( dt );
            dg1.DataSource = dt;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "delete from REG";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Done!", "Success");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Home().Show(); 
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
