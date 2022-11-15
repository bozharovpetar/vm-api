using Microsoft.EntityFrameworkCore;
using VM.Domain.Models;

namespace VM.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> entities;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            this.entities = context.Set<T>();
        }

        public T Get(Guid? id)
        {
            return entities.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            entities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
