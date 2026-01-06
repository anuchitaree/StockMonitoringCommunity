using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockMonitoringCommunity.Data
{
    public class MasterStock
    {
        [Key]
        public int MasterStock_Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required,MaxLength(50)]
        public string? Partnumber { get; set; }

        public string StoreID { get; set; } = "";

        [MaxLength(150)]
        public string Description { get; set; } = "";

        [MaxLength(255)]
        public string Location { get; set; } = "";
        public int Balance { get; set; } = 0;
        public int UpperLimit { get; set; } = 0;
        public int UpperWarningLimit { get; set; } = 0;
        public int LowerWarningLimit { get; set; } = 0;
        public int LowerLimit { get; set; } = 0;
        public DateTimeOffset CreatedAt { get; set; }= DateTimeOffset.UtcNow;

        public bool Invisible { get;set; }= false;
    }
}
