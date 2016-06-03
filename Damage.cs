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
    public partial class Damage : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        public Damage()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("UPDATE tblWarehouseLog Set DamageDesc = '" + DamageTextBox.Text.ToString() + "' WHERE ContainerID = '" + IDTextBox.Text.ToString() + "'", con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Damage Reported!");
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Damage_Load(object sender, EventArgs e)
        {
            con.Open();

            try {
                cmd = new SqlCommand("SELECT DamageDesc from tblWarehouseLog where ContainerID = '" + IDTextBox.Text.ToString() + "'");
                DamageTextBox.Text = (string)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            con.Close();
        }
    }
}
