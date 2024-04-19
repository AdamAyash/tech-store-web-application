using TechStoreWebApplication.Models;

namespace TechStoreWebApplication.Repository.ShoppingCart
{
    public interface IShoppingCart
    {
        void AddToCart(Product product);
        int RemoveFromCart(Product product);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
