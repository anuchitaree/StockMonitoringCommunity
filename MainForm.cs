using StockMonitoringCommunity.Data;
using StockMonitoringCommunity.Models;

namespace StockMonitoringCommunity
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                db.Products.Add(new Product
                {
                    Name = "Keyboard",
                    Price = 1290
                });
                db.SaveChanges();
            }
        }
    }
}
