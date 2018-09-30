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
    public partial class newlaundry : Form
    {
        public newlaundry()
        {
            InitializeComponent();
        }

        private void newlaundry__Click(object sender, EventArgs e)
        {
            decimal total = (250*jeans_.Value)+(150*wool_.Value)+(70*nass_.Value)+(300*towel_.Value)+(250*bedsheet_.Value)+(50*small_.Value)+(150*native_.Value)+(100*cotton_.Value);
            MessageBox.Show("Successfully added! Total amount is "+total,"Add New Laundry",MessageBoxButtons.OKCancel);
            string conn = "datasource=127.0.0.1;port=3306;username=root;password=lizzy2000;database=quicklaundry";
            string query = "INSERT INTO newlaundry VALUES('"+login.user+"',"+jeans_.Value+","+wool_.Value+","+cotton_.Value+","+native_.Value+","+towel_.Value+","+bedsheet_.Value+","+nass_.Value+","+small_.Value+",'"+time_.Value +"','"+address_.Text+"',"+total+"); INSERT INTO laundry (username,bill) VALUES('"+login.user+"',"+total+");" ;
            MySqlConnection connect = new MySqlConnection(conn);
            MySqlCommand go = new MySqlCommand(query, connect);
            go.CommandTimeout = 60;
            MySqlDataReader reader;
            
            try
            {
                connect.Open();
                reader = go.ExecuteReader();
                connect.Close();
                foreach (Form oForm in Application.OpenForms)
                {
                    if (oForm is profile)
                    {
                        oForm.Hide();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            
            profile newuserlog = new profile();
            newuserlog.Show();
            this.Close();
        }

        private void newlaundry_Load(object sender, EventArgs e)
        {

        }
    }
}
