using TechStoreWebApplication.Database;

namespace TechStoreWebApplication.Repository
{
    #region
    #endregion

    public interface IRepository
	{
        public TechStoreDbContext DbContext { get; set; }
    }
}
