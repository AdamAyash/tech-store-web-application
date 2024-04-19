using TechStoreWebApplication.Database;
using TechStoreWebApplication.Models;

namespace TechStoreWebApplication.Repository.ShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly TechStoreDbContext techStoreDbContext;
        public ShoppingCart(TechStoreDbContext techStoreDbContext)
        {
            this.techStoreDbContext = techStoreDbContext;
        }

        public string  ShoppingCartId { get; private set; }

        public List<ShoppingCartItem> ShoppingCartItems
        {
            get
            {
                return techStoreDbContext.ShoppingCartItems.ToList();
            }

            set
            {
                this.ShoppingCartItems = value;
            }
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>
                ()?.HttpContext?.Session;

            TechStoreDbContext context = services.GetService<TechStoreDbContext>() ?? 
                throw new Exception("Error initializing");

            string cartID = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session?.SetString("CartId", cartID);

            return new ShoppingCart(context) { ShoppingCartId = cartID };
        }

        public void AddToCart(Product product)
        {
            throw new NotImplementedException();
        }

        public void ClearCart()
        {

        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            throw new NotImplementedException();
        }

        public decimal GetShoppingCartTotal()
        {
            throw new NotImplementedException();
        }

        public int RemoveFromCart(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
