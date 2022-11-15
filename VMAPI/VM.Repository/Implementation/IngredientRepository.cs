using Microsoft.EntityFrameworkCore;
using VM.Domain.Models;

namespace VM.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Ingredient> entities;
        // private readonly IMapper _mapper;

        public IngredientRepository(ApplicationDbContext context)
        {
            this._context = context;
            this.entities = context.Set<Ingredient>();
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return entities.Include(x => x.Coffees).ThenInclude(x => x.Coffee).Include(x => x.MeasurementUnit).AsEnumerable();
        }

        public Ingredient Get(Guid? id)
        {
            return entities.Include(x => x.Coffees).ThenInclude(x => x.Coffee).FirstOrDefault(e => e.Id == id);
        }

        public void Insert(Ingredient entity)
        {
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Ingredient entity)
        {
            entities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Ingredient entity)
        {
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public Ingredient GetByName(string name)
        {
            return entities.FirstOrDefault(x => x.Title.ToLower() == name.ToLower());
        }
    }
}
