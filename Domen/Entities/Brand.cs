namespace Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public DateTime FoundedYear { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
