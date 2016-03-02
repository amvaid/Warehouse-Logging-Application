using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Warehouse_Logging
{
    public partial class Create : Form
    {
        string configConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
                        Data Source = C:\\Users\\Aman\\Documents\\Visual Studio 2015\\Projects\\Warehouse Logging\\Warehouse Logging\Warehouse_Logging_Config.xlsx" + @"; 
                        Extended properties = 'Excel 12.0; 
                        HDR= YES; 
                        IMEX = 3; READONLY=TRUE;';";

        string logConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
                        Data Source = C:\\Users\\Aman\\Documents\\Visual Studio 2015\\Projects\\Warehouse Logging\\Warehouse Logging\Warehouse_Log.xlsx" + @"; 
                        Extended properties = 'Excel 12.0; 
                        HDR= YES; 
                        IMEX = 3; READONLY=FALSE;';";

        private OleDbConnection con;
        private OleDbCommand cmd;
        private OleDbDataAdapter oledbad;
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
           using(con = new OleDbConnection(configConnectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT ACCOUNT FROM [sheet1$]";
                    cmd = new OleDbCommand(query, con);
                    oledbad = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
                    oledbad.Fill(ds, "[sheet1$]");
                    con.Close();

                    dt = ds.Tables["[sheet1$]"];
                    for (int i = 0; i < dt.Rows.Count - 1; i++)
                    {
                        AccountSelection.Items.Add(dt.Rows[i].ItemArray[0]);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void AccountSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(configConnectionString))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT RATE FROM [sheet1$] WHERE ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(sql, con);
                    RateTextBox.Text = "$" + cmd.ExecuteScalar().ToString();
                    con.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(logConnectionString))
            {
                try
                {
                    string id = "FK-" + GenerateID();
                    con.Open();
                    string sql = "INSERT INTO [sheet1$] (ID, ACCOUNT, STATUS) VALUES ('" + id + "', '" + AccountSelection.Text.ToString() + "', 'NEW')";
                    cmd = new OleDbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Log Created!\n " + id);
                    AccountSelection.Text = " ";
                    RateTextBox.Text = " ";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ChooseSreen screen = new ChooseSreen();
            this.Hide();
            screen.Show();
        }

        private string GenerateID()
        {
            long i = 1;

            foreach(byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }

            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
    }
}
