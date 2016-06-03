using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Warehouse_Logging
{
    public partial class Configuration : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        public SqlCommand cmd;

        public Configuration()
        {
            InitializeComponent();

            PhoneNumberTextBox1.MaxLength = 10;
            PhoneNumberTextBox2.MaxLength = 10;
        }

        private void Configuration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            AccountSelection.Text = "Please Select:";

            try
            {
                using (con)
                {
                    con.Open();
                    string str = "select ACCOUNT from tblAccountInfo";
                    string str2 = "SELECT StateCon FROM tblUSStates";

                    cmd = new SqlCommand(str, con);
                    SqlCommand cmd2 = new SqlCommand(str2, con);

                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        AccountSelection.Items.Add(reader["Account"].ToString());
                    }
                    reader.Close();

                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        StateSelection.Items.Add(reader2["StateCon"].ToString());
                    }
                    reader2.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AccountSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Disable();
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string rateStr = "SELECT Rate FROM tblAccountInfo WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(rateStr, con);
                    RateTextBox.Text = "$" + cmd.ExecuteScalar().ToString();

                    string dateStr = "SELECT [Date Created] FROM tblAccountInfo WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(dateStr, con);
                    DateCreatedTextBox.Text = cmd.ExecuteScalar().ToString();

                    string idStr = "SELECT ID FROM tblAccountInfo WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(idStr, con);
                    IDTextBox.Text = cmd.ExecuteScalar().ToString();

                    string adStr = "SELECT Address FROM tblAccountInfo WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(adStr, con);
                    AddressTextBox.Text = cmd.ExecuteScalar().ToString();

                    string cityStr = "SELECT City FROM tblAccountInfo WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(cityStr, con);
                    CityTextBox.Text = cmd.ExecuteScalar().ToString();

                    string stateStr = "SELECT State FROM tblAccountInfo WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(stateStr, con);
                    StateSelection.Text = cmd.ExecuteScalar().ToString();

                    string zipStr = "SELECT [Zip Code] FROM tblAccountInfo WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(zipStr, con);
                    ZipCodeTextBox.Text = cmd.ExecuteScalar().ToString();

                    string phoneOneStr = "SELECT [Phone Number 1] FROM tblAccountInfo WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(phoneOneStr, con);
                    PhoneNumberTextBox1.Text = cmd.ExecuteScalar().ToString();

                    string phoneTwoStr = "SELECT [Phone Number 2] FROM tblAccountInfo WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(phoneTwoStr, con);
                    PhoneNumberTextBox2.Text = cmd.ExecuteScalar().ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text != null)
            {
                ClearAll(this.Controls);
            }
            label1.Visible = false;
            AccountSelection.Visible = false;

            EnterAccountLabel.Visible = true;
            AccountNameTextBox.Visible = true;

            DateCreatedTextBox.Visible = false;
            dateTimePicker1.Visible = true;


            Enable();
        }

        private void ClearAll(Control.ControlCollection c)
        {
            foreach (Control ctrl in c)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                {
                    tb.Text = "";
                }
                else
                    ClearAll(ctrl.Controls);


                AccountSelection.Text = "";
                StateSelection.Text = "";
                AccountNameTextBox.Visible = false;
                EnterAccountLabel.Visible = false;
                AccountSelection.Visible = true;
                label1.Visible = true;

                Disable();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll(this.Controls);
            dateTimePicker1.Visible = false;
            DateCreatedTextBox.Visible = true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void Enable()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
                if (c is TextBox && c != IDTextBox)
                    (c as TextBox).ReadOnly = false;
            }
        }

        private void Disable()
        {
            foreach (Control c in this.Controls)
            {
                StateSelection.Enabled = false;
                if (c is TextBox)
                    (c as TextBox).ReadOnly = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            string createDate = date.ToString("MM/dd/yyyy");
            using (con)
            {
                if (AccountNameTextBox.Visible == true)
                {
                    try
                    {
                        string insertString = @"INSERT INTO tblAccountInfo (Account, [Date Created], Rate, Address, City, State, [Zip Code], [Phone Number 1], [Phone Number 2]) VALUES('" +
                             AccountNameTextBox.Text.ToString() + "', '" + createDate + "', '" + RateTextBox.Text.ToString() + "', '" +
                             AddressTextBox.Text.ToString() + "', '" + CityTextBox.Text.ToString() + "', '" + StateSelection.Text.ToString() + "', '" +
                             ZipCodeTextBox.Text.ToString() + "', '" + PhoneNumberTextBox1.Text.ToString() + "', '" + PhoneNumberTextBox2.Text.ToString() + "')";
                        con.Open();
                        cmd = new SqlCommand(insertString, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("New Account Created!");
                        ClearAll(this.Controls);
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("You Must Fill Out All Fields to Save");
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    string updateString = @"UPDATE tblAccountInfo SET [Date Created] = '" + createDate + "', Rate = '" + RateTextBox.Text.ToString() +
                        "', Address = '" + AddressTextBox.Text.ToString() + "', City = '" + CityTextBox.Text.ToString() +
                        "', State = '" + StateSelection.Text.ToString() + "', [Zip Code] = '" + ZipCodeTextBox.Text.ToString() +
                        "', [Phone Number 1] = '" + PhoneNumberTextBox1.Text.ToString() + "', [Phone Number 2] = '" + PhoneNumberTextBox2.Text.ToString() +
                        "' WHERE Account = '" + AccountSelection.Text.ToString() + "'";
                    con.Open();
                    cmd = new SqlCommand(updateString, con);
                    cmd.ExecuteScalar();
                    con.Close();

                    MessageBox.Show("Account Information Updated!");
                    Disable();
                }
            }
        }

        private void RateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && RateTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void ZipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 45 && ZipCodeTextBox.Text.IndexOf('-') != -1)
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterScreen enterScreen = new EnterScreen();
            enterScreen.Show();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            Configuration_Load(this, null);
        }
    }
}
