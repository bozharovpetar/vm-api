using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Domain.Models
{
    public class Coffee : Entity
    {
        public string Title { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CoffeeToIngredient> Ingredients { get; set; }
    }
}
