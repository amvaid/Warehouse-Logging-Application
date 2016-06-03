using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace Warehouse_Logging
{
    public partial class Create : Form
    {
        SqlConnection con;

        private SqlCommand cmd;
        private SqlDataAdapter oledbad;
        private DataSet ds;
        private DataTable dt;

        public Create()
        {
            InitializeComponent();
        }

        private void Create_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
                {
                    con.Open();
                    string query = @"SELECT Account FROM tblAccountInfo";
                    cmd = new SqlCommand(query, con);
                    oledbad = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    oledbad.Fill(ds, "tblAccountInfo");
                    con.Close();

                    dt = ds.Tables["tblAccountInfo"];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        AccountSelection.Items.Add(dt.Rows[i].ItemArray[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AccountSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
                {
                    con.Open();
                    string sql = "SELECT RATE FROM tblAccountInfo WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new SqlCommand(sql, con);
                    RateTextBox.Text = "$" + cmd.ExecuteScalar().ToString();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dateTimePicker1.Focus();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
                {
                    DateTime apptDate = monthCalendar1.SelectionStart;
                    DateTime apptTime = dateTimePicker1.Value;
                    string aDate = apptDate.ToString("MM/dd/yyyy");
                    string aTime = apptTime.ToString("hh:mm tt");
                    string appt = aDate + " " + aTime;

                    con.Open();
                    string sql = "INSERT INTO tblWarehouseLog (ContainerID, Account, Appointment, Status) VALUES ('" + IDTextBox.Text.ToString() + "', '" + AccountSelection.Text.ToString() + "', '" + appt + "', 'NEW')";
                    string sql2 = "INSERT INTO tblCharges (ContainerID, Account) VALUES ('" + IDTextBox.Text.ToString() + "', '" + AccountSelection.Text.ToString() + "')";
                    cmd = new SqlCommand(sql, con);
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Appointment Created!\n " + appt);
                    AccountSelection.Text = " ";
                    RateTextBox.Text = " ";
                    IDTextBox.Text = " ";
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
    }
}
