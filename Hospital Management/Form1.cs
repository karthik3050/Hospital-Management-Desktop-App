using System;
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
    public partial class Form1 : Form
    {
         private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=reddydb.mdb";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

       /* private void log_but_Click_1(object sender, EventArgs e)              CONNECTION REF********************************************
        {

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "insert into CRED ([username],[password]) values ('priyannnka','marsetty')";
            command.ExecuteNonQuery();
            MessageBox.Show("done");
            connection.Close();

        }*/

        private void reg_but_Click(object sender, EventArgs e)
        {
            if (regtxt.Text == "" && regpwd.Text == "" && regcpwd.Text == "")
            {
                MessageBox.Show("Username and Passwords are empty", "Registration Failed");
            }
            else if (regpwd.Text == regcpwd.Text)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                if (mantxt.Text == "leicester@123")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into CRED values ('" + regtxt.Text + "','" + regpwd.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Your account has been Successfully Created", "Registration Successful");
                    regtxt.Text = "";
                    regpwd.Text = "";
                    regcpwd.Text = "";
                    mantxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Manager Password is Incorrect","Authentication Failed");
                }
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please re-enter", "Registration Failed");
                regpwd.Text = "";
                regcpwd.Text = "";
            }

        }

        private void log_but_Click(object sender, EventArgs e)
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }          
            OleDbCommand command1 = new OleDbCommand();
            command1 .Connection = connection;
            command1.CommandText = "SELECT * from CRED where username='" + logtxt.Text + "' and password= '" + logpwd.Text + "'";
            //command1.CommandText = "delete from CRED";
            OleDbDataReader dr = command1.ExecuteReader();
         

            if (dr.Read())
            {
                MessageBox.Show("Your Details are Valid", "Login Successful");
                new Home().Show();
                this.Hide();             
            }
            else
            {
                MessageBox.Show("Invalid Username and Password, Please Try Again", "Login Failed");
            }
            logpwd.Text = "";
            logtxt.Text = "";
            
        }

        
    }
    }
