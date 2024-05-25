using TechStoreWebApplication.Database;
using TechStoreWebApplication.Models;
using TechStoreWebApplication.Repository.ShoppingCart;

namespace TechStoreWebApplication.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly TechStoreDbContext _bethanysPieShopDbContext;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(TechStoreDbContext bethanysPieShopDbContext, IShoppingCart shoppingCart)
        {
            _bethanysPieShopDbContext = bethanysPieShopDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Quantity,
                    ProductID = shoppingCartItem.Product.ID,
                    Price = (decimal)shoppingCartItem.Product.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _bethanysPieShopDbContext.Orders.Add(order);

            _bethanysPieShopDbContext.SaveChanges();
        }
    }
}
