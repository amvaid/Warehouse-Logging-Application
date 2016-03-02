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
    public partial class View_Closed : Form
    {
        public View_Closed()
        {
            InitializeComponent();
        }

        private void View_Closed_Load(object sender, EventArgs e)
        {
            SpreadsheetsService service = new SpreadsheetsService("Warehouse Logging");
            service.setUserCredentials("amanvaid94@gmail.com", "R124sg7!");

            SpreadsheetQuery query = new SpreadsheetQuery();
            SpreadsheetFeed feed = service.Query(query);

            
        }
    }
}
