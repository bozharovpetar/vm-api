using AutoMapper;
using VM.Domain.Models;
using VM.Repository;
using VM.Service.Implementation;

namespace VM.Service
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public List<IngredientDto> GetAllIngredients()
        {
            List<IngredientDto> result = new List<IngredientDto>();

            var ingredients = _ingredientRepository.GetAll();

            foreach (var ingredient in ingredients)
            {
                result.Add(ingredient.MapToIngredientDto());
            }

            return result;
        }

        public IngredientDto GetIngredientById(Guid id)
        {
            var ingredient = _ingredientRepository.Get(id);

            if (ingredient != null)
            {
                return ingredient.MapToIngredientDto();
            }
            else
            {
                return null;
            }
        }
    }
}
