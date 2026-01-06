using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Data
{
    public class AppDbContext : DbContext
    {
        //public DbSet<Product> Products => Set<Product>();
        //public AppDbContext(DbContextOptions<AppDbContext> options)
        //: base(options)
        //{
        //}


        public DbSet<Comport> Comports  => Set<Comport>();
        public DbSet<InputPattern> InputPatterns => Set<InputPattern>();
        public DbSet<ScanInOutTransaction> ScanInOutTransactions => Set<ScanInOutTransaction>();
        public DbSet<MasterStock> MasterStocks => Set<MasterStock>();
        public DbSet<AccumulateStockLog> AccumulateStockLogs => Set<AccumulateStockLog>();

        public DbSet<Packaging> Packagings => Set<Packaging>();



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(
                "Host=localhost;Port=5432;Database=stock_db;Username=postgres;Password=postgres"
            );
        }
    }
}
