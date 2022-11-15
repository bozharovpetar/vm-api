using AutoMapper;
using VM.Domain.Models;
using VM.Repository;
using VM.Service.Implementation;

namespace VM.Service
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;
        private readonly ICoffeeRepository _coffeeRepository;
        private readonly IMapper _mapper;

        public IngredientService(IIngredientRepository ingredientRepository, ICoffeeRepository coffeeRepository, IMapper mapper)
        {
            _ingredientRepository = ingredientRepository;
            _coffeeRepository = coffeeRepository;
            _mapper = mapper;
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
