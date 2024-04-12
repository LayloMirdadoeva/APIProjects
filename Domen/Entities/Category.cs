namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string CategoryType { get; set; } = string.Empty;
        public List<Product> Products { get; set; }
        public Guid ProductId { get; set; }
    }
}
