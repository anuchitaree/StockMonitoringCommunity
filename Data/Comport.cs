using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringCommunity.Data
{
    public class Comport
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Channel_ID { get; set; }

        [StringLength(50)]
        public string PortName { get; set; } = null!;
        [StringLength(50)]
        public string Baudrate { get; set; } = null!;
        [StringLength(50)]
        public string Parity { get; set; } = null!;

        [StringLength(50)]
        public string DataBits { get; set; } = null!;
        [StringLength(50)]
        public string Stopbit { get; set; } = null!;
        [StringLength(50)]
        public string Direction { get; set; } = null!;

        [StringLength(50)]
        public string Handshake { get; set; } = null!;


        public int Pattern1 { get; set; }
        public int Pattern2 { get; set; }
        public int Pattern3 { get; set; }
        public int Pattern4 { get; set; }
        public int Pattern5 { get; set; }
        public int Pattern6 { get; set; }

        public DateTimeOffset CreatedAt  { get; set; }

        public bool Enable { get; set; } = false;

    }
}
