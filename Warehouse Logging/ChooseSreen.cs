using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Spreadsheets;

namespace Warehouse_Logging
{
    public partial class ChooseSreen : Form
    {
        public ChooseSreen()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Create createLog = new Create();
            this.Hide();
            createLog.Show();
        }

        private void ChooseSreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void InButton_Click(object sender, EventArgs e)
        {
            In inForm = new In();
            this.Hide();
            inForm.Show();
        }
    }
}
