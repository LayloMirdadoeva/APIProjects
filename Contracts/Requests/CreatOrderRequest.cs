﻿namespace Contracts.Requests;
public class CreatOrderRequest
{
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
    public decimal TotalPrice { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}
