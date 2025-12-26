namespace StockMonitoringCommunity.Models
{
    public class LogState
    {
        public string? ID { get; set; }
        public int Channel { get; set; }
        public string Direction { get; set; } = "";

        public string Raw { get; set; } = "";
        public DateTime Datetime { get; set; } = DateTime.UtcNow;
        public int Pattern_1 { get; set; }
        public int Pattern_2 { get; set; }
        public int Pattern_3 { get; set; }
        public int Pattern_4 { get; set; }
        public int Pattern_5 { get; set; }
        public int Pattern_6 { get; set; }

        public string Partnumber { get; set; } = "";
    }

}
