using Microsoft.EntityFrameworkCore;
using StockMonitoringCommunity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Data
{
    public class AppDbContext : DbContext
    {
        //public DbSet<Product> Products => Set<Product>();

        public DbSet<Comport> Comports  => Set<Comport>();
        public DbSet<InputPattern> InputPatterns => Set<InputPattern>();






        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(
                "Host=localhost;Port=5432;Database=stock_db;Username=postgres;Password=postgres"
            );
        }
    }
}
