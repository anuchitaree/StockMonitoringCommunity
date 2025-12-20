using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringCommunity.Data
{
    public class InputPattern
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pattern_ID { get; set; }

        [Required]
        public int TotalOfCharactor { get; set; }

        [Required]
        public int StartCharactor { get; set; }

        [Required]
        public int NumberOfCharactor { get; set; }

        [StringLength(255)]
        public string? Result { get; set; }

        [StringLength(255)]
        public string? ExampleText { get; set; }

        public bool PatternCheck { get; set; } = false;
        public int UniqueStart { get; set; }

        public string? UniqueText { get; set; }

    }
}
