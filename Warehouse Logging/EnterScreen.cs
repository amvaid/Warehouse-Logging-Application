using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


namespace Warehouse_Logging
{
    public partial class EnterScreen : Form
    {
        public EnterScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuration config = new Configuration();
            config.Show();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseSreen choose = new ChooseSreen();
            choose.Show();
        }
    }
}

