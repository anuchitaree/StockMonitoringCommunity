using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockMonitoringCommunity.Data
{
    public class ScanInOutTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Channel { get; set; } = 0;

        [MaxLength(50)]
        public string? Direction { get; set; } = null!;

        [MaxLength(255)]
        public string Raw { get; set; } = "";

        [MaxLength(50)]
        public string Partnumber { get; set; } = "";

        public DateTimeOffset CreatedAt { get; set; }

        public bool IsProcessed { get; set; } = false;
    }
}
