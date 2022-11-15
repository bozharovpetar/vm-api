using System.Text;

namespace VM.Domain.Models
{
    public class Receipt
    {
        public DateTime Date { get; set; }
        public string Code { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public int TotalPrice { get; set; }

        public Receipt()
        {
            Ingredients = new List<Ingredient>();
            TotalPrice = 0;
        }

        public string PrintReceipt()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order completed! Date of order: {Date.ToString()}");
            sb.AppendLine($"Total price: {TotalPrice}");
            sb.AppendLine($"Thank you for your purchase!");
            return sb.ToString();
        }
    }
}
