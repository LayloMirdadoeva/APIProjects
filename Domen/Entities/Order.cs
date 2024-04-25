namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        public Product Products { get; set; }
        public Guid ProductId { get; set; }
       
        public Customer Customers { get; set; }
        public Guid CustomerId { get; set; }

        public Dilivery Diliverys { get; set; }
        public Guid DiliveryId { get; set; }
      

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
