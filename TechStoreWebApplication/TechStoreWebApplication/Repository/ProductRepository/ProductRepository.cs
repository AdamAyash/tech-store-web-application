namespace TechStoreWebApplication.Repository.ProductRepository
{
	using TechStoreWebApplication.Database;
	#region
	using TechStoreWebApplication.Models;
	#endregion

	/// <summary></summary>
	public class ProductRepository : IProductRepository
	{
		//-------------------------
		//Constants:
		//-------------------------

		//-------------------------
		//Members:
		//-------------------------
		private readonly TechStoreDbContext techStoreDbContext;

		//-------------------------
		//Properties:
		//-------------------------

		//-------------------------
		//Constructor/Destructor:
		//-------------------------
		public ProductRepository(TechStoreDbContext techStoreDbContext)
        {
            this.techStoreDbContext = techStoreDbContext;

		}

        //-------------------------
        //Methods:
        //-------------------------

        //-------------------------
        //Overrides:
        //-------------------------

        public IEnumerable<Product> GetAllProduct()
		{
			return techStoreDbContext.Products.ToList();
		}

		public IEnumerable<Product> GetProductsByCategoryID(int nId)
		{
			return techStoreDbContext.Products.Where(p => p.CategoryID == nId);
		}

		public Product? GetProductByID(int nId)
		{
			return techStoreDbContext.Products.FirstOrDefault(p => p.ID == nId);
		}
		
	}
}
