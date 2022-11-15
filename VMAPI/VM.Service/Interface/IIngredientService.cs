using VM.Domain.Models;

namespace VM.Service
{
    public interface IIngredientService
    {
        List<IngredientDto> GetAllIngredients();
        IngredientDto GetIngredientById(Guid id);
    }
}
