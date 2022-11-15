namespace VM.Domain.Models
{
    public class Ingredient : Entity
    {
        public string Title { get; set; }
        public int LeftInStock { get; set; }
        public int Price { get; set; }

        public Guid MeasurementUnitId { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }

        public virtual ICollection<CoffeeToIngredient> Coffees { get; set; }
        public virtual ICollection<OrderToIngredient> Orders { get; set; }

    }
}
