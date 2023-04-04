﻿namespace ProductApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Units { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
