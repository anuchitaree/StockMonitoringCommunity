using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Models
{
    public class UiMessageTranscation
    {
        public string Key { get; init; } = string.Empty;   // เช่น "FORM_MAIN", "UC_LOGIN"
        public int Channel { get; init; }                
        public string? Direction { get; init; }          
        public string? Raw { get; init; }      
        public string? Partnumber { get; init; }
    }
}
