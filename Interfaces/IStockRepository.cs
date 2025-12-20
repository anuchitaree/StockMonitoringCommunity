using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Interfaces
{
    public interface IStockRepository
    {
        Task<int> GetStockCountAsync(string itemCode);

    }
}
