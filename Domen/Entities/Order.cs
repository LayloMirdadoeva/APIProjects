namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public Guid CustomerId { get; set; }
        public Customer customer { get; set; }
        public Guid ProductId { get; set; }
        public Guid DiliveryId { get; set; }
    }
}
