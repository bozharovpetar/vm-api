using Microsoft.EntityFrameworkCore;
using VM.Domain.Models;

namespace VM.Repository.Implementation
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Coffee> entities;

        public CoffeeRepository(ApplicationDbContext context)
        {
            this._context = context;
            this.entities = context.Set<Coffee>();
        }

        public IEnumerable<Coffee> GetAll()
        {
            return entities.Include(x => x.Ingredients).ThenInclude(x => x.Ingredient).AsEnumerable();
        }

        public Coffee Get(Guid? id)
        {
            return entities.Include(x=>x.Ingredients).ThenInclude(x => x.Ingredient).FirstOrDefault(e => e.Id == id);
        }

        public void Insert(Coffee entity)
        {
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Coffee entity)
        {
            entities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Coffee entity)
        {
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public Coffee GetByName(string name)
        {
            return entities.FirstOrDefault(x => x.Title.ToLower() == name.ToLower());
        }
    }
}
