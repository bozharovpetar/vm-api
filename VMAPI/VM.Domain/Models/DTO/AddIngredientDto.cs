﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Domain.Models
{
    public class AddIngredientDto
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
    }
}
