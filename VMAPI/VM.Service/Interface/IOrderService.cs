using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.Domain.Models;

namespace VM.Service.Interface
{
    public interface IOrderService
    {
        OrderDto GetOrderById(Guid id);
        Guid PlaceCoffeeOrder(Guid coffeeId);
        Guid PlaceCustomCoffeeOrder(List<AddIngredientDto> ingredients);
    }
}
