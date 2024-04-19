namespace TechStoreWebApplication.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string? ShoppingCartId { get; set; }
    }
}
