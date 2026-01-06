using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockMonitoringCommunity.Data
{
    public class Packaging
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Packaging_Id { get; set; }

        [Required,MaxLength(50)]
        public string StoreID { get; set; } = "";

        [Required,MaxLength(50)]
        public string Partnumber { get; set; } = "";

        [Required,MaxLength(50)]
        public string Direction { get; set; } = "";

        public int Channel { get; set; } = 0;

        public int PerScantimes { get; set; }






    }
}
