using StockMonitoringCommunity.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockMonitoringCommunity.SubForm
{
    public partial class AccountUserForm : UserControl
    {
        public AccountUserForm()
        {
            InitializeComponent();
        }

        private void AccountUserForm_Load(object sender, EventArgs e)
        {
          
            string[] head = new string[] { "No", "CH", "Part number", "Timestamp", "Raw" };
            string[] property = new string[] { "Id", "Channel", "Partnumber", "Timestamp", "Raw" };
            int[] width = new int[] { 30, 30, 150, 150, 800 };
            InitialDatagridview.Pattern_1(head, property, width, dataGridView1);
        }
    }
}
