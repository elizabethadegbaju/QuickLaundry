using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace quicklaundry
{
    public partial class reset : Form
    {
        public reset()
        {
            InitializeComponent();
            this.FormClosing += Reset_FormClosing;
        }

        private void Reset_FormClosing(object sender, FormClosingEventArgs e)
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

        private void check_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string newpass = Convert.ToString(rand.Next(100000, 999999));
            string query = "UPDATE users SET password = '"+newpass+"' WHERE email = '"+email.Text+"'";
            string connect = "datasource=127.0.0.1;port=3306;username=root;password=lizzy2000;database=quicklaundry";
            MySqlConnection connector = new MySqlConnection(connect);
            MySqlCommand command = new MySqlCommand(query, connector);
            command.CommandTimeout = 60;
            MySqlDataReader myreader;
            connector.Open();
            myreader = command.ExecuteReader();
            while (myreader.Read())
            {
                connector.Close();
            }
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient mysmtp = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("admin@quicklaundry.com");
                mail.To.Add(new MailAddress(email.Text));
                mail.Subject = "QuickLaundry Recover Password";
                mail.Body = "This email was sent to "+email.Text+"\nYour new password is "+newpass+"\nDo not reply to this email.\n\nElizabeth Adegbaju\nCEO\nQuickLaundry";

                mysmtp.Port = 587;
                mysmtp.Credentials = new System.Net.NetworkCredential("elizabeth.adegbaju@stu.cu.edu.ng", "adewusiboluwatife");
                mysmtp.EnableSsl = true;
                mysmtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                mysmtp.Send(mail);
                MessageBox.Show("Check your email for the password sent to you.", "Recovery Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                email.Text = "";
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (newpass_.Text == confirmnewpass_.Text)
            {
                try
                {
                    string conn = "datasource=127.0.0.1;port=3306;username=root;password=lizzy2000;database=quicklaundry";
                    string query = "SELECT * FROM users WHERE email = '" + email2.Text + "' AND password= '" + oldpass_.Text + "';";
                    MySqlConnection connect = new MySqlConnection(conn);
                    MySqlCommand go = new MySqlCommand(query, connect);
                    go.CommandTimeout = 60;
                    MySqlDataReader reader;
                    connect.Open();
                    reader = go.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        string newpassword = newpass_.Text;
                        try
                        {
                            string querier = "UPDATE users SET password = '" + newpassword + "' WHERE email = '" + email2.Text + "'";
                            string connecting = "datasource=127.0.0.1;port=3306;username=root;password=lizzy2000;database=quicklaundry";
                            MySqlConnection connector = new MySqlConnection(connecting);
                            MySqlCommand command = new MySqlCommand(querier, connector);
                            command.CommandTimeout = 60;
                            MySqlDataReader myreader;
                            connector.Open();
                            myreader = command.ExecuteReader();
                            while (myreader.Read())
                            {
                            }
                            connector.Close();
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        catch (Exception except)
                        {
                            MessageBox.Show(except.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email address or old password incorrect!", "Invalid Details",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error");
                }
                
            }
            else
            {
                MessageBox.Show("New Passwords do not match! Please crosscheck and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void reset_Load(object sender, EventArgs e)
        {
            if (login.choice == "reset")
            {
                this.AcceptButton = check;
                panel1.Show();
                newpass.Hide();
            }
            else if(login.choice == "change")
            {
                this.AcceptButton = change;
                emailpass.Show();
                newpass.Show();
            }
        }
    }
}
