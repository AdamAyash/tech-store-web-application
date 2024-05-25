namespace TechStoreWebApplication.Database
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    #region
    using Microsoft.EntityFrameworkCore;
    using TechStoreWebApplication.Models;
    #endregion

    /// <summary></summary>
    public class TechStoreDbContext : IdentityDbContext
    {
        //-------------------------
        //Constants:
        //-------------------------

        //-------------------------
        //Members:
        //-------------------------
        public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        //-------------------------
        //Properties:
        //-------------------------

        //-------------------------
        //Constructor/Destructor:
        //-------------------------
        public TechStoreDbContext(DbContextOptions<TechStoreDbContext> options)
            : base(options)
        {
        }

        //-------------------------
        //Methods:
        //-------------------------

        //-------------------------
        //Overrides:
        //-------------------------
    }
}

