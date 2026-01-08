using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockMonitoringCommunity.Data
{
    public class ServerConnection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,MaxLength(15)]
        public string ServerAddress { get; set; } = null!;

        public int Port { get; set; }

        [Required,MaxLength(50)]
        public string StoreID { get; set; } = null!;


        [Required,MaxLength(50)]
        public string SourcePCID { get; set; } = null!;
    }
}
