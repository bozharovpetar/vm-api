﻿namespace VM.Domain.Models
{
    public  class OrderIngredientDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string MeasurementUnit { get; set; }
    }
}
