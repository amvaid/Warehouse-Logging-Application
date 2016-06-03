using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Warehouse_Logging
{
    public partial class In : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public In()
        {
            InitializeComponent();
        }

        private void In_Load(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
                {
                    con.Open();
                    string str = "SELECT DISTINCT ACCOUNT FROM tblWarehouseLog WHERE STATUS = 'NEW'";
                    cmd = new SqlCommand(str, con); 
                    SqlDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        AccountSelection.Items.Add(sqlReader["Account"].ToString());
                    }

                    sqlReader.Close();
                    con.Close();
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            PackageTypeSelection.Items.Add("Pallet(s)");
            PackageTypeSelection.Items.Add("Cartons(s)");
        }

        private void In_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AccountSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDSelection.Items.Clear();
            IDSelection.Focus();

            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
                {
                    con.Open();
                    string str = "SELECT ContainerID FROM tblWarehouseLog WHERE Status = 'NEW' AND Account = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(str, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        IDSelection.Items.Add(reader["ContainerID"].ToString());
                    }
                    reader.Close();
                    con.Close();
                  }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            ChooseSreen screen = new ChooseSreen();
            screen.Show();
            this.Hide();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = monthCalendar1.SelectionStart;
                DateTime time = dateTimePicker1.Value;
                string dropOff = date.ToString("MM/dd/yyyy") + " " + time.ToString("hh:ss tt");

                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
                {
                    con.Open();
                    string sql = @"UPDATE tblWarehouseLog SET DropOff = '" + dropOff + "', Quantity = '" + QuantityTextBox.Text.ToString()
                        + "', Carrier = '" + CarrierTextBox.Text + "', Type = '" + PackageTypeSelection.Text.ToString() + "', Product = '" + ProductTextBox.Text + "', Weight = '" + WeightTextBox.Text.ToString() + " LB(s)', Status = 'IN'"
                        + "WHERE ContainerID = '" + IDSelection.Text.ToString() + "'";
                    string sql2 = @"Update tblCharges SET InFee = '" + InFeeTextBox.Text.ToString() + "' where ContainerID = '" + IDSelection.Text.ToString() + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Container: " + IDSelection.Text.ToString() + "\n has been moved into the Warehouse!", "Moved In!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Clear();
                if (c is ComboBox)
                    (c as ComboBox).Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && InFeeTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void DamageReportButton_Click(object sender, EventArgs e)
        {
            Damage damage = new Damage();
            damage.Show();
            damage.AccountTextBox.Text = AccountSelection.Text.ToString();
            damage.IDTextBox.Text = IDSelection.Text.ToString();
        }

        private void IDSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarrierTextBox.Focus();
        }

        private void PackageTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductTextBox.Focus();
        }

        private void PalletFeeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && PalletFeeTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void RampFeeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && RampFeeTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void OnStackTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && OnStackTextBox.Text.IndexOf('.') != -1)
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
