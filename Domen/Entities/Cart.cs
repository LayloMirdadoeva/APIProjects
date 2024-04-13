namespace Domain.Entities
{
    public class Cart : BaseEntity //Cart - это корзина 
    {
        public Product Products { get; set; }
        
        public Guid ProductId { get; set; }
        public Customer Customers { get; set; }
        public Guid CustomerId { get; set; }
    }
}
