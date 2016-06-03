using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace Warehouse_Logging
{
    public partial class ViewIn : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        SqlCommand cmd;

        public ViewIn()
        {
            InitializeComponent();
        }

        private void ViewIn_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT ContainerID, Account, Appointment, Carrier, Product, DropOff, Quantity, [Type], Weight, Status, DamageDesc, Remarks FROM tblWarehouseLog WHERE Status = 'IN'";
            cmd = new SqlCommand(sql, con);

            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            ViewInGrid.ReadOnly = true;
            ViewInGrid.DataSource = ds.Tables[0];

            ViewInGrid.AllowUserToAddRows = false;
            ViewInGrid.RowHeadersVisible = false;

            ViewInGrid.Font = new Font("Tahoma", 9, FontStyle.Bold);

            ViewInGrid.DefaultCellStyle.BackColor = Color.Blue;
            ViewInGrid.DefaultCellStyle.ForeColor = Color.White;
            ViewInGrid.CurrentCell.Selected = false;

            ViewIn.ActiveForm.Text = "View In - Last Updated: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ViewIn_Load(this, null);
        }
    }
}
