namespace StockMonitoringCommunity.Models
{
    public class Product
    {
        public int Id { get; set; }   // PK auto
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        public int Stock { get; set; }      // ← เพิ่ม

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
