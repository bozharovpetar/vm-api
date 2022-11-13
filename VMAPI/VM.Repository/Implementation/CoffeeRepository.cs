using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.Domain.Models;

namespace VM.Repository.Implementation
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private readonly ApplicationDbContext _context;
        private DbSet<Coffee> entities;

        public IEnumerable<Coffee> GetAll()
        {
            return entities.AsEnumerable();
        }

        public Coffee Get(Guid? id)
        {
            return entities.FirstOrDefault(e => e.Id == id);
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
