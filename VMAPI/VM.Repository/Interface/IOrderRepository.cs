using VM.Domain.Models;

namespace VM.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        bool Contains(Order order);
    }
}
