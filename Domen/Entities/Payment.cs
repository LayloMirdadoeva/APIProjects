namespace Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string MethodPayment { get; set; }
        public string StatusPayment { get; set; }
        public Order Order { get; set; }
    }
}
