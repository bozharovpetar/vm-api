namespace VM.Domain.Models
{
    public class MeasurementUnit : Entity
    {
        public string Title { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
