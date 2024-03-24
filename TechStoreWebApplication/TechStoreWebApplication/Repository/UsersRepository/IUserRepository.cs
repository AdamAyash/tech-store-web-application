using System;
using TechStoreWebApplication.Models;

namespace Repository
{
    public interface IUserRepository
    {
        User GetUser(int id);
        IEnumerable<User> GetAllUser();
        void Add(User user);
        void Update(User userChanges);
        void Delete(int id);
    }
}
