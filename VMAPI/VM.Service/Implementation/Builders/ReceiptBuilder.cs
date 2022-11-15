using VM.Domain.Models;
using VM.Repository;
using VM.Service.Interface;

namespace VM.Service.Implementation
{
    public class ReceiptBuilder : IBuilder
    {
        private Receipt _receipt = new Receipt();

        private readonly IIngredientRepository _ingredientRepository;
        private readonly ICoffeeRepository _coffeeRepository;

        public ReceiptBuilder(IIngredientRepository ingredientRepository, ICoffeeRepository coffeeRepository)
        {
            #region Initialize repositories
            _ingredientRepository = ingredientRepository;
            _coffeeRepository = coffeeRepository;
            #endregion

            Reset();
        }

        public void Reset()
        {
            _receipt = new Receipt();
        }

        public void SetIngredient(Guid ingredientId, int quantity)
        {
            var ingredient = _ingredientRepository.Get(ingredientId);
            if (ingredient != null)
            {
                _receipt.Ingredients.Add(ingredient);
                _receipt.TotalPrice += ingredient.Price * quantity;
            }
            else
            {
                return;
            }
        }

        public void SetIngredients(Guid coffeeId)
        {
            var coffee = _coffeeRepository.Get(coffeeId);
            if (coffee != null)
            {
                foreach (var entry in coffee.Ingredients)
                {
                    var ingredient = _ingredientRepository.Get(entry.IngredientId);
                    if (!_receipt.Ingredients.Any(x => x.Id == ingredient.Id))
                    {
                        _receipt.Ingredients.Add(ingredient);
                        _receipt.TotalPrice += ingredient.Price * entry.Quantity;
                    }
                }
            }
        }
    }
}
