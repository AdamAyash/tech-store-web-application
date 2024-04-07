namespace TechStoreWebApplication.Repository.CategoryRepository
{
    using TechStoreWebApplication.Database;
    #region
    using TechStoreWebApplication.Models;
    #endregion

    /// <summary></summary>
    public class CategoryRepository : ICategoryRepository
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
		public TechStoreDbContext DbContext { get; set; }

		//-------------------------
		//Constructor/Destructor:
		//-------------------------
		public CategoryRepository(TechStoreDbContext dbContext)
		{
			DbContext = dbContext;
		}

		//-------------------------
		//Methods:
		//-------------------------

		//-------------------------
		//Overrides:
		//-------------------------
		public IEnumerable<Category> GetCategories()
		{
			return DbContext.Categories.ToList();
		}

		public Category? GetCategory(int ID)
		{
			return DbContext.Categories.FirstOrDefault(c => c.ID == ID);
		}
	}
}
