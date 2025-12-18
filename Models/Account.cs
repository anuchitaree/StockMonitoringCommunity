using System.ComponentModel.DataAnnotations;

namespace StockMonitoringCommunity.Models
{
    public class Account
    {
        [Key]
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
