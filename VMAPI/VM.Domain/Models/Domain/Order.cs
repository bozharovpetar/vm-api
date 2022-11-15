namespace VM.Domain.Models
{
    public class Order : Entity
    {
        public Guid? CoffeeId { get; set; }
        public Coffee? Coffee { get; set; }

        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }

        public virtual ICollection<OrderToIngredient> Ingredients { get; set; }
    }
}
