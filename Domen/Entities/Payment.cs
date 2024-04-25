namespace Domain.Entities
{
    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Method { get; set; }
        public string Status { get; set; }
        public Order Orders { get; set; }
        public Guid OrderId { get; set; }
    }
}
