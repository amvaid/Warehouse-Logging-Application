using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Warehouse_Logging
{
    public partial class OutScreen : Form
    {
        public SqlConnection con;
        public SqlCommand cmd;
        
        public OutScreen()
        {
            InitializeComponent();
        }

        private void OutScreen_Load(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string str = "SELECT DISTINCT Account FROM tblWarehouseLog WHERE Status = 'IN'";
                    cmd = new SqlCommand(str, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        AccountSelection.Items.Add(reader["Account"].ToString());
                    }
                    reader.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void OutScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AccountSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDSelection.Items.Clear();

            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string str = "SELECT ContainerID FROM tblWarehouseLog WHERE STATUS = 'IN' AND ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(str, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IDSelection.Items.Add(reader["ContainerID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
                    
        private void BackButton_Click(object sender, EventArgs e)
        {
            ChooseSreen choose = new ChooseSreen();
            this.Hide();
            choose.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                DateTime date = monthCalendar1.SelectionStart;
                DateTime time = dateTimePicker1.Value;
                string pickUp = date.ToString("MM/dd/yyyy") + " " + time.ToString("hh:mm tt");
                try
                {
                    con.Open();
                    string sql = "Update tblWarehouseLog SET PickUp = '" + pickUp + "', LoadOutCarrier = '" + LoadOutCarrierTextBox.Text.ToString() +"', Status = 'OUT' WHERE ContainerID = '" + IDSelection.Text.ToString() + "'";
                    string sql2 = "Update tblCharges SET Out = '" + textBox1.Text.ToString() + "' WHERE ContainerID = '" + IDSelection.Text.ToString() + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd = new SqlCommand(sql, con);
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("This is done!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textBox1.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
