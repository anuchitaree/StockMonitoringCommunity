using Microsoft.EntityFrameworkCore;
using StockMonitoringCommunity.Data;

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

            using (var db = new AppDbContext())
            {
                db.Database.Migrate(); // <-- ????? / update DB ?????????
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}