namespace VM.Domain.Models
{
    public class CoffeeToIngredient
    {
        public Guid CoffeeId { get; set; }
        public Coffee Coffee { get; set; }
        public Guid IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int Quantity { get; set; }
    }
}
