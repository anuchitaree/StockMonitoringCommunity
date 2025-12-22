using StockMonitoringCommunity.Data;
using StockMonitoringCommunity.Models;

namespace StockMonitoringCommunity.Services
{
    public sealed  class StockDatabase : IDisposable
    {
        private static readonly Lazy<StockDatabase> _instance =
         new(() => new StockDatabase());

        public static StockDatabase Instance => _instance.Value;

        private StockDatabase()
        {
            UiEventBus.MessagePublishedTranscation += OnMessageTransaction;
        }

        public void Dispose()
        {
            UiEventBus.MessagePublishedTranscation -= OnMessageTransaction;
        }

       

        private void OnMessageTransaction(UiMessageTranscation msg)
        {
            if (msg.Key != UiKeys.TransactionAdd)
                return;

            if (msg is not UiMessageTranscation p)
                return;

            Task.Run(() => SaveTransaction(p));
        }


        private void SaveTransaction(UiMessageTranscation p)
        {
            using var db = new AppDbContext();

            var transaction = new ScanInOutTransaction
            {
                Channel = p.Channel,
                Direction = p.Direction,
                Raw = p.Raw!,
                CreatedAt = DateTime.UtcNow
            };

            db.ScanInOutTransactions.Add(transaction);
            db.SaveChanges();
        }


    }
}
