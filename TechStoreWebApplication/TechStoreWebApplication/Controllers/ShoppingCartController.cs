using Microsoft.AspNetCore.Mvc;
using TechStoreWebApplication.Models;
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

        public RedirectToActionResult AddToShoppingCart(int prodcutId)
        {
            var selectedPie = productRepository.GetAllProduct().FirstOrDefault(p => p.ID  == prodcutId);

            if (selectedPie != null)
            {
                shoppingCart.AddToCart(selectedPie);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int id)
        {
            var selectedProduct = productRepository.GetAllProduct().FirstOrDefault(p => p.ID == id);

            if (selectedProduct != null)
            {
                shoppingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }
    }
}
