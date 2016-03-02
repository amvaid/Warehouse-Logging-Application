using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Warehouse_Logging
{
    public partial class In : Form
    {
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
                        Data Source = C:\\Users\\Aman\\Documents\\Visual Studio 2015\\Projects\\Warehouse Logging\\Warehouse Logging\Warehouse_Log.xlsx" + @"; 
                        Extended properties = 'Excel 12.0; 
                        HDR= YES; 
                        IMEX = 1;';";

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter oledbad;
        DataSet ds;
        DataTable dt;

        public In()
        {
            InitializeComponent();
        }

        private void In_Load(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string str = "SELECT ACCOUNT FROM [sheet1$] WHERE STATUS = 'NEW'";
                    cmd = new OleDbCommand(str, con);
                    oledbad = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
                    oledbad.Fill(ds, "[sheet1$]");
                    con.Close();

                    dt = ds.Tables["[sheet1$]"];
                    for(int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        AccountSelection.Items.Add(dt.Rows[i].ItemArray[0]);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                PackageTypeSelection.Items.Add("Cartons(s)");
                PackageTypeSelection.Items.Add("Pallet(s)");
            }
        }

        private void In_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AccountSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string str = "SELECT ID FROM [sheet1$] WHERE STATUS = 'NEW' AND ACCOUNT = '" + AccountSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(str, con);
                    oledbad = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
                    oledbad.Fill(ds, "[sheet1$]");
                    con.Close();

                    dt = ds.Tables["[sheet1$]"];
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        IDSelection.Items.Add(dt.Rows[i].ItemArray[0]);
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
            ChooseSreen screen = new ChooseSreen();
            this.Hide();
            screen.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (con = new OleDbConnection(connectionString))
            {
                DateTime date = dateTimePicker1.Value;
                string dropOff = date.ToString("MM/dd/yyyy");

                try
                {
                    con.Open();
                    string sql = @"UPDATE [sheet1$] SET DROPOFF = '" + dropOff + "', QUANTITY = '" + QuantityTextBox.Text.ToString()
                        + "', TYPE = '" + PackageTypeSelection.Text.ToString() + "', WEIGHT = '" + WeightTextBox.Text.ToString() + " LB(s)', STATUS = 'IN'"
                        + "WHERE ID = '" + IDSelection.Text.ToString() + "'";
                    cmd = new OleDbCommand(sql, con);
                    cmd.ExecuteScalar();
                    con.Close();
                    MessageBox.Show("This Worked!");

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                foreach(Control c in this.Controls)
                {
                    if (c is TextBox)
                        (c as TextBox).Clear();
                    if (c is ComboBox)
                        (c as ComboBox).Text = " ";
                }
            }
        }
    }
}
