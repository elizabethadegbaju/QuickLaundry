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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
            this.FormClosing += Profile_FormClosing;
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is login)
                {
                    oForm.Show();
                    break;
                }
            }
        }

        private void profile_Load(object sender, EventArgs e)
        {
            status.Hide();
            balance.Hide();
            address.Hide();
            address_.Hide();
            time.Hide();
            time_.Hide();
            order.Hide();
            try
            {
                string conn = "datasource=127.0.0.1;port=3306;username=root;password=lizzy2000;database=quicklaundry";
                string query = "SELECT * FROM users WHERE username = '" + login.user + "' AND password= '" + login.pass + "';";
                MySqlConnection connect = new MySqlConnection(conn);
                MySqlCommand go = new MySqlCommand(query, connect);
                go.CommandTimeout = 60;
                MySqlDataReader reader;
                connect.Open();
                reader = go.ExecuteReader();
                while (reader.Read())
                {
                    name.Text = reader.GetString("fName")+" "+reader.GetString("lName");
                    email.Text = reader.GetString("email");
                    username.Text = reader.GetString("username");
                }
                connect.Close();
                query = "SELECT * FROM laundry WHERE username = '"+login.user+"';";
                MySqlCommand another = new MySqlCommand(query, connect);
                another.CommandTimeout = 60;
                MySqlDataReader newreader;
                connect.Open();
                newreader = another.ExecuteReader();
                while (newreader.Read())
                {
                    if (newreader.HasRows)
                    {
                        status.Show();
                        balance.Show();
                        addnew.Hide();
                    }
                    if (newreader.GetString("status") == "completed")
                    {
                        address.Show();
                        address_.Show();
                        time.Show();
                        time_.Show();
                        order.Show();
                    }
                    Laundry.Text = Laundry.Text + "     No" + newreader.GetString("orderNo");
                    balance.Text = "Outstanding balance: " + newreader.GetString("bill");
                    status.Text = "Current status: " + newreader.GetString("status");
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
        
        private void order_Click_1(object sender, EventArgs e)
        {
            try
            {
                string c = "datasource=127.0.0.1;port=3306;username=root;password=lizzy2000;database=quicklaundry";
                string query = "UPDATE laundry SET dropoffAddress = '" + address_.Text + "', dropoffTime = '" + time_.Value + "', status = 'dropoff' WHERE username = '" + login.user + "';"; ;
                MySqlConnection con = new MySqlConnection(c);
                MySqlCommand write = new MySqlCommand(query, con);
                write.CommandTimeout = 60;
                MySqlDataReader checker;
                con.Open();
                checker = write.ExecuteReader();
                MessageBox.Show("Successfully updated! Expect delivery within 48 hours.", "Order Drop-off");
                address.Hide();
                address_.Hide();
                time.Hide();
                time_.Hide();
                order.Hide();
                status.Text = "Current status: Dropoff";
                while (checker.Read())
                {

                }
                con.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }

        }

        private void logout__Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addnew_Click_1(object sender, EventArgs e)
        {
            newlaundry adder = new newlaundry();
            adder.Show();

        }
    }
}
