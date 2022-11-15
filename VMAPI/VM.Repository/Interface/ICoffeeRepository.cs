using VM.Domain.Models;

namespace VM.Repository
{
    public interface ICoffeeRepository : IRepository<Coffee>
    {
        Coffee GetByName(string name);
    }
}
