using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Domain.Models
{
    public class CoffeeLookupDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
