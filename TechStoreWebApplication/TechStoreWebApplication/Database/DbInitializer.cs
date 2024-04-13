namespace TechStoreWebApplication.Database
{
    #region
    using TechStoreWebApplication.Models;
    using AutoDjambazi.Common;
	#endregion

	/// <summary></summary>
	public class DbInitializer
    {
        //-------------------------
        //Constants:
        //-------------------------

        //-------------------------
        //Members:
        //-------------------------

        //-------------------------
        //Properties:
        //-------------------------

        //-------------------------
        //Constructor/Destructor:
        //-------------------------

        //-------------------------
        //Methods:
        //-------------------------
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            TechStoreDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TechStoreDbContext>();

            if (!context.Categories.Any())
            {
                context.AddRange
                (
                    new Category() { Name = Messages.MSG_COMPUTER_CATEGORY }
                );
            }

			
				context.AddRange
				(
					new Product() { CategoryID = 1, ImageUrl= "https://ardes.bg/uploads/original/acer-aspire-7-performance-a715-76g-452578.jpg" },

					new Product() { CategoryID = 1, ImageUrl = "C:\\Users\\mobir\\Documents\\Projects\\tech-store-web-application\\TechStoreWebApplication\\TechStoreWebApplication\\wwwroot\\Images\\image.jpg" },

					new Product() { CategoryID = 1, ImageUrl = "C:\\Users\\mobir\\Documents\\Projects\\tech-store-web-application\\TechStoreWebApplication\\TechStoreWebApplication\\wwwroot\\Images\\image.jpg" },

					new Product() { CategoryID = 1, ImageUrl = "C:\\Users\\mobir\\Documents\\Projects\\tech-store-web-application\\TechStoreWebApplication\\TechStoreWebApplication\\wwwroot\\Images\\image.jpg" },

					new Product() { CategoryID = 1, ImageUrl = "C:\\Users\\mobir\\Documents\\Projects\\tech-store-web-application\\TechStoreWebApplication\\TechStoreWebApplication\\wwwroot\\Images\\image.jpg" }
				);

			context.SaveChanges();
        }

        //-------------------------
        //Overrides:
        //-------------------------
    }
}
