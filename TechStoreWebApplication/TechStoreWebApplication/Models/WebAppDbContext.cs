namespace TechStoreWebApplication.Models
{
    #region
    using Microsoft.EntityFrameworkCore;
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

