namespace TechStoreWebApplication.Models
{
    #region
    using Microsoft.EntityFrameworkCore;
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

