using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.Domain.Models;
using VM.Repository;
using VM.Service.Interface;

namespace VM.Service.Implementation
{
    public class CoffeeBuilder : IBuilder
    {
        private Order _order = new Order();
        private readonly IIngredientRepository _ingredientRepository;
        private readonly ICoffeeRepository _coffeeRepository;

        public CoffeeBuilder(IIngredientRepository ingredientRepository, ICoffeeRepository coffeeRepository)
        {
            #region Initialize repositories
            _ingredientRepository = ingredientRepository;
            _coffeeRepository = coffeeRepository;
            #endregion

            Reset();
        }

        public void Reset()
        {
            _order = new Order();
            _order.Ingredients = new List<OrderToIngredient>();
        }

        public void SetIngredient(Guid ingredientId, int quantity)
        {
            _order.Date = DateTime.Now;
            var ingredient = _ingredientRepository.Get(ingredientId);
            if (ingredient != null)
            {
                if (!_order.Ingredients.Any(x => x.IngredientId == ingredient.Id))
                {
                    _order.Ingredients.Add(new OrderToIngredient { IngredientId = ingredient.Id, OrderId = _order.Id, Quantity = quantity });
                }
                else
                {
                    _order.Ingredients.FirstOrDefault(x => x.IngredientId == ingredient.Id).Quantity += quantity;
                }

                _order.TotalPrice += ingredient.Price * quantity;
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
                _order.Coffee = coffee;
                _order.CoffeeId = coffeeId;
                _order.Date = DateTime.Now;
                var price = 0;
                foreach (var entry in coffee.Ingredients)
                {
                    var ingredient = _ingredientRepository.Get(entry.IngredientId);
                    if (!_order.Ingredients.Any(x => x.IngredientId == ingredient.Id))
                    {
                        _order.Ingredients.Add(new OrderToIngredient { IngredientId = ingredient.Id, OrderId = _order.Id, Quantity = entry.Quantity });
                    }
                    else
                    {
                        _order.Ingredients.FirstOrDefault(x => x.IngredientId == ingredient.Id).Quantity += entry.Quantity;
                    }
                }

                foreach(var ingredient in _order.Ingredients)
                {
                    var entity = _ingredientRepository.Get(ingredient.IngredientId);
                    price += entity.Price * ingredient.Quantity;
                }

                _order.TotalPrice= price;
            }
        }

        public Order GetOrder()
        {
            Order result = _order;

            Reset();

            return result;
        }
    }
}
