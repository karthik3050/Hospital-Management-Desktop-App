using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace final2
{
    public partial class Preg : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Preg()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=regdb.mdb";
        }

        private void regbut_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "insert into REG values ('" + nametb.Text + "','" + agetb.Text + "','" + addresstb.Text + "','" + mobiletb.Text + "','" + emailtb.Text + "','" + gendtb.Text + "','" + weighttb.Text + "','" + heighttb.Text + "','" + ethtb.Text + "','" + bloodtb.Text + "','" + fname.Text + "','" + fnumber.Text + "','" + faddress.Text + "','" + pname.Text + "','" + idnum.Text + "','"+ gnumber.Text +"','"+ pholder.Text +"','"+ efdate.Text+"','"+prphy.Text+"')";
          //  command.CommandText = "delete from REG";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Done!", "Success");
            nametb.Text = "";
            agetb.Text = "";
            addresstb.Text = "";
            mobiletb.Text = "";
            emailtb.Text = "";
            gendtb.Text = "";
            weighttb.Text = "";
            heighttb.Text = "";
            ethtb.Text = "";
            bloodtb.Text = "";
            fname.Text = "";
            fnumber.Text = "";
            faddress.Text = "";
            pname.Text = "";
            idnum.Text = "";
            gnumber.Text = "";
            pholder.Text = "";
            efdate.Text = "";
            prphy.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Pview().Show();
            this.Close();
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Pview() .Show();
            this.Close();
        }
    }
}
