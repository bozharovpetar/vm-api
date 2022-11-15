using VM.Domain.Models;

namespace VM.Repository
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T Get(Guid? id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
