namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public decimal PricePerPiece { get; set; }
        public Category Categorys { get; set; }
        public Guid CategoryId { get; set; }
        public Brand Brands { get; set; }
        public Guid BrandId { get; set; }

       
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
