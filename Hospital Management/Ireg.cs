using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace final2
{
    public partial class Ireg : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Ireg()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=invendb.mdb";
        }

        private void regbut_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "insert into INVEN values ('" + r1.Text + "','" + r2.Text + "','" + r3.Text + "','" + r4.Text + "','" + r5.Text + "','" + r6.Text + "','" + r7.Text + "','" + r8.Text + "','" + r9.Text + "')";
            //  command.CommandText = "delete from REG";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Done!", "Success");
            r1.Text = "";
            r2.Text = "";
            r3.Text = "";
            r4.Text = "";
            r5.Text = "";
            r6.Text = "";
            r7.Text = "";
            r8.Text = "";
            r9.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Iview().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Iview() .Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this .Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
