using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMonitoringCommunity.Data
{
    public class AccumulateStockLog
    {
        [Key]
        public int AccumulateStockLog_ID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required, MaxLength(50)]
        public string? Partnumber { get; set; }

        public int Balance { get; set; } = 0;
       
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
