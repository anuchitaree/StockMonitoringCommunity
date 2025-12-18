using Microsoft.EntityFrameworkCore;
using StockMonitoringCommunity.Data;
using StockMonitoringCommunity.Models;
using System.Data;

namespace StockMonitoringCommunity.SubForm
{
    public partial class InputPatternUserForm : UserControl
    {
        public InputPatternUserForm()
        {
            InitializeComponent();
        }

        private void InputPatternUserForm_Load(object sender, EventArgs e)
        {
            cmbPatt.DataSource = Enumerable.Range(1, 6).ToList();
            Loaddata(1);

        }

        private async void Loaddata(int channel)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var ptn = db.InputPatterns.Where(x => x.Pattern_ID == channel).FirstOrDefault();
                    if (ptn != null)
                    {
                        TbNumber.Text = ptn.NumberOfCharactor.ToString();
                        TbStart.Text = ptn.StartCharactor.ToString();
                        TbEnd.Text = (int.Parse(TbStart.Text) + int.Parse(TbNumber.Text)).ToString();
                        TbTotal.Text = ptn.TotalOfCharactor.ToString();
                        TbScan.Text = ptn.ExampleText;
                        TbResult.Text = ptn.Result;
                        TbUq.Text = ptn.UniqueStart.ToString();
                        TbUnqTxt.Text = ptn.UniqueText;
                    }
                    else
                    {
                        TbUnqTxt.Text = null;
                        TbNumber.Text = null;
                        TbStart.Text = null;
                        TbEnd.Text = null;
                        TbTotal.Text = null;
                        TbScan.Text = null;
                        TbResult.Text = null;
                        TbUq.Text = null;
                        TbUnqTxt.Text = null;
                    }
                }
            }
            catch
            {

            }
        }

        private void cmbPatt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loaddata(int.Parse(cmbPatt.Text));
        }

        private void btnGetStart_Click(object sender, EventArgs e)
        {
            TbStart.Text = TbScan.SelectionStart.ToString();
        }

        private void btnEndPos_Click(object sender, EventArgs e)
        {
            int pos = TbScan.SelectionStart;
            TbEnd.Text = pos.ToString();
            TbNumber.Text = (pos - int.Parse(TbStart.Text)).ToString();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            TbTotal.Text = TbScan.SelectionStart.ToString();
        }

        private void btnUnqStart_Click(object sender, EventArgs e)
        {
            TbUq.Text = TbScan.SelectionStart.ToString();
        }

        private void btnUnqTxt_Click(object sender, EventArgs e)
        {
            int start = int.Parse(TbUq.Text);
            int pos = TbScan.SelectionStart;

            TbUnqTxt.Text = TbScan.Text.Substring(start, (pos - start)).ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var starttext = int.Parse(TbStart.Text);
            var nuberofcharactor = int.Parse(TbNumber.Text);

            TbResult.Text = TbScan.Text.Substring(starttext, nuberofcharactor);
        }

        private async void button7_Click(object sender, EventArgs e)
        {


        }

        private async void SaveSetting()
        {
            try
            {

                using (var db = new AppDbContext())
                {
                    var pattern_no = int.Parse(cmbPatt.SelectedItem!.ToString()!);

                    var qr = new InputPattern()
                    {
                        Pattern_ID = pattern_no,
                        TotalOfCharactor = Convert.ToInt32(TbTotal.Text),
                        StartCharactor = Convert.ToInt32(TbStart.Text),
                        NumberOfCharactor = Convert.ToInt32(TbNumber.Text),
                        ExampleText = TbScan.Text,
                        Result = TbResult.Text,
                        UniqueStart = int.Parse(TbUq.Text),
                        UniqueText = TbUnqTxt.Text
                    };

                    var ptn = await db.InputPatterns.Where(x => x.Pattern_ID == pattern_no).FirstOrDefaultAsync();
                    if (ptn != null)
                    {
                        ptn.ExampleText = qr.ExampleText;
                        ptn.StartCharactor = qr.StartCharactor;
                        ptn.NumberOfCharactor = qr.NumberOfCharactor;
                        ptn.TotalOfCharactor = qr.TotalOfCharactor;
                        ptn.Result = qr.Result;
                        ptn.UniqueStart = qr.UniqueStart;
                        ptn.UniqueText = qr.UniqueText;
                        await db.SaveChangesAsync();
                    }
                    else
                    {
                        await db.InputPatterns.AddAsync(qr);
                        await db.SaveChangesAsync();
                    }
                }
                MessageBox.Show("Save data pattern completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Save data pattern error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TbScan_KeyUp(object sender, KeyEventArgs e)
        {
            int pos = TbScan.SelectionStart;
            Tblen.Text = pos.ToString();
        }

        private void TbScan_MouseUp(object sender, MouseEventArgs e)
        {
            int pos = TbScan.SelectionStart;
            Tblen.Text = pos.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSetting();
        }
    }
}
