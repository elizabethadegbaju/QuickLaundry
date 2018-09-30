using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace quicklaundry
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            this.FormClosing += Signup_FormClosing;
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is login)
                {
                    oForm.Show();
                    break;
                }
            }
            e.Cancel = true;
            this.Hide();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string username = username_.Text;
            string password = password_.Text;
            string password2 = password2_.Text;
            string fName = fname_.Text;
            string lName = lName_.Text;
            string email = email_.Text;
            string phone = phoneNo_.Text;
            if (username.Length < 6)
            {
                if(MessageBox.Show("Username must be at least 6 characters!", "Invalid Username", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop) == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else if (password.Length == 0||fName.Length==0||lName.Length==0||email.Length==0||phone.Length==0)
            {
                MessageBox.Show("Please ensure all details are entered.","Empty Fields",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else if (password != password2)
            {
                if (MessageBox.Show("Password do not match! Please crosscheck and try again.", "Password Mismatch", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                string conn = "datasource=127.0.0.1;port=3306;username=root;password=lizzy2000;database=quicklaundry";
                string query = "INSERT INTO users VALUES('" + username + "','" + password + "','" + fName + "','" + lName + "','" + phone + "','" + email + "');";
                MySqlConnection connect = new MySqlConnection(conn);
                MySqlCommand go = new MySqlCommand(query, connect);
                go.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    connect.Open();
                    reader = go.ExecuteReader();
                    connect.Close();
                    MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    if (MessageBox.Show("Username already taken! Enter a new username.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop) == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error");
                }
            }
        }

        private void username__TextChanged(object sender, EventArgs e)
        {
        }
    }
}
