using AutoMapper;
using VM.Domain.Models;
using VM.Repository;
using VM.Service.Implementation;

namespace VM.Service
{
    public class CoffeeService : ICoffeeService
    {
        private readonly IIngredientRepository _ingredientRepository;
        private readonly ICoffeeRepository _coffeeRepository;
        private readonly IMapper _mapper;

        public CoffeeService(IIngredientRepository ingredientRepository, ICoffeeRepository coffeeRepository, IMapper mapper)
        {
            _ingredientRepository = ingredientRepository;
            _coffeeRepository = coffeeRepository;
            _mapper = mapper;
        }

        public List<CoffeeLookupDto> GetAllCoffees()
        {
            List<CoffeeLookupDto> result = new List<CoffeeLookupDto>();

            var coffees = _coffeeRepository.GetAll();
            foreach (var coffee in coffees)
            {
                var entry = _mapper.Map<CoffeeLookupDto>(coffee);

                int price = 0;

                foreach (var ingredient in coffee.Ingredients)
                {
                    var entity = _ingredientRepository.Get(ingredient.IngredientId);
                    if (entity != null)
                    {
                        price += entity.Price * ingredient.Quantity;
                    }
                }

                entry.Price = price;

                result.Add(entry);
            }

            return result;
        }

        public CoffeeDto GetCoffeeById(Guid id)
        {
            var entity = _coffeeRepository.Get(id);
            if (entity != null)
            {
                CoffeeDto result = new CoffeeDto();
                result.Id = entity.Id;
                result.Title = entity.Title;
                foreach (var entry in entity.Ingredients)
                {
                    var ingredient = _ingredientRepository.Get(entry.IngredientId);
                    if (ingredient != null)
                    {
                        result.Ingredients.Add(ingredient.MapToIngredientDto());
                    }
                }

                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
