using VM.Domain.Models;
using VM.Service.Interface;

namespace VM.Service
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildCustomCoffee(CustomCoffeeDto model)
        {
            foreach(var ingredient in model.Ingredients)
            {
                _builder.SetIngredient(ingredient.IngredientId, ingredient.Quantity);
            }
        }

        public void BuildPredefinedCoffee(Guid coffeeId)
        {
            _builder.SetIngredients(coffeeId);
        }
    }
}