using TechStoreWebApplication.Database;

namespace TechStoreWebApplication.Repository
{
    #region
    #endregion

    public interface IRepository
	{
        public WebAppDbContext DbContext { get; set; }
    }
}
