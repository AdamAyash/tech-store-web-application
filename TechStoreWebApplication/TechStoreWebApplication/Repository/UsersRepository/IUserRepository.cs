namespace Repository
{
	#region
	using System;
	using TechStoreWebApplication.Models;
	using TechStoreWebApplication.Repository;
	#endregion
	public interface IUserRepository : IRepository
	{
        User GetUser(int id);
        IEnumerable<User> GetAllUser();
        void Add(User user);
        void Update(User userChanges);
        void Delete(int id);
    }
}
