namespace Domain.Entities
{
    public class Cart
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public Customer Customer { get; set; }
    }
}
