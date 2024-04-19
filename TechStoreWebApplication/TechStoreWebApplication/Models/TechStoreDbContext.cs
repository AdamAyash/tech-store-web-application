namespace TechStoreWebApplication.Database
{
    #region
    using Microsoft.EntityFrameworkCore;
    using TechStoreWebApplication.Models;
    #endregion

    /// <summary></summary>
    public class TechStoreDbContext : DbContext
    {
        //-------------------------
        //Constants:
        //-------------------------

        //-------------------------
        //Members:
        //-------------------------
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

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

