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
    public partial class login : Form
    {
        public static string choice;
        public static profile userlog = new profile();
        public static string user = "";
        public static string pass = "";
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = username_.Text;
            pass = password_.Text;

            try
            {
                string conn = "datasource=127.0.0.1;port=3306;username=root;password=lizzy2000;database=quicklaundry";
                string query = "SELECT * FROM users WHERE username = '" + user + "' AND password= '" + pass+"';";
                MySqlConnection connect = new MySqlConnection(conn);
                MySqlCommand go = new MySqlCommand(query, connect);
                go.CommandTimeout = 60;
                MySqlDataReader reader;
                connect.Open();
                reader = go.ExecuteReader();
                if(reader.HasRows==true){
                    if (user == "admin")
                    {
                        admin only = new admin();
                        only.Show();
                        this.Hide();
                    }
                    else
                    {
                        profile usernew = new profile();
                        usernew.Show();
                        this.Hide();
                    }
                    username_.Text = "";
                    password_.Text = "";
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect!", "Invalid Login");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup instance = new signup();
            instance.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is login)
                {
                    oForm.Show();
                    break;
                }
                else
                {
                    oForm.Hide();
                }
            }
        }

        private void forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            choice = "reset";
            reset forgotten = new reset();
            forgotten.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            choice = "change";
            reset forgotten = new reset();
            forgotten.Show();
        }
    }
}
