using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoringCommunity.Models
{
    public class ScanList
    {
        public int Id { get; set; }
        public string? Channel { get; set; }
        public string? Raw { get; set; }
        public string? Partnumber { get; set; }
        public string? Timestamp { get; set; }
    }

    //public class ScanList
    //{
    //    public List<Scan> ScanLists { get; set; } = new List<Scan>();
        
    //}


}
