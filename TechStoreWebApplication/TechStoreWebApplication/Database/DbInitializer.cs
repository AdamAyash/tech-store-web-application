﻿namespace TechStoreWebApplication.Database
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

            context.SaveChanges();
        }

        //-------------------------
        //Overrides:
        //-------------------------
    }
}