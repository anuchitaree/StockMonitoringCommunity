using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockMonitoringCommunity.Data
{
    public class Store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Store_Id { get; set; }

        [Required, MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StoreID { get; set; } = null!;

        [Required, MaxLength(100)]
        public string StoreName { get; set; } = null!;

        [Required, MaxLength(100)]
        public string StoreLocation { get; set; } = null!;
    }
}
