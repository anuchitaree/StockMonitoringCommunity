using Microsoft.EntityFrameworkCore;
using StockMonitoringCommunity.Classes;
using StockMonitoringCommunity.Data;

namespace StockMonitoringCommunity.SubForm
{
    public partial class MasterPartnumberUserControl : UserControl
    {
        private List<MasterStock> _masterStock = new();
        public MasterPartnumberUserControl()
        {
            InitializeComponent();
        }




        private void btnSave_Click(object sender, EventArgs e)
        {

            SavePartnumberToTable();

        }

        private void ReadPartnumberFromTable()
        {
            int row = dataGridView1.RowCount;
            //txtPartnumber.Text = dataGridView1.Row;

            if (row > 0)
            {
                var getdata = (MasterStock)dataGridView1.CurrentRow?.DataBoundItem!;
            }
        }

        private async void SavePartnumberToTable()
        {
            try
            {


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

            }
            catch
            {
                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void MasterPartnumberUserControl_Load(object sender, EventArgs e)
        {
            string[] head = new string[] { "No", "Partnumber", "Description", "Location", "Balance", "HH", "HL", "LH", "LL", "Show" };
            string[] property = new string[] { "Stock_ID", "Partnumber", "Description", "Location", "Balance", "UpperLimit", "UpperWarningLimit", "LowerWarningLimit", "LowerLimit", "Invisible" };
            int[] width = new int[] { 30, 100, 150, 100, 50, 50, 50, 50, 50, 50 };
            InitialDatagridview.Pattern_1(head, property, width, dataGridView1);
            dataGridView1.DataSource = _masterStock;

        }

        private async void btnClearn_Click(object sender, EventArgs e)
        {
            try
            {
                var pn = txtPartnumber.Text.Trim();

                using (var db = new AppDbContext())
                {
                    var has = await db.MasterStocks.Where(p => p.Partnumber == pn).ToListAsync();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                var pn = txtPartnumber.Text.Trim();

                using (var db = new AppDbContext())
                {
                    _masterStock = await db.MasterStocks.ToListAsync();
                    dataGridView1.DataSource = _masterStock;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
