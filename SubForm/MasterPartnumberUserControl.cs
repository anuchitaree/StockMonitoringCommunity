using Microsoft.EntityFrameworkCore;
using StockMonitoringCommunity.Classes;
using StockMonitoringCommunity.Data;
using StockMonitoringCommunity.Models;

namespace StockMonitoringCommunity.SubForm
{
    public partial class MasterPartnumberUserControl : UserControl
    {
        private List<MasterStock> _masterStock = new();
        private int _uuid = 0;
        public MasterPartnumberUserControl()
        {
            InitializeComponent();
        }




        private void btnSave_Click(object sender, EventArgs e)
        {

            SavePartnumberToTable();

        }



        private async void SavePartnumberToTable()
        {
            try
            {

                var storeID = cmbStore.SelectedItem?.ToString() ?? "";

                var pn = txtPartnumber.Text.Trim();
                var description = txtDescription.Text.Trim();
                var location = txtLocation.Text.Trim();
                int balance = txtBalance.Text != null || txtBalance.Text == "" ? 0 : int.Parse(txtBalance.Text!);
                int upperLimit = txtUpperlimit != null || txtUpperlimit?.Text == "" ? 0 : int.Parse(txtUpperlimit?.Text!);
                int upWarning = txtUpwarning.Text != null || txtUpwarning.Text == "" ? 0 : int.Parse(txtUpwarning.Text!);
                int loWarning = txtLowarning.Text != null || txtLowarning.Text == "" ? 0 : int.Parse(txtLowarning.Text!);
                int lowerLimit = txtLowerlimit.Text != null || txtLowerlimit.Text == "" ? 0 : int.Parse(txtLowerlimit.Text!);
                bool invisible = chkInvisible.Checked;

                using (var db = new AppDbContext())
                {
                    var has = await db.MasterStocks.Where(p => p.Partnumber == pn).ToListAsync();
                    if (has.Count > 1)
                    {
                        var info = $"You have {has.Count} records that same partnumber";
                        MessageBox.Show(info, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (has.Count == 1)
                    {
                        var hasone = has.FirstOrDefault();
                        hasone?.StoreID = storeID;
                        hasone?.Description = description;
                        hasone?.Location = location;
                        hasone?.Balance = balance;
                        hasone?.UpperLimit = upperLimit;
                        hasone?.UpperWarningLimit = upWarning;
                        hasone?.LowerWarningLimit = loWarning;
                        hasone?.LowerLimit = lowerLimit;
                        hasone?.CreatedAt = DateTime.UtcNow;
                        hasone?.Invisible = invisible;
                        await db.SaveChangesAsync();
                        MessageBox.Show("Update completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (has.Count == 0)
                    {
                        await db.MasterStocks.AddAsync(new MasterStock
                        {
                            StoreID = storeID,
                            Partnumber = pn,
                            Description = description,
                            Location = location,
                            Balance = balance,
                            UpperLimit = upperLimit,
                            UpperWarningLimit = upWarning,
                            LowerWarningLimit = loWarning,
                            LowerLimit = lowerLimit,
                            CreatedAt = DateTime.UtcNow,
                            Invisible = invisible
                        });
                        await db.SaveChangesAsync();
                        MessageBox.Show("Save new partnumber completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ReadMasterPartnumber();
            }
            catch
            {
                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void MasterPartnumberUserControl_Load(object sender, EventArgs e)
        {
            string[] head = new string[] { "No", "StoreID", "Partnumber", "Description", "Location", "Balance", "HH", "HL", "LH", "LL", "NotShow" };
            string[] property = new string[] { "MasterStock_Id", "StoreID", "Partnumber", "Description", "Location", "Balance", "UpperLimit", "UpperWarningLimit", "LowerWarningLimit", "LowerLimit", "Invisible" };
            int[] width = new int[] { 30, 120,100, 150, 100, 50, 50, 50, 50, 50, 50 };
            InitialDatagridview.Pattern_1(head, property, width, dataGridView1);
            dataGridView1.DataSource = _masterStock;

            try
            {
                List<ComboboxModel> storelist;
                using (var db = new AppDbContext())
                {
                     storelist = db.Stores.Select(s => new ComboboxModel
                    {
                        Text = s.StoreID,
                        Value = s.Store_Id
                    }).ToList();

                }

                cmbStore.DataSource = storelist;

                cmbStore.DisplayMember = "Text";
                cmbStore.ValueMember = "Value";
                cmbStore.SelectedIndex = -1;
            }
            catch
            {

            }
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadMasterPartnumber();
        }

        private async void ReadMasterPartnumber()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    _masterStock = await db.MasterStocks.ToListAsync();
                    foreach (var item in _masterStock)
                    {
                        
                    }
                    dataGridView1.DataSource = _masterStock;
                }
            }
            catch
            {

                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView1.CurrentRow!.Index;
                _uuid = int.Parse(dataGridView1.Rows[row].Cells["No"].Value!.ToString()!);

                txtPartnumber.Text = dataGridView1.Rows[row].Cells["Partnumber"].Value!.ToString()!;
                txtDescription.Text = dataGridView1.Rows[row].Cells["Description"].Value!.ToString()!;
                txtLocation.Text = dataGridView1.Rows[row].Cells["Location"].Value!.ToString()!;
                txtBalance.Text = dataGridView1.Rows[row].Cells["Balance"].Value!.ToString()!;
                txtUpperlimit.Text = dataGridView1.Rows[row].Cells["HH"].Value!.ToString()!;
                txtUpwarning.Text = dataGridView1.Rows[row].Cells["HL"].Value!.ToString()!;
                txtLowarning.Text = dataGridView1.Rows[row].Cells["LH"].Value!.ToString()!;
                txtLowerlimit.Text = dataGridView1.Rows[row].Cells["LL"].Value!.ToString()!;
                chkInvisible.Checked = dataGridView1.Rows[row].Cells["NotShow"].Value!.ToString() == "True" ? true : false;

            }
            catch
            {
                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SearchMasterPartnumber()
        {
            try
            {
                var pn = txtPartnumber.Text.Trim();
                using (var db = new AppDbContext())
                {
                    var masters = await db.MasterStocks.Where(x => x.Partnumber == pn).ToListAsync();
                    if (masters.Count == 0)
                    {
                        txtDescription.Text = txtLocation.Text = txtBalance.Text = txtUpperlimit.Text = string.Empty;
                        txtUpwarning.Text = txtLowarning.Text = txtLowerlimit.Text = string.Empty;
                        chkInvisible.Checked = false;
                        MessageBox.Show("No data found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (masters.Count > 1)
                    {
                        var info = $"You have {masters.Count} records that same partnumber";
                        MessageBox.Show(info, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (masters.Count == 1)
                    {
                        var master = masters.FirstOrDefault();

                        txtPartnumber.Text = master!.Partnumber;
                        txtDescription.Text = master.Description;
                        txtLocation.Text = master.Location;
                        txtBalance.Text = master.Balance.ToString();
                        txtUpperlimit.Text = master.UpperLimit.ToString();
                        txtUpwarning.Text = master.UpperWarningLimit.ToString();
                        txtLowarning.Text = master.LowerWarningLimit.ToString();
                        txtLowerlimit.Text = master.LowerLimit.ToString();
                        chkInvisible.Checked = master.Invisible;
                    }
                }
            }
            catch
            {

                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead1_Click(object sender, EventArgs e)
        {
            SearchMasterPartnumber();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteMasterPartnumber();
        }
        private void DeleteMasterPartnumber()
        {
            try
            {
                var pn = txtPartnumber.Text.Trim();
                using (var db = new AppDbContext())
                {
                    var masters = db.MasterStocks.Where(x => x.Partnumber == pn).ToList();
                    if (masters.Count == 0)
                    {
                        MessageBox.Show("No data found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (masters.Count > 1)
                    {
                        var master = masters.FirstOrDefault(x => x.MasterStock_Id == _uuid);
                        if (master != null)
                        {
                            db.MasterStocks.Remove(master);
                            db.SaveChanges();
                            MessageBox.Show("Delete completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else if (masters.Count == 1)
                    {
                        var info = $"You have {masters.Count} record.";
                        MessageBox.Show(info, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ReadMasterPartnumber();
            }
            catch
            {
                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
