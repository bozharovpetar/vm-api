namespace VM.Domain.Models
{
    public class IngredientDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int LeftInStock { get; set; }
        public int Price { get; set; }
        public string MeasurementUnit { get; set; }
    }
}
