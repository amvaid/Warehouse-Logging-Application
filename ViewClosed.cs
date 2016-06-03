using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace Warehouse_Logging
{
    public partial class ViewClosed : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        SqlCommand cmd;

        public ViewClosed()
        {
            InitializeComponent();
        }

        private void ViewClosed_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblWarehouseLog WHERE Status = 'OUT'";
            cmd = new SqlCommand(sql, con);

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            ViewClosedGrid.DataSource = data;
            con.Close();

            ViewClosedGrid.AllowUserToAddRows = false;
            ViewClosedGrid.RowHeadersVisible = false;

            ViewClosedGrid.Font = new Font("Tahoma", 9, FontStyle.Bold);

            ViewClosedGrid.DefaultCellStyle.BackColor = Color.Green;

            ViewClosed.ActiveForm.Text = "View Closed - Last Updated: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ViewClosed_Load(this, null);
        }
    }
}
