using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringCommunity.Interfaces
{
    public interface IMessageReceiver
    {
        void OnMessage(string topic, object data);
    }
}
