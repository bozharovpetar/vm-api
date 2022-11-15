namespace VM.Domain.Models
{
    public class CoffeeDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<IngredientDto> Ingredients { get; set; }

        public CoffeeDto()
        {
            Ingredients = new List<IngredientDto>();
        }
    }
}
