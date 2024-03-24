using System;

    namespace TechStoreWebApplication.Models
{
    public interface IUserRepository
    {
        User GetUser(int Id);
        IEnumerable<User> GetAllUser();
        User Add(User user);
        User Update(User userChanges);
        User Delete(int id);
    }
}
