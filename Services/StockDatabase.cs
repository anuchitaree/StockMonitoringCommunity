using StockMonitoringCommunity.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Services
{
    public class StockDatabase
    {
        public  StockDatabase()
        {
            // Implementation for connecting to the stock database
        }

        public async void AddStock(ScanInOutTransaction data)
        {
            using (var db = new AppDbContext())
            {
                await db.ScanInOutTransactions.AddAsync(data);
                await db.SaveChangesAsync();
            }
        }


    }
}
