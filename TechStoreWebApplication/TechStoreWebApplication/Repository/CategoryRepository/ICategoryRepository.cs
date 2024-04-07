namespace TechStoreWebApplication.Repository.CategoryRepository
{
	#region
	using TechStoreWebApplication.Models;
	#endregion
	public interface ICategoryRepository : IRepository
	{
		public Category? GetCategory(int ID);
		public IEnumerable<Category> GetCategories();
 	}
}
