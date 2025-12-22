using Microsoft.EntityFrameworkCore;
using StockMonitoringCommunity.Data;
using StockMonitoringCommunity.Services;
using StockMonitoringCommunity.SubForm;

namespace StockMonitoringCommunity
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var db = new AppDbContext())
            {
                db.Database.Migrate(); // <-- ????? / update DB ?????????
            }

            var dbService = StockDatabase.Instance;

            ApplicationConfiguration.Initialize();
            //using (var login = new LoginForm())
            //{
            //    if (login.ShowDialog() == DialogResult.OK)
            //    {
                    Application.Run(new MainForm());
            //    }
            //}

            dbService.Dispose();
        }
    }
}