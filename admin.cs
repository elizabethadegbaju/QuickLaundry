using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace quicklaundry
{
    public partial class admin : Form
    {
        static string connStr = "datasource=127.0.0.1;username=root;password=lizzy2000;port=3306;database=quicklaundry";
        static string sql = "SELECT * FROM laundry";
        MySqlConnection con = new MySqlConnection(connStr);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public admin()
        {
            InitializeComponent();
            this.FormClosing += Admin_FormClosing;
            dataGridlaundry.ColumnCount = 7;
            dataGridlaundry.Columns[0].Name = "orderNo";
            dataGridlaundry.Columns[1].Name = "username";
            dataGridlaundry.Columns[2].Name = "status";
            dataGridlaundry.Columns[3].Name = "dropoffAddress";
            dataGridlaundry.Columns[4].Name = "dropoffTime";
            dataGridlaundry.Columns[5].Name = "bill";
            dataGridlaundry.Columns[6].Name = "paid";
            dataGridlaundry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridlaundry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridlaundry.SelectionChanged += DataGridlaundry_SelectionChanged;
            dataGridlaundry.MultiSelect = false;
        }

        private void DataGridlaundry_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection newrow;
            if (dataGridlaundry.SelectedRows.Count==0)
            {
                orderno.Text = "";
                status.Text = "";
                bill.Text = "";
                paid.Text = "";
            }
            else
            {
                newrow = dataGridlaundry.SelectedRows;
                orderno.Text = newrow[0].Cells[0].Value.ToString();
                status.Text = newrow[0].Cells[2].Value.ToString();
                bill.Text = newrow[0].Cells[5].Value.ToString();
                paid.Text = newrow[0].Cells[6].Value.ToString();
            }
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Form open in Application.OpenForms)
            {
                if(open is login)
                {
                    open.Show();
                }
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
            dataGridlaundry.Rows.Clear();
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    dataGridlaundry.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6]);
                }
                con.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string com = "UPDATE laundry SET status = '"+status.Text+"', bill = '"+bill.Text+"', paid = '"+paid.Text+"' WHERE orderNo = '"+orderno.Text+"';";
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=lizzy2000;database=quicklaundry");
            MySqlCommand cmd = new MySqlCommand(com, con);
            try
            {
                con.Open();
                MySqlDataReader newreader;
                newreader = cmd.ExecuteReader();
                {
                    MessageBox.Show("Successfully Updated");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            dataGridlaundry.Rows.Clear();
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    dataGridlaundry.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6]);
                }
                con.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                con.Close();
            }
        }
    }
}
