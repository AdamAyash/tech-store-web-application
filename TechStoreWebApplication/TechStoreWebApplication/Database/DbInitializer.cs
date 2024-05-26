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
					new Category() { Name = Messages.MSG_COMPUTER_CATEGORY },

                    new Category() { Name = "Телефони" },

                    new Category() { Name = "Процесори" },

                    new Category() { Name = "ВидеоКарти" }
                );
			}

			if (!context.Categories.Any())
			{
				context.AddRange
				(
					new Product() { CategoryID = 1,Name= "Лаптоп Acer Nitro V16 ANV16-41-R3MD", ImageUrl = "https://ardes.bg/uploads/original/acer-nitro-v16-anv16-41-529298.jpg", Price=2199d },
                    new Product() { CategoryID = 1, Name = "Лаптоп Lenovo V15 G3 IAP", ImageUrl = "https://ardes.bg/uploads/original/lenovo-v15-g3-432234.jpg", Price = 949d },
                    new Product() { CategoryID = 1, Name = "Лаптоп HP ZBook Fury 15 G8", ImageUrl = "https://ardes.bg/uploads/original/hp-zbook-fury-15-g7-300512.jpg", Price = 2499d }
                );
			}

			context.SaveChanges();
		}

		//-------------------------
		//Overrides:
		//-------------------------
	}
}
