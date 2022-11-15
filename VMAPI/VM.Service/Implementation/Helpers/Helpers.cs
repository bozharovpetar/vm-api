using VM.Domain.Models;

namespace VM.Service.Implementation
{
    public static class Helpers
    {
        public static IngredientDto MapToIngredientDto(this Ingredient ingredient)
        {
            IngredientDto coffeeIngredient = new IngredientDto();
            coffeeIngredient.Id = ingredient.Id;
            coffeeIngredient.Title = ingredient.Title;
            coffeeIngredient.Price = ingredient.Price;
            coffeeIngredient.LeftInStock = ingredient.LeftInStock;
            coffeeIngredient.MeasurementUnit = ingredient.MeasurementUnit.Title;

            return coffeeIngredient;
        }

        public static OrderIngredientDto MapToOrderIngredientDto(this Ingredient ingredient)
        {
            OrderIngredientDto coffeeIngredient = new OrderIngredientDto();
            coffeeIngredient.Id = ingredient.Id;
            coffeeIngredient.Title = ingredient.Title;
            coffeeIngredient.Price = ingredient.Price;
            coffeeIngredient.MeasurementUnit = ingredient.MeasurementUnit.Title;

            return coffeeIngredient;
        }

        public static OrderDto MapToOrderDto(this Order order)
        {
            OrderDto orderDto = new OrderDto();
            orderDto.Id = order.Id;
            orderDto.Price = order.TotalPrice;
            orderDto.Date = order.Date;

            return orderDto;
        }
    }
}
