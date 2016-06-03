using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void OutButton_Click(object sender, EventArgs e)
        {
            OutScreen screen = new OutScreen();
            this.Hide();
            screen.Show();
        }

        private void ViewNewButton_Click(object sender, EventArgs e)
        {
            ViewNew vn = new ViewNew();
            vn.Show();
        }

        private void ViewInButton_Click(object sender, EventArgs e)
        {
            ViewIn vi = new ViewIn();
            vi.Show();
        }

        private void viewClosedButton_Click(object sender, EventArgs e)
        {
            ViewClosed vc = new ViewClosed();
            vc.Show();
        }

        private void RemarksButton_Click(object sender, EventArgs e)
        {
            Remarks remarks = new Remarks();
            remarks.Show();
        }
    }
}
