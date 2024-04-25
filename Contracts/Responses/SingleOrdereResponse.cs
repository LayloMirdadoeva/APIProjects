namespace Contracts.Responses;
public class SingleOrdereResponse
{
    public Guid Id { get; set; }
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
    public decimal TotalPrice { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}
