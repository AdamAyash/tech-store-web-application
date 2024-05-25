using Microsoft.EntityFrameworkCore;
using System.IO.Pipelines;
using TechStoreWebApplication.Database;
using TechStoreWebApplication.Models;
using TechStoreWebApplication.Repository.ShoppingCart;

namespace TechStoreWebApplication.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly TechStoreDbContext _techStoreDbContext;

        public string? ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

        private ShoppingCart(TechStoreDbContext bethanysPieShopDbContext)
        {
            _techStoreDbContext = bethanysPieShopDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

            TechStoreDbContext context = services.GetService<TechStoreDbContext>() ?? throw new Exception("Error initializing");

            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session?.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product)
        {
            var shoppingCartItem =
                    _techStoreDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Product.ID == product.ID && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Quantity = 1
                };

                _techStoreDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }
            _techStoreDbContext.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem =
                    _techStoreDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Product.ID == product.ID && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity--;
                    localAmount = shoppingCartItem.Quantity;
                }
                else
                {
                    _techStoreDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _techStoreDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??=
                       _techStoreDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Product)
                           .ToList();
        }

        public void ClearCart()
        {
            var cartItems = _techStoreDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _techStoreDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _techStoreDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _techStoreDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Product.Price * c.Quantity).Sum();
            return (decimal)total;
        }
    }
}
