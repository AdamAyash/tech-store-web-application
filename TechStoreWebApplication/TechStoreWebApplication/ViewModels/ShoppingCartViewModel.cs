using Microsoft.AspNetCore.Mvc.RazorPages;
using TechStoreWebApplication.Repository.ShoppingCart;

namespace TechStoreWebApplication.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IShoppingCart ShoppingCart { get; set; }

        public decimal ShoppingCartTotal { get; set; }

        public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal)
        {
            ShoppingCart = shoppingCart;
            ShoppingCartTotal = shoppingCartTotal;
        }
    }
}
