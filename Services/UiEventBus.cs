using StockMonitoringCommunity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Services
{
    public static class UiEventBus
    {
        public static event Action<UiMessage>? MessagePublished;

        public static event Action<UiMessageTranscation>? MessagePublishedTranscation;
        public static void Publish(string key, object? data = null,object? extradata=null,object? moreExtraData=null)
        {
            MessagePublished?.Invoke(new UiMessage
            {
                Key = key,
                Data = data,
                ExtraData=extradata,
                MoreExtraData = moreExtraData,
                
            });
        }

        public static void PublishTransaction(string key, int channel, string? direction, string? raw,string? partnumber)
        {
            MessagePublishedTranscation?.Invoke(new UiMessageTranscation
            {
                Key = key,
                Channel = channel,
                Direction = direction,
                Raw = raw,
                Partnumber=partnumber,

            });
        }
    }

}
