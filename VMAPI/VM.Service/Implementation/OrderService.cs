using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.Domain.Models;
using VM.Repository;
using VM.Service.Implementation;
using VM.Service.Interface;

namespace VM.Service
{
    public class OrderService : IOrderService
    {
        private readonly IIngredientRepository _ingredientRepository;
        private readonly ICoffeeRepository _coffeeRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IIngredientRepository ingredientRepository, ICoffeeRepository coffeeRepository, IOrderRepository orderRepository, IMapper mapper)
        {
            _ingredientRepository = ingredientRepository;
            _coffeeRepository = coffeeRepository;
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public OrderDto GetOrderById(Guid id)
        {
            var order = _orderRepository.Get(id);
            if (order != null)
            {
                OrderDto result = order.MapToOrderDto();
                foreach (var ingredient in order.Ingredients)
                {
                    var entity = _ingredientRepository.Get(ingredient.IngredientId);
                    if (entity != null)
                    {
                        result.Ingredients.Add(entity.MapToIngredientDto());
                    }
                }

                return result;
            }
            else
            {
                return null;
            }
        }

        public bool PlaceCoffeeOrder(Guid coffeeId)
        {
            var director = new Director();
            var builder = new CoffeeBuilder(_ingredientRepository, _coffeeRepository);

            director.Builder = builder;

            director.BuildPredefinedCoffee(coffeeId);

            var newOrder = builder.GetOrder();

            if (newOrder != null)
            {
                if (!_orderRepository.Contains(newOrder))
                {
                    _orderRepository.Insert(newOrder);
                    return true;
                }
            }

            return false;
        }

        public bool PlaceCustomCoffeeOrder(List<AddIngredientDto> ingredients)
        {
            var director = new Director();
            var builder = new CoffeeBuilder(_ingredientRepository, _coffeeRepository);

            director.Builder = builder;

            director.BuildCustomCoffee(ingredients);

            var newOrder = builder.GetOrder();

            if (newOrder != null)
            {
                if (!_orderRepository.Contains(newOrder))
                {
                    _orderRepository.Insert(newOrder);
                    return true;
                }
            }

            return false;
        }
    }
}
