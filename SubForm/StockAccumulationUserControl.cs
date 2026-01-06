using StockMonitoringCommunity.Classes;
using StockMonitoringCommunity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockMonitoringCommunity.SubForm
{
    public partial class StockAccumulationUserControl : UserControl
    {
        private List<ScanInOutTransaction> _stockTransactions = new List<ScanInOutTransaction>();

        public StockAccumulationUserControl()
        {
            InitializeComponent();
        }

        private void StockAccumulationUserControl_Load(object sender, EventArgs e)
        {
            string[] head = new string[] { "Partnumber", "Balance","HH","HL","LH","LL","Noti-Color" };
            string[] property = new string[] { "Partnumber", "Balance", "HH", "HL", "LH", "LL", "Noti-Color" };
            int[] width = new int[] { 150, 100, 100, 100, 100, 100, 100, };
            InitialDatagridview.Pattern_1(head, property, width, dataGridView1);
            //dataGridView1.DataSource = _stockTransactions;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true; // แนะนำ
        }
    }
}
