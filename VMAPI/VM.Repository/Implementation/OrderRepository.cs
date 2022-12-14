using Microsoft.EntityFrameworkCore;
using VM.Domain.Models;

namespace VM.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Order> entities;

        public OrderRepository(ApplicationDbContext context)
        {
            this._context = context;
            this.entities = context.Set<Order>();
        }

        public IEnumerable<Order> GetAll()
        {
            return entities.Include(x => x.Ingredients).ThenInclude(x => x.Ingredient).ThenInclude(x => x.MeasurementUnit).AsEnumerable();
        }

        public Order Get(Guid? id)
        {
            return entities.Include(x => x.Ingredients).ThenInclude(x => x.Ingredient).ThenInclude(x => x.MeasurementUnit).FirstOrDefault(e => e.Id == id);
        }

        public void Insert(Order entity)
        {
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Order entity)
        {
            entities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Order entity)
        {
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public bool Contains(Order order)
        {
            return entities.Any(x => x.Id == order.Id);
        }
    }
}
