using Microsoft.AspNetCore.Mvc;
using TechStoreWebApplication.Repository.ProductRepository;
using TechStoreWebApplication.Repository.ShoppingCart;
using TechStoreWebApplication.ViewModels;

namespace TechStoreWebApplication.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IShoppingCart shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, IShoppingCart shoppingCart)
        {
            this.productRepository = productRepository;
            this.shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel(shoppingCart, shoppingCart.GetShoppingCartTotal());

            return View(shoppingCartViewModel);
        }
    }
}
