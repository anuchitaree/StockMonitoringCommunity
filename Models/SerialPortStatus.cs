namespace StockMonitoringCommunity.Models
{
    public class SerialPortStatus
    {
        public List<PortStatus> PortStatuses { get; set; }=new List<PortStatus>();

    }

    public class PortStatus
    {
        public int Channel { get; set; }
        public bool Status { get; set; }
        public string? Setting { get; set; }
        public string? Raw { get; set; }
        public string? Datain { get; set; }
    }
}
