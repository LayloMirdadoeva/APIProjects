namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public int ProductQuantity { get; set; }
        public decimal PricePerPiece { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
