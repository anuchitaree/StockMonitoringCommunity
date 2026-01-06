using StockMonitoringCommunity.Classes;
using StockMonitoringCommunity.Data;
using System.Data;

namespace StockMonitoringCommunity.SubForm
{
    public partial class StockTransactionUserControl : UserControl
    {

        private List<ScanInOutTransaction> _stockTransactions = new List<ScanInOutTransaction>();
        public StockTransactionUserControl()
        {
            InitializeComponent();
        }

        private void StockTransactionUserControl_Load(object sender, EventArgs e)
        {
            string[] head = new string[] { "Id", "Channel", "Direction", "Raw", "Partnumber", "CreatedAt", "IsProcessed", };
            string[] property = new string[] { "Id", "Channel", "Direction", "Raw", "Partnumber", "CreatedAt", "IsProcessed", };
            int[] width = new int[] { 50, 50, 50, 250, 150, 150, 50, };
            InitialDatagridview.Pattern_1(head, property, width, dataGridView1);
            //dataGridView1.DataSource = _stockTransactions;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true; // แนะนำ

            dateTimePicker1.Value = DateTime.Now.AddDays(-7);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.ShowUpDown = false;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker2.ShowUpDown = false;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            LoadData();

        }

        private void LoadData()
        {
            try
            {
                var datefrom = DateTime.SpecifyKind(
                            dateTimePicker1.Value, DateTimeKind.Local
                            ).ToUniversalTime();

                var dateto = DateTime.SpecifyKind(
                            dateTimePicker2.Value, DateTimeKind.Local
                            ).ToUniversalTime();

                using (var db = new AppDbContext())
                {
                    _stockTransactions = db.ScanInOutTransactions
                        .Where(x => x.CreatedAt >= datefrom
                                 && x.CreatedAt <= dateto)
                        .OrderByDescending(x => x.CreatedAt)
                        .ToList();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = _stockTransactions;
                }


            }
            catch
            {
                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var selectedItems = dataGridView1.SelectedRows
                        .Cast<DataGridViewRow>()
                        .Select(r => r.DataBoundItem as ScanInOutTransaction)
                          .Where(x => x != null)
                         .ToList();
            if (selectedItems.Count == 0)
                return;

            if (MessageBox.Show(
                    $"ต้องการลบ {selectedItems.Count} รายการใช่หรือไม่?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            using (var db = new AppDbContext())
            {
                db.ScanInOutTransactions.RemoveRange(selectedItems!);
                db.SaveChanges();
            }

            // Reload Data
            LoadData();
        }
    }
}
