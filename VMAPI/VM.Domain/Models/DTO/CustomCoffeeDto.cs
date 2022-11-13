using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Domain.Models
{
    public class CustomCoffeeDto
    {
        public List<AddIngredientDto> Ingredients { get;set; }

        public CustomCoffeeDto()
        {
            Ingredients = new List<AddIngredientDto>();
        }
    }
}
