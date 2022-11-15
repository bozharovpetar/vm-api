namespace VM.Domain.Models
{
    public class OrderToIngredient
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int Quantity { get; set; }
    }
}
