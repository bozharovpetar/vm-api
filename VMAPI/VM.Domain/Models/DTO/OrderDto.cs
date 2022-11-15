namespace VM.Domain.Models
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public List<OrderIngredientDto> Ingredients { get; set; }

        public OrderDto()
        {
            Ingredients = new List<OrderIngredientDto>();
        }
    }
}
