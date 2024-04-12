﻿namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public decimal PricePerPiece { get; set; }
        public Category Category { get; set; }
        public Guid BrandId { get; set; }
        //public  Brand? Brand { get; set; }
    }
}
