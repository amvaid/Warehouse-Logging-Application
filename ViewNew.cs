using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace Warehouse_Logging
{
    public partial class ViewNew : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        SqlCommand cmd;

        public ViewNew()
        {
            InitializeComponent();
        }

        private void ViewNew_Load(object sender, EventArgs e)
        {
            try
            {
                String sql = @"SELECT ContainerID, Account, Appointment, Status, Remarks FROM tblWarehouseLog WHERE Status = 'New'";
                cmd = new SqlCommand(sql, con);
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                sda.Fill(data);
                ViewNewGrid.DataSource = data;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            ViewNewGrid.AllowUserToAddRows = false;
            ViewNewGrid.RowHeadersVisible = false;
            ViewNewGrid.Font = new Font("Tahoma", 15, FontStyle.Bold);

            ViewNewGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ViewNewGrid.DefaultCellStyle.BackColor = Color.Yellow;
            ViewNewGrid.CurrentCell.Selected = false;

            ViewNew.ActiveForm.Text = "View New - Last Update: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ViewNew_Load(this, null);
        }
    }
}
