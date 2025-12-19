using StockMonitoringCommunity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Services
{
    public static class UiEventBus
    {
        public static event Action<UiMessage>? MessagePublished;

        public static void Publish(string key, object? data = null,object? extradata=null,object? moreExtraData=null)
        {
            MessagePublished?.Invoke(new UiMessage
            {
                Key = key,
                Data = data,
                ExtraData=extradata,
                MoreExtraData = moreExtraData
            });
        }
    }

}
