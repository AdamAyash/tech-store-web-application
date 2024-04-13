

namespace TechStoreWebApplication.Repository.ProductRepository
{
	#region
	using TechStoreWebApplication.Models;
	#endregion

	/// <summary></summary>
	public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProduct();
        public Product? GetProductByID(int nId);
		public IEnumerable<Product> GetProductsByCategoryID(int nId);
	}
}
