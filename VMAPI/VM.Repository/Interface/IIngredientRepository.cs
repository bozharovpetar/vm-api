using VM.Domain.Models;

namespace VM.Repository
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
        Ingredient GetByName(string name);
    }
}
