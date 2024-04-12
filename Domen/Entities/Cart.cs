namespace Domain.Entities
{
    public class Cart : BaseEntity //Cart - это корзина 
    {
        public virtual ICollection<Product> Products { get; set; }
        public Guid ProductId { get; set; }
        public Customer customer { get; set; }
        public Guid CustomerId { get; set; }
    }
}
