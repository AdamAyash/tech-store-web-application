using TechStoreWebApplication.Models;

namespace TechStoreWebApplication.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; } = default!;
        public Order Order { get; set; } = default!;
    }
}
