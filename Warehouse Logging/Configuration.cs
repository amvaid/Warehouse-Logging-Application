using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Warehouse_Logging
{
    public partial class Configuration : Form
    {
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
                        Data Source = C:\\Users\\Aman\\Documents\\Visual Studio 2015\\Projects\\Warehouse Logging\\Warehouse Logging\Warehouse_Logging_Config.xlsx" + @"; 
                        Extended properties = 'Excel 12.0; 
                        HDR= YES; 
                        IMEX = 3; READONLY=FALSE;';";
        string usStates = @"Provider = Microsoft.ACE.OLEDB.12.0; 
                        Data Source = C:\\Users\\Aman\\Documents\\Visual Studio 2015\\Projects\\Warehouse Logging\\Warehouse Logging\US_STATES.xlsx" + @"; 
                        Extended properties = 'Excel 12.0; 
                        HDR= YES; 
                        IMEX = 1;';";

        public OleDbCommand cmd;
        public DataSet ds;
        public OleDbDataAdapter oledbda;
        public DataTable dt;

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

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string str = "select ACCOUNT from [sheet1$]";
                    cmd = new OleDbCommand(str, con);
                    oledbda = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
                    oledbda.Fill(ds, "[sheet1$]");
                    con.Close();

                    dt = ds.Tables["[sheet1$]"];
                    int i = 0;
                    for (i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        AccountSelection.Items.Add(dt.Rows[i].ItemArray[0]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                using (OleDbConnection con2 = new OleDbConnection(usStates))
                {
                    try
                    {
                        con2.Open();
                        string str = "SELECT US_STATES FROM [sheet1$]";
                        cmd = new OleDbCommand(str, con2);
                        oledbda = new OleDbDataAdapter(cmd);
                        ds = new DataSet();
                        oledbda.Fill(ds, "[sheet1$]");
                        con2.Close();

                        dt = ds.Tables["[sheet1$]"];
                        int i = 0;
                        for (i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            StateSelection.Items.Add(dt.Rows[i].ItemArray[0]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void AccountSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

            Disable();
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string rateStr = "SELECT RATE FROM [sheet1$] WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(rateStr, con);
                    RateTextBox.Text = "$" + cmd.ExecuteScalar().ToString();

                    string dateStr = "SELECT DATE_CREATED FROM [sheet1$] WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(dateStr, con);
                    DateCreatedTextBox.Text = cmd.ExecuteScalar().ToString();

                    string idStr = "SELECT ID FROM [sheet1$] WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(idStr, con);
                    IDTextBox.Text = cmd.ExecuteScalar().ToString();

                    string adStr = "SELECT ADDRESS FROM [sheet1$] WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(adStr, con);
                    AddressTextBox.Text = cmd.ExecuteScalar().ToString();

                    string cityStr = "SELECT CITY FROM [sheet1$] WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(cityStr, con);
                    CityTextBox.Text = cmd.ExecuteScalar().ToString();

                    string stateStr = "SELECT STATE FROM [sheet1$] WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(stateStr, con);
                    StateSelection.Text = cmd.ExecuteScalar().ToString();

                    string zipStr = "SELECT ZIP_CODE FROM [sheet1$] WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(zipStr, con);
                    ZipCodeTextBox.Text = cmd.ExecuteScalar().ToString();

                    string phoneOneStr = "SELECT PHONE_NUMBER1 FROM [sheet1$] WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(phoneOneStr, con);
                    PhoneNumberTextBox1.Text = cmd.ExecuteScalar().ToString();

                    string phoneTwoStr = "SELECT PHONE_NUMBER2 FROM [sheet1$] WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(phoneTwoStr, con);
                    PhoneNumberTextBox2.Text = cmd.ExecuteScalar().ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    ClearAll(this.Controls);
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
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                if (AccountNameTextBox.Visible == true)
                {
                    try
                    {
                        string insertString = @"INSERT INTO [sheet1$] (ACCOUNT, DATE_CREATED, RATE, ADDRESS, CITY, STATE, ZIP_CODE, PHONE_NUMBER1, PHONE_NUMBER2) VALUES('" +
                             AccountNameTextBox.Text.ToString() + "', '" + createDate + "', '" + RateTextBox.Text.ToString() + "', '" +
                             AddressTextBox.Text.ToString() + "', '" + CityTextBox.Text.ToString() + "', '" + StateSelection.Text.ToString() + "', '" +
                             ZipCodeTextBox.Text.ToString() + "', '" + PhoneNumberTextBox1.Text.ToString() + "', '" + PhoneNumberTextBox2.Text.ToString() + "')";
                        con.Open();
                        cmd = new OleDbCommand(insertString, con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("New Account Created!");
                        ClearAll(this.Controls);
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("You Must Fill Out All Fields to Save");
                    }
                }
                else
                {
                    string updateString = @"UPDATE [sheet1$] SET DATE_CREATED = '" + createDate + "', RATE = '" + RateTextBox.Text.ToString() +
                        "', ADDRESS = '" + AddressTextBox.Text.ToString() + "', CITY = '" + CityTextBox.Text.ToString() +
                        "', STATE = '" + StateSelection.Text.ToString() + "', ZIP_CODE = '" + ZipCodeTextBox.Text.ToString() +
                        "', PHONE_NUMBER1 = '" + PhoneNumberTextBox1.Text.ToString() + "', PHONE_NUMBER2 = '" + PhoneNumberTextBox2.Text.ToString() +
                        "' WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    con.Open();
                    cmd = new OleDbCommand(updateString, con);
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

            if(ch == 46 && RateTextBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void ZipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(ch == 45 && ZipCodeTextBox.Text.IndexOf('-') != -1)
            {
                e.Handled = true;
            }
            if(!Char.IsDigit(ch) && ch != 8 && ch != 45)
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
    }
}
