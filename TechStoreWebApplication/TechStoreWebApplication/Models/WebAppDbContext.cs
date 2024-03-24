using Microsoft.EntityFrameworkCore;

namespace TechStoreWebApplication.Models
{
    public class WebAppDbContext : DbContext
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<User> Users {  get; set; }

    }
}

