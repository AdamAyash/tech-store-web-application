namespace TechStoreWebApplication.Database
{
    #region
    using Microsoft.EntityFrameworkCore;
    using TechStoreWebApplication.Models;
    #endregion

    /// <summary></summary>
    public class WebAppDbContext : DbContext
    {
        //-------------------------
        //Constants:
        //-------------------------

        //-------------------------
        //Members:
        //-------------------------
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        //-------------------------
        //Properties:
        //-------------------------

        //-------------------------
        //Constructor/Destructor:
        //-------------------------
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options)
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

