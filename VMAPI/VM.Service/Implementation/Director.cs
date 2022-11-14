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

        public void BuildCustomCoffee(List<AddIngredientDto> ingredients)
        {
            foreach(var ingredient in ingredients)
            {
                _builder.SetIngredient(ingredient.Id, ingredient.Quantity);
            }
        }

        public void BuildPredefinedCoffee(Guid coffeeId)
        {
            _builder.SetIngredients(coffeeId);
        }
    }
}