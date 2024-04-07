namespace TechStoreWebApplication.Database
{
    using TechStoreWebApplication.Models;
    #region
    using System.IO.Pipelines;
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
            WebAppDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<WebAppDbContext>();

            if (!context.Categories.Any())
            {
                context.AddRange
                (
                    new Category() { Name = Messages.MSG_COMPUTER_CATEGORY }
                );
            }

            context.SaveChanges();
        }

        //-------------------------
        //Overrides:
        //-------------------------
    }
}
