﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Domain.Models
{
    public class MeasurementUnit : Entity
    {
        public string Title { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
