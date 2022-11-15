namespace VM.Domain.Models
{
    public class Coffee : Entity
    {
        public string Title { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CoffeeToIngredient> Ingredients { get; set; }
    }
}
