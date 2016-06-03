using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Warehouse_Logging
{
    public partial class Remarks : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

        public Remarks()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = @"UPDATE tblWarehouseLog SET Remarks = '" + RemarksTextBox.Text + "' WHERE ContainerID = '" + IDSelection.Text + "'"; 
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Remark added! \n Returing to Main Menu Now", "Remark Added!");
            this.Hide();
        }

        private void Remarks_Load(object sender, EventArgs e)
        {
            IDSelection.Enabled = false;
            con.Open();
            string sql = @"SELECT Account FROM tblWarehouseLog";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                AccountSelection.Items.Add(reader["Account"].ToString());
            }
            con.Close();
        }

        private void AccountSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDSelection.Enabled = true;
            IDSelection.Focus();

            con.Open();
            string sql2 = @"SELECT ContainerID FROM tblWarehouseLog where Account = '" + AccountSelection.Text + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                IDSelection.Items.Add(reader2["ContainerID"].ToString());
            }

            con.Close();
        }

        private void IDSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemarksTextBox.Focus();
             
            con.Open();

            string sql = @"SELECT Remarks FROM tblWarehouseLog where ContainerID = '" + IDSelection.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            RemarksTextBox.Text = (string)cmd.ExecuteScalar();

            con.Close();
        }
    }
}
