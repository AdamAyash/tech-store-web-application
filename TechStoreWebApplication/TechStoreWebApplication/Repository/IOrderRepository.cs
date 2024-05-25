using TechStoreWebApplication.Models;

namespace TechStoreWebApplication.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
