using StockMonitoringCommunity.Classes;
using StockMonitoringCommunity.Data;

namespace StockMonitoringCommunity.SubForm
{
    public partial class StoreUserControl : UserControl
    {
        private int _store_id;
        public StoreUserControl()
        {
            InitializeComponent();
        }

        private void StoreUserControl_Load(object sender, EventArgs e)
        {
            string[] head = new string[] { "Id", "StoreID", "Name", "Location" };
            string[] property = new string[] { "Store_Id", "StoreID", "StoreName", "StoreLocation" };
            int[] width = new int[] { 70, 150, 150, 150 };
            InitialDatagridview.Pattern_1(head, property, width, dataGridView1);
            //dataGridView1.DataSource = _masterStock;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                LoadStore();
            }
            catch
            {
                MessageBox.Show("An error occurred while reading store information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadStore()
        {
            using (var db = new AppDbContext())
            {
                var storeList = db.Stores.ToList();
                dataGridView1.DataSource = storeList;
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string storeID = txtStoreID.Text.Trim();
                string storeName = txtStoreName.Text.Trim();
                string storeLocation = txtStoreLocation.Text.Trim();
                using (var db = new AppDbContext())
                {
                    var existingStore = db.Stores.FirstOrDefault(s => s.StoreID == storeID);
                    if (existingStore != null)
                    {
                        // Update existing store
                        existingStore.StoreName = storeName;
                        existingStore.StoreLocation = storeLocation;
                        db.SaveChanges();

                    }
                    else
                    {
                        var store = new Store()
                        {
                            StoreID = storeID,
                            StoreName = storeName,
                            StoreLocation = storeLocation
                        };
                        db.Stores.Add(store);
                        db.SaveChanges();
                    }
                    LoadStore();
                }
                MessageBox.Show("Store information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An error occurred while saving store information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int row = (int)dataGridView1?.CurrentCell?.RowIndex!;

                if (row < 0) return;
                _store_id = Convert.ToInt32(dataGridView1?.CurrentRow!.Cells["Id"].Value);
                txtStoreID.Text = dataGridView1?.CurrentRow?.Cells["StoreID"]?.Value?.ToString();
                txtStoreName.Text = dataGridView1?.CurrentRow?.Cells["Name"]?.Value?.ToString();
                txtStoreLocation.Text = dataGridView1?.CurrentRow?.Cells["Location"]?.Value?.ToString();

            }
            catch 
            {
            }
        }
    }
}
